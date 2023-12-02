namespace BeepMusic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BeepPlayer.NotePlayEvent += BeepPlayer_NotePlayEvent;
        }

        private void BeepPlayer_NotePlayEvent(object sender, BeepPlayer.Note e)
        {

            listView.Invoke(() =>
            {
                listView.Items[BeepPlayer.NowNote].Selected = true;
                listView.EnsureVisible(BeepPlayer.NowNote);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeepPlayer.Analyse(textBoxEdit.Text);
            BeepPlayer.Play();
            listView.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BeepPlayer.Pause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BeepPlayer.Stop();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Console.Beep(Convert.ToInt32(numericUpDownTestFreq.Value), Convert.ToInt32(numericUpDownTestDura.Value));
        }

        private void buttonAnalyse_Click(object sender, EventArgs e)
        {
            buttonClear_Click(sender, e);
            BeepPlayer.Analyse(textBoxEdit.Text);
            int i = 0;
            foreach(var note in BeepPlayer.Score)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(note.Frequency.ToString());
                lvi.SubItems.Add(note.Duration.ToString());
                listView.Items.Add(lvi);
                i++;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            BeepPlayer.Clear();
            listView.Items.Clear();
        }

        private void buttonPP_Click(object sender, EventArgs e)
        {
            BeepPlayer.PlayPause();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            BeepPlayer.Stop();
        }
    }
}
