namespace MiscTest
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
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            checkBoxTab1AutoCopy = new CheckBox();
            groupBox2 = new GroupBox();
            textBoxTab1DecOutput = new TextBox();
            label2 = new Label();
            textBoxTab1DecInput = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxTab1Output = new TextBox();
            labelTab1Output = new Label();
            labelTab1Input = new Label();
            textBoxTab1Input = new TextBox();
            tabPage2 = new TabPage();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 400);
            panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(800, 400);
            splitContainer1.SplitterDistance = 44;
            splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(752, 400);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(checkBoxTab1AutoCopy);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(744, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxTab1AutoCopy
            // 
            checkBoxTab1AutoCopy.AutoSize = true;
            checkBoxTab1AutoCopy.Checked = true;
            checkBoxTab1AutoCopy.CheckState = CheckState.Checked;
            checkBoxTab1AutoCopy.Location = new Point(12, 185);
            checkBoxTab1AutoCopy.Name = "checkBoxTab1AutoCopy";
            checkBoxTab1AutoCopy.Size = new Size(409, 24);
            checkBoxTab1AutoCopy.TabIndex = 4;
            checkBoxTab1AutoCopy.Text = "自動コピー（エンコード側の出力をデコード側の入力にコピーする）";
            checkBoxTab1AutoCopy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(textBoxTab1DecOutput);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxTab1DecInput);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(6, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(730, 146);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "デコード";
            // 
            // textBoxTab1DecOutput
            // 
            textBoxTab1DecOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTab1DecOutput.Location = new Point(6, 99);
            textBoxTab1DecOutput.Name = "textBoxTab1DecOutput";
            textBoxTab1DecOutput.Size = new Size(718, 27);
            textBoxTab1DecOutput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "output";
            // 
            // textBoxTab1DecInput
            // 
            textBoxTab1DecInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTab1DecInput.Location = new Point(6, 46);
            textBoxTab1DecInput.Name = "textBoxTab1DecInput";
            textBoxTab1DecInput.Size = new Size(718, 27);
            textBoxTab1DecInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "input";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBoxTab1Output);
            groupBox1.Controls.Add(labelTab1Output);
            groupBox1.Controls.Add(labelTab1Input);
            groupBox1.Controls.Add(textBoxTab1Input);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 145);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "パーセントエンコーディング";
            // 
            // textBoxTab1Output
            // 
            textBoxTab1Output.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTab1Output.Location = new Point(6, 99);
            textBoxTab1Output.Name = "textBoxTab1Output";
            textBoxTab1Output.Size = new Size(718, 27);
            textBoxTab1Output.TabIndex = 3;
            // 
            // labelTab1Output
            // 
            labelTab1Output.AutoSize = true;
            labelTab1Output.Location = new Point(6, 76);
            labelTab1Output.Name = "labelTab1Output";
            labelTab1Output.Size = new Size(55, 20);
            labelTab1Output.TabIndex = 2;
            labelTab1Output.Text = "Output";
            // 
            // labelTab1Input
            // 
            labelTab1Input.AutoSize = true;
            labelTab1Input.Location = new Point(6, 23);
            labelTab1Input.Name = "labelTab1Input";
            labelTab1Input.Size = new Size(43, 20);
            labelTab1Input.TabIndex = 1;
            labelTab1Input.Text = "Input";
            // 
            // textBoxTab1Input
            // 
            textBoxTab1Input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTab1Input.Location = new Point(6, 46);
            textBoxTab1Input.Name = "textBoxTab1Input";
            textBoxTab1Input.Size = new Size(718, 27);
            textBoxTab1Input.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(763, 367);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TextBox textBoxTab1Output;
        private Label labelTab1Output;
        private Label labelTab1Input;
        private TextBox textBoxTab1Input;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private TextBox textBoxTab1DecOutput;
        private Label label2;
        private TextBox textBoxTab1DecInput;
        private Label label1;
        private CheckBox checkBoxTab1AutoCopy;
    }
}
