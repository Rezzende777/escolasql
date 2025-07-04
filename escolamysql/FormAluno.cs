using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escolamysql
{
    public partial class FormAluno : Form
    {
        string conexao = "server=127.0.0.1;user=root;password=;database=escolarezzende";
        public FormAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text.Trim();
            string dataTexto = maskedTextBox1.Text.Trim();
            if (!DateTime.TryParse(dataTexto, out DateTime dataConvertida))
            {
                MessageBox.Show("Data de nascimento inválida. Digite no formato dd/mm/aaaa.");
                return;
            }
            // string sexo = radioButton1.Text.Trim();
            string cpfDoAluno = maskedTextBox3.Text.Trim();
            string turma = comboBox1.Text.Trim();
            string nomeDoResponsavel = textBox3.Text.Trim();
            string telefoneDoResponsavel = maskedTextBox2.Text.Trim();
            string id_turma = comboBox1.SelectedValue?.ToString();
            string sexo = "";
            if (radioButton1.Checked)
                sexo = radioButton1.Text;
            else if (radioButton2.Checked)
                sexo = radioButton2.Text;
            else
            {
                MessageBox.Show("Selecione o sexo.");
                return;
            }


            string situacao = "";
            if (radioButton3.Checked)
                situacao = radioButton3.Text;
            else if (radioButton4.Checked)
                situacao = radioButton4.Text;
            else
            {
                MessageBox.Show("Selecione a situação do aluno.");
                return;
            }
            if (nome == "" || dataTexto == "" || cpfDoAluno == "" || nomeDoResponsavel == "" || telefoneDoResponsavel == "" || sexo == "" || situacao == "")
            {
                MessageBox.Show("Campos obrigatórios, preencha corretamente");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string query = "INSERT INTO aluno (nome, dataDeNascimento, sexo, cpfDoAluno, nomeDoResponsavel, telefoneDoResponsavel, situacao, id_turma) " +
               "VALUES (@nome, @dataDeNascimento, @sexo, @cpfDoAluno, @nomeDoResponsavel, @telefoneDoResponsavel, @situacao, @id_turma)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@dataDeNascimento", dataConvertida);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@cpfDoAluno", cpfDoAluno);
                cmd.Parameters.AddWithValue("@id_turma", id_turma);

                cmd.Parameters.AddWithValue("@nomeDoResponsavel", nomeDoResponsavel);
                cmd.Parameters.AddWithValue("@telefoneDoResponsavel", telefoneDoResponsavel);
                cmd.Parameters.AddWithValue("@situacao", situacao);

                cmd.ExecuteNonQuery();

                try
                {
                    //    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aluno cadastrado com sucesso!");
                    textBox2.Text = "";
                    maskedTextBox1.Text = "";
                    maskedTextBox3.Text = "";
                    comboBox1.SelectedIndex = -1;
                    textBox3.Text = "";
                    maskedTextBox2.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro MySQL: " + ex.Message + "\nCódigo: " + ex.Number);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro geral: " + ex.Message);
                }

                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione a turma.");
                    return;
                }

                int idTurma = Convert.ToInt32(comboBox1.SelectedValue);

                //MessageBox.Show("Aluno cadastrado com sucesso!");

                //textBox2.Text = "";
                //maskedTextBox1.Text = "";
                //maskedTextBox3.Text = "";
                //comboBox1.SelectedIndex = -1;
                //textBox3.Text = "";
                //maskedTextBox2.Text = "";
                //radioButton1.Checked = false;
                //radioButton2.Checked = false;
                //radioButton3.Checked = false;
                //radioButton4.Checked = false;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            //int idTurma = Convert.ToInt32(comboBox1.SelectedValue);
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT id, CONCAT(ensino, ' - ', serie, ' - ', sala, ' - ', turno) AS turma_desc FROM turma";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "turma_desc";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedIndex = -1;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
