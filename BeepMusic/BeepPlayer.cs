using System.ComponentModel;
using System.Security.Policy;

namespace BeepMusic
{
    internal static class BeepPlayer
    {
        public struct Note(int freq = 1000, int duration = 1000)
        {
            public int Frequency = freq;
            public int Duration = duration;

            public override readonly string ToString()
            {
                return Frequency.ToString() + "," + Duration.ToString();
            }
        }

        public enum BeepPlayerStatus
        {
            Play = 0,
            Pause = 1,
            Stop = 2,
            NoAnalyse = 3
        }

        public static Note[] Score { get; set; } = new Note[0];

        public static int TotalNote { get { return Score.Length; } }

        private static BeepPlayerStatus _status = BeepPlayerStatus.NoAnalyse;
        public static BeepPlayerStatus Status { get { return _status; } }

        private static int _nowNote = 0;
        public static int NowNote { get { return _nowNote; } }

        public static event NotePlayHandler NotePlayEvent;

        public delegate void NotePlayHandler(object sender, Note e);

        private static BackgroundWorker worker = new BackgroundWorker() { WorkerSupportsCancellation = true };

        static BeepPlayer()
        {
            worker.DoWork += Worker_DoWork;
        }

        public static void Analyse(string musicScoreText)
        {
            Stop();
            string[] musicScore = musicScoreText.Split('|');
            Note[] notes = new Note[musicScore.Length];
            for(int i = 0;i < musicScore.Length;i++)
            {
                string[] note = musicScore[i].Split(',');
                notes[i].Frequency = int.Parse(note[0]);
                notes[i].Duration = int.Parse(note[1]);
            }
            Score = notes;
            _status = BeepPlayerStatus.Stop;
        }        
        
        public static void Clear()
        {
            Stop();
            Score = new Note[0];
            _status = BeepPlayerStatus.NoAnalyse;
        }

        public static void Play()
        {
            if (_status == BeepPlayerStatus.NoAnalyse)
                return;
            _status = BeepPlayerStatus.Play;
            worker.RunWorkerAsync();
        }        
        
        public static void Pause()
        {
            _status = BeepPlayerStatus.Pause;
            worker.CancelAsync();
        }        
        
        public static void PlayPause()
        {
            if (_status == BeepPlayerStatus.Pause || _status == BeepPlayerStatus.Stop)
                Play();
            else if (_status == BeepPlayerStatus.Play)
                Pause();
        }

        public static void Stop()
        {
            _status = BeepPlayerStatus.Stop;
            worker.CancelAsync();
            _nowNote = 0;
        }

        private static void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (_status == BeepPlayerStatus.NoAnalyse)
                Stop();
            do
            {
                var note = Score[_nowNote];
                NotePlayEvent(new object(), note);
                if (note.Frequency >= 37 && note.Frequency <= 32767)
                {
                    Console.Beep(note.Frequency, note.Duration);
                }
                else
                {
                    Thread.Sleep(note.Duration);
                }
                _nowNote++;
            } while(worker.CancellationPending == false);
            e.Cancel = true;
            Stop();
        }
    }
}