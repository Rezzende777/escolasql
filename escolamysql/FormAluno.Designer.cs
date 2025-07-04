namespace escolamysql
{
    partial class FormAluno
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
            textBox2 = new TextBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            panel1 = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            button1 = new Button();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            maskedTextBox3 = new MaskedTextBox();
            label8 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 193);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "TURMA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "NOME:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(63, 11);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(324, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 47);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 4;
            label3.Text = "DATA DE NASCIMENTO:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(156, 40);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 5;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 67);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "SEXO:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(15, 86);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "MASCULINO";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(15, 111);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "FEMININO";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(513, 363);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 9;
            label5.Text = "SITUAÇÃO:";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton3);
            panel1.Location = new Point(498, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(95, 62);
            panel1.TabIndex = 10;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(15, 28);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(73, 19);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "INATIVO";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(15, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "ATIVO";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 241);
            label6.Name = "label6";
            label6.Size = new Size(149, 15);
            label6.TabIndex = 11;
            label6.Text = "NOME DO RESPONSÁVEL:\r\n";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(9, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 23);
            textBox3.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 297);
            label7.Name = "label7";
            label7.Size = new Size(169, 15);
            label7.TabIndex = 13;
            label7.Text = "TELEFONE DO RESPONSÁVEL:\r\n";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(10, 315);
            maskedTextBox2.Mask = "(99) 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "VOLTAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(maskedTextBox3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(maskedTextBox2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(maskedTextBox1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(0, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 456);
            panel2.TabIndex = 16;
            panel2.Paint += panel2_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(69, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(318, 23);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(113, 151);
            maskedTextBox3.Mask = "000.000.000-00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 23);
            maskedTextBox3.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 151);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 16;
            label8.Text = "CPF DO ALUNO:";
            // 
            // button2
            // 
            button2.BackColor = Color.LemonChiffon;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(10, 420);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "SALVAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(button1);
            Name = "FormAluno";
            Text = "FormAluno";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label5;
        private Panel panel1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private MaskedTextBox maskedTextBox2;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private MaskedTextBox maskedTextBox3;
        private Label label8;
        private ComboBox comboBox1;
    }
}