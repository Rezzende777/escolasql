namespace escolamysql
{
    partial class FormCadastros
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
            menuStrip1 = new MenuStrip();
            eSCOLAToolStripMenuItem = new ToolStripMenuItem();
            eSCOLAToolStripMenuItem1 = new ToolStripMenuItem();
            tURMAToolStripMenuItem = new ToolStripMenuItem();
            aLUNOToolStripMenuItem = new ToolStripMenuItem();
            mATERIAToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { eSCOLAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // eSCOLAToolStripMenuItem
            // 
            eSCOLAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eSCOLAToolStripMenuItem1, tURMAToolStripMenuItem, aLUNOToolStripMenuItem, mATERIAToolStripMenuItem });
            eSCOLAToolStripMenuItem.Name = "eSCOLAToolStripMenuItem";
            eSCOLAToolStripMenuItem.Size = new Size(53, 20);
            eSCOLAToolStripMenuItem.Text = "MENU";
            // 
            // eSCOLAToolStripMenuItem1
            // 
            eSCOLAToolStripMenuItem1.Name = "eSCOLAToolStripMenuItem1";
            eSCOLAToolStripMenuItem1.Size = new Size(123, 22);
            eSCOLAToolStripMenuItem1.Text = "ESCOLA";
            eSCOLAToolStripMenuItem1.Click += eSCOLAToolStripMenuItem1_Click;
            // 
            // tURMAToolStripMenuItem
            // 
            tURMAToolStripMenuItem.Name = "tURMAToolStripMenuItem";
            tURMAToolStripMenuItem.Size = new Size(123, 22);
            tURMAToolStripMenuItem.Text = "TURMA";
            tURMAToolStripMenuItem.Click += tURMAToolStripMenuItem_Click;
            // 
            // aLUNOToolStripMenuItem
            // 
            aLUNOToolStripMenuItem.Name = "aLUNOToolStripMenuItem";
            aLUNOToolStripMenuItem.Size = new Size(123, 22);
            aLUNOToolStripMenuItem.Text = "ALUNO";
            aLUNOToolStripMenuItem.Click += aLUNOToolStripMenuItem_Click;
            // 
            // mATERIAToolStripMenuItem
            // 
            mATERIAToolStripMenuItem.Name = "mATERIAToolStripMenuItem";
            mATERIAToolStripMenuItem.Size = new Size(123, 22);
            mATERIAToolStripMenuItem.Text = "MATERIA";
            mATERIAToolStripMenuItem.Click += mATERIAToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 424);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 27);
            label1.Name = "label1";
            label1.Size = new Size(163, 29);
            label1.TabIndex = 4;
            label1.Text = "CADASTROS";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "FECHAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "FormCadastros";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem eSCOLAToolStripMenuItem;
        private ToolStripMenuItem eSCOLAToolStripMenuItem1;
        private ToolStripMenuItem tURMAToolStripMenuItem;
        private ToolStripMenuItem aLUNOToolStripMenuItem;
        private ToolStripMenuItem mATERIAToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private Button button1;
    }
}
