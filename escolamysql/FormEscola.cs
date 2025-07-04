using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace escolamysql
{
    public partial class FormEscola : Form
    {
        private bool isFechando = false;
        string conexao = "server=127.0.0.1;user=root;password=;database=escolarezzende";


        public FormEscola()
        {
            InitializeComponent();
        }
        private bool NomeFantasiaValido(string nome)
        {

            if (nome.Length < 2)
                return false;


            string pattern = @"^[A-Za-zÀ-ÿ0-9\s\.\,\-\/\&\+']+$";
            return Regex.IsMatch(nome, pattern);
        }



        private bool ValidarCNPJ(string cnpj)
        {
            if (cnpj.Length != 14 || cnpj.Distinct().Count() == 1)
                return false;

            int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string baseCnpj = cnpj.Substring(0, 12);

            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(baseCnpj[i].ToString()) * peso1[i];
            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            baseCnpj += digito1;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(baseCnpj[i].ToString()) * peso2[i];
            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            return cnpj.EndsWith($"{digito1}{digito2}");
        }



        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isFechando = true;
            this.Close();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (isFechando) return;
            string cnpj = new string(maskedTextBox1.Text.Where(char.IsDigit).ToArray());

            if (!ValidarCNPJ(cnpj))
            {
                MessageBox.Show("CNPJ inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox1.Clear();
                maskedTextBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (isFechando) return;
            if (!NomeFantasiaValido(textBox2.Text.Trim()))

            {
                MessageBox.Show("Nome Fantasia inválido. Use apenas letras, números e símbolos comuns.");
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string nomeFantasia = textBox2.Text.Trim();
            string razaoSocial = textBox3.Text.Trim();
            string cnpj = maskedTextBox1.Text.Trim();
            string endereco = textBox4.Text.Trim();
            string telefone = maskedTextBox2.Text.Trim();

            if (nomeFantasia == "" || razaoSocial == "" || cnpj == "")
            {
                MessageBox.Show("Campos obrigatórios: Nome Fantasia, Razão Social e CNPJ");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string query = "INSERT INTO escola (nome_fantasia, razao_social, cnpj, endereco, telefone)" +
                               "VALUES (@nome, @razao, @cnpj, @endereco, @telefone)";



                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", nomeFantasia);
                cmd.Parameters.AddWithValue("@razao", razaoSocial);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Escola cadastrada!");
                textBox2.Clear();
                textBox3.Clear();
                maskedTextBox1.Clear();
                textBox4.Clear();
                maskedTextBox2.Clear();

                //if (ex.Number == 1062) 
                //    MessageBox.Show("Esse CNPJ já está cadastrado.");
                //else
                //    MessageBox.Show("Erro ao inserir: " + ex.Message);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}   
