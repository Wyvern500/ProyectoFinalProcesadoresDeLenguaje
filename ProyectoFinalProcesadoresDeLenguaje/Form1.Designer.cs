namespace ProyectoFinalProcesadoresDeLenguaje
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            excludeFileExtensionsToolStripMenuItem = new ToolStripMenuItem();
            excludeLinesWithACertainStartToolStripMenuItem = new ToolStripMenuItem();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            onlyFileExtensionsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 149);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Lines: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 164);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Size: ";
            // 
            // button1
            // 
            button1.Location = new Point(167, 81);
            button1.Name = "button1";
            button1.Size = new Size(145, 23);
            button1.TabIndex = 2;
            button1.Text = "Choose Root Directory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excludeFileExtensionsToolStripMenuItem, excludeLinesWithACertainStartToolStripMenuItem, onlyFileExtensionsToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // excludeFileExtensionsToolStripMenuItem
            // 
            excludeFileExtensionsToolStripMenuItem.Name = "excludeFileExtensionsToolStripMenuItem";
            excludeFileExtensionsToolStripMenuItem.Size = new Size(245, 22);
            excludeFileExtensionsToolStripMenuItem.Text = "Exclude File Extensions";
            excludeFileExtensionsToolStripMenuItem.Click += excludeFileExtensionsToolStripMenuItem_Click;
            // 
            // excludeLinesWithACertainStartToolStripMenuItem
            // 
            excludeLinesWithACertainStartToolStripMenuItem.Name = "excludeLinesWithACertainStartToolStripMenuItem";
            excludeLinesWithACertainStartToolStripMenuItem.Size = new Size(245, 22);
            excludeLinesWithACertainStartToolStripMenuItem.Text = "Exclude Lines with a certain start";
            excludeLinesWithACertainStartToolStripMenuItem.Click += excludeLinesWithACertainStartToolStripMenuItem_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(167, 189);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Ignore empty lines";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(167, 214);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(104, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Ignore imports";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 258);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(317, 180);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 240);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 7;
            label3.Text = "Filter params: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 39);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "Path:";
            // 
            // button2
            // 
            button2.Location = new Point(167, 110);
            button2.Name = "button2";
            button2.Size = new Size(81, 23);
            button2.TabIndex = 9;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 89);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "Files:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 63);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 11;
            label6.Text = "Progress:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(361, 114);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 12;
            label7.Text = "Ignored Files:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(501, 63);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 13;
            label8.Text = "Exclude Files:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(362, 218);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 14;
            label9.Text = "Exclude Files:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(501, 130);
            label10.Name = "label10";
            label10.Size = new Size(175, 15);
            label10.TabIndex = 15;
            label10.Text = "Exclude files with a certain start:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(501, 230);
            label11.Name = "label11";
            label11.Size = new Size(142, 15);
            label11.TabIndex = 16;
            label11.Text = "Only files with extension: ";
            // 
            // onlyFileExtensionsToolStripMenuItem
            // 
            onlyFileExtensionsToolStripMenuItem.Name = "onlyFileExtensionsToolStripMenuItem";
            onlyFileExtensionsToolStripMenuItem.Size = new Size(245, 22);
            onlyFileExtensionsToolStripMenuItem.Text = "Only File Extensions";
            onlyFileExtensionsToolStripMenuItem.Click += onlyFileExtensionsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "    ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem excludeFileExtensionsToolStripMenuItem;
        private ToolStripMenuItem excludeLinesWithACertainStartToolStripMenuItem;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ToolStripMenuItem onlyFileExtensionsToolStripMenuItem;
    }
}
