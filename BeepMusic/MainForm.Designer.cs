namespace BeepMusic
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonAnalyse = new Button();
            buttonClear = new Button();
            buttonPP = new Button();
            buttonStop = new Button();
            labelStatus = new Label();
            labelProgress = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            numericUpDownTestFreq = new NumericUpDown();
            label2 = new Label();
            numericUpDownTestDura = new NumericUpDown();
            buttonTest = new Button();
            groupBox1 = new GroupBox();
            textBoxEdit = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTestFreq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTestDura).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(952, 361);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(479, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 355);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "播放器";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(listView, 0, 1);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(464, 333);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView.Dock = DockStyle.Fill;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(5, 40);
            listView.Margin = new Padding(5);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(454, 288);
            listView.TabIndex = 7;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "#";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "频率";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "持续时间";
            columnHeader3.Width = 100;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(buttonAnalyse);
            flowLayoutPanel2.Controls.Add(buttonClear);
            flowLayoutPanel2.Controls.Add(buttonPP);
            flowLayoutPanel2.Controls.Add(buttonStop);
            flowLayoutPanel2.Controls.Add(labelStatus);
            flowLayoutPanel2.Controls.Add(labelProgress);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(458, 29);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // buttonAnalyse
            // 
            buttonAnalyse.Location = new Point(3, 3);
            buttonAnalyse.Name = "buttonAnalyse";
            buttonAnalyse.Size = new Size(75, 23);
            buttonAnalyse.TabIndex = 0;
            buttonAnalyse.Text = "解析";
            buttonAnalyse.UseVisualStyleBackColor = true;
            buttonAnalyse.Click += buttonAnalyse_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(84, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "清空";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonPP
            // 
            buttonPP.Location = new Point(165, 3);
            buttonPP.Name = "buttonPP";
            buttonPP.Size = new Size(75, 23);
            buttonPP.TabIndex = 2;
            buttonPP.Text = "播放/暂停";
            buttonPP.UseVisualStyleBackColor = true;
            buttonPP.Click += buttonPP_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(246, 3);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 23);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "停止";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(327, 5);
            labelStatus.Margin = new Padding(3, 5, 3, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(44, 17);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "未解析";
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(377, 5);
            labelProgress.Margin = new Padding(3, 5, 3, 0);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(27, 17);
            labelProgress.TabIndex = 5;
            labelProgress.Text = "0/0";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(470, 355);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 298);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(464, 54);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "测试";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(numericUpDownTestFreq);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(numericUpDownTestDura);
            flowLayoutPanel1.Controls.Add(buttonTest);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(458, 32);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Margin = new Padding(3, 5, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "频率";
            // 
            // numericUpDownTestFreq
            // 
            numericUpDownTestFreq.Location = new Point(41, 3);
            numericUpDownTestFreq.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numericUpDownTestFreq.Minimum = new decimal(new int[] { 37, 0, 0, 0 });
            numericUpDownTestFreq.Name = "numericUpDownTestFreq";
            numericUpDownTestFreq.Size = new Size(60, 23);
            numericUpDownTestFreq.TabIndex = 1;
            numericUpDownTestFreq.Value = new decimal(new int[] { 600, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 5);
            label2.Margin = new Padding(3, 5, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 2;
            label2.Text = "持续时间";
            // 
            // numericUpDownTestDura
            // 
            numericUpDownTestDura.Location = new Point(169, 3);
            numericUpDownTestDura.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDownTestDura.Name = "numericUpDownTestDura";
            numericUpDownTestDura.Size = new Size(60, 23);
            numericUpDownTestDura.TabIndex = 3;
            numericUpDownTestDura.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(235, 3);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(75, 23);
            buttonTest.TabIndex = 4;
            buttonTest.Text = "测试";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxEdit);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "编辑";
            // 
            // textBoxEdit
            // 
            textBoxEdit.Dock = DockStyle.Fill;
            textBoxEdit.Location = new Point(3, 19);
            textBoxEdit.Margin = new Padding(5);
            textBoxEdit.Multiline = true;
            textBoxEdit.Name = "textBoxEdit";
            textBoxEdit.ScrollBars = ScrollBars.Vertical;
            textBoxEdit.Size = new Size(458, 267);
            textBoxEdit.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 361);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "BeepMusic";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTestFreq).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTestDura).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox3;
        private TextBox textBoxEdit;
        private Button buttonTest;
        private NumericUpDown numericUpDownTestDura;
        private Label label2;
        private NumericUpDown numericUpDownTestFreq;
        private Label label1;
        private Button buttonPP;
        private Button buttonClear;
        private Button buttonAnalyse;
        private Button buttonStop;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label labelStatus;
        private Label labelProgress;
    }
}
