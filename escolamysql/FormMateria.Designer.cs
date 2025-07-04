namespace escolamysql
{
    partial class FormMateria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox3 = new TextBox();
            label9 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "MATERIA:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 70);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "CARGA HORÁRIA:\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "VOLTAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(231, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(maskedTextBox3);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 453);
            panel1.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(52, 23);
            textBox3.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(237, 185);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 20;
            label9.Text = "MEDIA:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(289, 139);
            maskedTextBox3.Mask = "00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(52, 23);
            maskedTextBox3.TabIndex = 19;
            maskedTextBox3.Leave += maskedTextBox3_Leave;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(289, 111);
            maskedTextBox2.Mask = "00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(52, 23);
            maskedTextBox2.TabIndex = 18;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(289, 82);
            maskedTextBox1.Mask = "00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(52, 23);
            maskedTextBox1.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(231, 142);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 16;
            label8.Text = "NOTA 3:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(231, 114);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 15;
            label7.Text = "NOTA 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(231, 85);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 14;
            label6.Text = "NOTA 1:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(136, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 407);
            panel2.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(456, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(456, 10);
            label5.Name = "label5";
            label5.Size = new Size(172, 15);
            label5.TabIndex = 11;
            label5.Text = "CARGA HORÁRIA DO ALUNO:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Matemática  ", "Português  ", "História  ", "Geografia  ", "Ciências  ", "Física  ", "Química  ", "Biologia  ", "Inglês" });
            comboBox2.Location = new Point(11, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(231, 14);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 9;
            label4.Text = "NOME DO ALUNO:";
            // 
            // button2
            // 
            button2.BackColor = Color.LemonChiffon;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(11, 416);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "SALVAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 64);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // FormMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "FormMateria";
            Text = "FormMateria";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label3;
        private Button button2;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private TextBox textBox2;
        private Panel panel2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private Label label9;
    }
}