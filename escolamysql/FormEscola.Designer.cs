namespace escolamysql
{
    partial class FormEscola
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
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "NOME FNTASIA:\r\n";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Validating += textBox2_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 54);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "RAZÃO SOCIAL:\r\n";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(332, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 98);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "CNPJ:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(112, 95);
            maskedTextBox1.Mask = "00.000.000/0000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(170, 23);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            maskedTextBox1.Leave += maskedTextBox1_Leave;
            maskedTextBox1.Validating += maskedTextBox1_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 145);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "ENDEREÇO:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(112, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(332, 23);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(77, 185);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 10;
            label6.Text = "TEL:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(112, 182);
            maskedTextBox2.Mask = "(99) 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(172, 23);
            maskedTextBox2.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(713, 424);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "VOLTAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 451);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.LemonChiffon;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(10, 425);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "SALVAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "formEscola";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private MaskedTextBox maskedTextBox2;
        private Button button1;
        private Panel panel1;
        private Button button2;
    }
}