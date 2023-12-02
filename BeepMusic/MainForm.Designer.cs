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
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            buttonStop = new Button();
            buttonPP = new Button();
            buttonClear = new Button();
            buttonAnalyse = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            buttonTest = new Button();
            numericUpDownTestDura = new NumericUpDown();
            label2 = new Label();
            numericUpDownTestFreq = new NumericUpDown();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxEdit = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTestDura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTestFreq).BeginInit();
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
            tableLayoutPanel1.Size = new Size(837, 542);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView);
            groupBox2.Controls.Add(buttonStop);
            groupBox2.Controls.Add(buttonPP);
            groupBox2.Controls.Add(buttonClear);
            groupBox2.Controls.Add(buttonAnalyse);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(421, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 536);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "播放";
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(6, 80);
            listView.Name = "listView";
            listView.Size = new Size(398, 447);
            listView.TabIndex = 4;
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
            // buttonStop
            // 
            buttonStop.Location = new Point(87, 51);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 23);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "停止";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonPP
            // 
            buttonPP.Location = new Point(6, 51);
            buttonPP.Name = "buttonPP";
            buttonPP.Size = new Size(75, 23);
            buttonPP.TabIndex = 2;
            buttonPP.Text = "播放/暂停";
            buttonPP.UseVisualStyleBackColor = true;
            buttonPP.Click += buttonPP_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(87, 22);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "清空";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAnalyse
            // 
            buttonAnalyse.Location = new Point(6, 22);
            buttonAnalyse.Name = "buttonAnalyse";
            buttonAnalyse.Size = new Size(75, 23);
            buttonAnalyse.TabIndex = 0;
            buttonAnalyse.Text = "解析";
            buttonAnalyse.UseVisualStyleBackColor = true;
            buttonAnalyse.Click += buttonAnalyse_Click;
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
            tableLayoutPanel2.Size = new Size(412, 536);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonTest);
            groupBox3.Controls.Add(numericUpDownTestDura);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(numericUpDownTestFreq);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 479);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(406, 54);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "测试";
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(325, 17);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(75, 23);
            buttonTest.TabIndex = 4;
            buttonTest.Text = "测试";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // numericUpDownTestDura
            // 
            numericUpDownTestDura.Location = new Point(185, 18);
            numericUpDownTestDura.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDownTestDura.Minimum = new decimal(new int[] { 37, 0, 0, 0 });
            numericUpDownTestDura.Name = "numericUpDownTestDura";
            numericUpDownTestDura.Size = new Size(60, 23);
            numericUpDownTestDura.TabIndex = 3;
            numericUpDownTestDura.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 20);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 2;
            label2.Text = "持续时间";
            // 
            // numericUpDownTestFreq
            // 
            numericUpDownTestFreq.Location = new Point(48, 18);
            numericUpDownTestFreq.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDownTestFreq.Minimum = new decimal(new int[] { 37, 0, 0, 0 });
            numericUpDownTestFreq.Name = "numericUpDownTestFreq";
            numericUpDownTestFreq.Size = new Size(60, 23);
            numericUpDownTestFreq.TabIndex = 1;
            numericUpDownTestFreq.Value = new decimal(new int[] { 700, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "频率";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxEdit);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 470);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "编辑";
            // 
            // textBoxEdit
            // 
            textBoxEdit.Dock = DockStyle.Fill;
            textBoxEdit.Location = new Point(3, 19);
            textBoxEdit.Multiline = true;
            textBoxEdit.Name = "textBoxEdit";
            textBoxEdit.ScrollBars = ScrollBars.Vertical;
            textBoxEdit.Size = new Size(400, 448);
            textBoxEdit.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 542);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "BeepMusic";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTestDura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTestFreq).EndInit();
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
        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
