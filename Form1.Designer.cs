namespace XGP_Shortcut
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            shortcutPreview = new PictureBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            splitContainer1 = new SplitContainer();
            textBoxGamePath = new TextBox();
            buttonBrowse = new Button();
            textBoxArguments = new TextBox();
            splitContainer2 = new SplitContainer();
            comboBoxCommonArguments = new ComboBox();
            buttonAddArgument = new Button();
            buttonCreateShortcut = new Button();
            groupBox3 = new GroupBox();
            logOutput = new ListBox();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButtonLicenses = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)shortcutPreview).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // shortcutPreview
            // 
            shortcutPreview.Anchor = AnchorStyles.None;
            shortcutPreview.BorderStyle = BorderStyle.Fixed3D;
            shortcutPreview.Location = new Point(48, 50);
            shortcutPreview.Name = "shortcutPreview";
            shortcutPreview.Size = new Size(44, 44);
            shortcutPreview.SizeMode = PictureBoxSizeMode.CenterImage;
            shortcutPreview.TabIndex = 4;
            shortcutPreview.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(704, 156);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(shortcutPreview);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(144, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Shortcut Preview";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(153, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 150);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "File";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(splitContainer1);
            flowLayoutPanel1.Controls.Add(textBoxArguments);
            flowLayoutPanel1.Controls.Add(splitContainer2);
            flowLayoutPanel1.Controls.Add(buttonCreateShortcut);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(279, 128);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBoxGamePath);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonBrowse);
            splitContainer1.Size = new Size(269, 23);
            splitContainer1.SplitterDistance = 201;
            splitContainer1.TabIndex = 0;
            // 
            // textBoxGamePath
            // 
            textBoxGamePath.Dock = DockStyle.Fill;
            textBoxGamePath.Enabled = false;
            textBoxGamePath.Location = new Point(0, 0);
            textBoxGamePath.Name = "textBoxGamePath";
            textBoxGamePath.PlaceholderText = "Browse to a game install folder.";
            textBoxGamePath.Size = new Size(201, 23);
            textBoxGamePath.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Dock = DockStyle.Fill;
            buttonBrowse.Location = new Point(0, 0);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(64, 23);
            buttonBrowse.TabIndex = 1;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // textBoxArguments
            // 
            textBoxArguments.Dock = DockStyle.Top;
            textBoxArguments.Location = new Point(3, 32);
            textBoxArguments.Name = "textBoxArguments";
            textBoxArguments.PlaceholderText = "Arguments";
            textBoxArguments.Size = new Size(269, 23);
            textBoxArguments.TabIndex = 2;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Top;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(3, 61);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(comboBoxCommonArguments);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(buttonAddArgument);
            splitContainer2.Size = new Size(269, 23);
            splitContainer2.SplitterDistance = 201;
            splitContainer2.TabIndex = 0;
            // 
            // comboBoxCommonArguments
            // 
            comboBoxCommonArguments.Dock = DockStyle.Fill;
            comboBoxCommonArguments.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCommonArguments.FormattingEnabled = true;
            comboBoxCommonArguments.Items.AddRange(new object[] { "-nointro", "-skipintro", "-nostartupmovies", "-novideo", "-skipmovies" });
            comboBoxCommonArguments.Location = new Point(0, 0);
            comboBoxCommonArguments.Name = "comboBoxCommonArguments";
            comboBoxCommonArguments.Size = new Size(201, 23);
            comboBoxCommonArguments.TabIndex = 3;
            // 
            // buttonAddArgument
            // 
            buttonAddArgument.Dock = DockStyle.Fill;
            buttonAddArgument.Location = new Point(0, 0);
            buttonAddArgument.Name = "buttonAddArgument";
            buttonAddArgument.Size = new Size(64, 23);
            buttonAddArgument.TabIndex = 4;
            buttonAddArgument.Text = "Add";
            buttonAddArgument.UseVisualStyleBackColor = true;
            buttonAddArgument.Click += buttonAddArgument_Click;
            // 
            // buttonCreateShortcut
            // 
            buttonCreateShortcut.Dock = DockStyle.Top;
            buttonCreateShortcut.Location = new Point(3, 90);
            buttonCreateShortcut.Name = "buttonCreateShortcut";
            buttonCreateShortcut.Size = new Size(269, 23);
            buttonCreateShortcut.TabIndex = 5;
            buttonCreateShortcut.Text = "Create Shortcut";
            buttonCreateShortcut.UseVisualStyleBackColor = true;
            buttonCreateShortcut.Click += buttonCreateShortcut_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(logOutput);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(444, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 150);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Log";
            // 
            // logOutput
            // 
            logOutput.Dock = DockStyle.Fill;
            logOutput.FormattingEnabled = true;
            logOutput.HorizontalScrollbar = true;
            logOutput.Location = new Point(3, 19);
            logOutput.Margin = new Padding(3, 2, 3, 2);
            logOutput.Name = "logOutput";
            logOutput.Size = new Size(251, 128);
            logOutput.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButtonLicenses, toolStripSeparator1, toolStripLabel2 });
            toolStrip1.Location = new Point(0, 156);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(704, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Enabled = false;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(63, 22);
            toolStripLabel1.Text = "Version 1.0";
            // 
            // toolStripButtonLicenses
            // 
            toolStripButtonLicenses.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonLicenses.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonLicenses.Image = (Image)resources.GetObject("toolStripButtonLicenses.Image");
            toolStripButtonLicenses.ImageTransparentColor = Color.Magenta;
            toolStripButtonLicenses.Name = "toolStripButtonLicenses";
            toolStripButtonLicenses.Size = new Size(117, 22);
            toolStripButtonLicenses.Text = "Third-Party Licenses";
            toolStripButtonLicenses.ToolTipText = "Licenses";
            toolStripButtonLicenses.Click += toolStripButtonLicenses_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Enabled = false;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(126, 22);
            toolStripLabel2.Text = "© 2025 EvokeMadness";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(704, 181);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XGP-Shortcut";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)shortcutPreview).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox shortcutPreview;
        private FolderBrowserDialog folderBrowserDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonLicenses;
        private GroupBox groupBox3;
        private ListBox logOutput;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private SplitContainer splitContainer1;
        private Button buttonBrowse;
        private SplitContainer splitContainer2;
        private ComboBox comboBoxCommonArguments;
        private Button buttonAddArgument;
        private Button buttonCreateShortcut;
        private TextBox textBoxGamePath;
        private TextBox textBoxArguments;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
    }
}
