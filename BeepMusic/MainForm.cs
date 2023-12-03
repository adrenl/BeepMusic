namespace BeepMusic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BeepPlayer.NotePlayEvent += BeepPlayer_NotePlayEvent;
            BeepPlayer.PlayCompleteEvent += BeepPlayer_PlayCompleteEvent;
        }

        private void BeepPlayer_PlayCompleteEvent()
        {
            
        }

        private void BeepPlayer_NotePlayEvent(BeepPlayer.Note e)
        {
            listView.Invoke(() =>
            {
                listView.Items[BeepPlayer.NowNote].Selected = true;
                listView.EnsureVisible(BeepPlayer.NowNote);
            });
            labelProgress.Invoke(() =>
            {
                labelProgress.Text = BeepPlayer.NowNote.ToString() + "/" + BeepPlayer.TotalNote.ToString();
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
            if (BeepPlayer.Analyse(textBoxEdit.Text))
            {
                int i = 0;
                foreach (var note in BeepPlayer.Score)
                {
                    ListViewItem lvi = new ListViewItem(i.ToString());
                    lvi.SubItems.Add(note.Frequency.ToString());
                    lvi.SubItems.Add(note.Duration.ToString());
                    listView.Items.Add(lvi);
                    i++;
                }
                labelStatus.Text = "Õ£÷π";
                labelProgress.Text = "0/" + BeepPlayer.TotalNote.ToString();
            }
            else
            {
                labelStatus.Text = "Œ¥Ω‚Œˆ£®Ω‚Œˆ ß∞‹£©";
                labelProgress.Text = "0/0";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            BeepPlayer.Clear();
            listView.Items.Clear();
            labelStatus.Text = "Œ¥Ω‚Œˆ";
            labelProgress.Text = "0/0";
        }

        private void buttonPP_Click(object sender, EventArgs e)
        {
            if (BeepPlayer.PlayPause())
            {
                if (BeepPlayer.Status == BeepPlayer.BeepPlayerStatus.Play)
                    labelStatus.Text = "≤•∑≈";
                else if (BeepPlayer.Status == BeepPlayer.BeepPlayerStatus.Pause)
                    labelStatus.Text = "‘›Õ£";
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (BeepPlayer.Stop())
            {
                labelStatus.Text = "Õ£÷π";
                labelProgress.Text = "0/" + BeepPlayer.TotalNote.ToString();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            IntPtr sysMenuHandle = DLLImport.GetSystemMenu(this.Handle, false);

            DLLImport.InsertMenu(sysMenuHandle, 5, DLLImport.MF_BYPOSITION | DLLImport.MF_SEPARATOR, 0, string.Empty);
            DLLImport.InsertMenu(sysMenuHandle, 6, DLLImport.MF_BYPOSITION, DLLImport.IDM_ABOUT, "πÿ”⁄ BeepMusic");
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == DLLImport.WM_SYSCOMMAND)
            {
                switch (m.WParam.ToInt32())
                {
                    case DLLImport.IDM_ABOUT:
                        new AboutForm().ShowDialog();
                        return;
                    default:
                        break;
                }
            }
            base.WndProc(ref m);
        }
    }
}
