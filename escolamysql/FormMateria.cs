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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace escolamysql
{
    public partial class FormMateria : Form
    {
        Dictionary<string, int> materiasComCarga = new Dictionary<string, int>()
    {
        { "Matemática", 5 },
        { "Português", 5 },
        { "História", 4 },
        { "Geografia", 4 },
        { "Ciências", 3 },
        { "Física", 2 },
        { "Química", 2 },
        { "Biologia", 2 },
        { "Inglês", 3 }
    };
       
        string conexao = "server=127.0.0.1;user=root;password=;database=escolarezzende";

       
        public FormMateria()
        {
            InitializeComponent();
            comboBox2.Items.Add("Matemática");
            comboBox2.Items.Add("Português");
            comboBox2.Items.Add("História");
            comboBox2.Items.Add("Geografia");
            comboBox2.Items.Add("Ciências");
            comboBox2.Items.Add("Física");
            comboBox2.Items.Add("Química");
            comboBox2.Items.Add("Biologia");
            comboBox2.Items.Add("Inglês");


            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                // Preencher comboBox1 com nomes dos alunos
                string queryAlunos = "SELECT id, nome FROM aluno ORDER BY nome";
                MySqlDataAdapter daAlunos = new MySqlDataAdapter(queryAlunos, conn);
                DataTable dtAlunos = new DataTable();
                daAlunos.Fill(dtAlunos);

                comboBox1.DataSource = dtAlunos;
                comboBox1.DisplayMember = "nome"; // nome visível
                comboBox1.ValueMember = "id";     // valor usado no código
                comboBox1.SelectedIndex = -1;

                // Preencher comboBox2 com nomes das matérias
                string queryMaterias = "SELECT id, nome FROM materia ORDER BY nome";
                MySqlDataAdapter daMaterias = new MySqlDataAdapter(queryMaterias, conn);
                DataTable dtMaterias = new DataTable();
                daMaterias.Fill(dtMaterias);

                comboBox2.DataSource = dtMaterias;
                comboBox2.DisplayMember = "nome";
                comboBox2.ValueMember = "id";
                comboBox2.SelectedIndex = -1;
            }


            //comboBox2.Items.Clear(); 
            //comboBox2.Items.AddRange(materiasComCarga.Keys.ToArray());

            //comboBox1.DataSource = null; 

            //using (MySqlConnection conn = new MySqlConnection(conexao))
            //{
            //    conn.Open();


            //    string query = "SELECT id, nome FROM aluno ORDER BY nome";

            //    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);

            //    comboBox1.DataSource = dt;           
            //    comboBox1.DisplayMember = "nome";    
            //    comboBox1.ValueMember = "id";       
            //    comboBox1.SelectedIndex = -1;        
            //}
            //comboBox2.Items.AddRange(materiasComCarga.Keys.ToArray());
            //using (MySqlConnection conn = new MySqlConnection(conexao))
            //{
            //conn.Open();

            //string queryMaterias = "SELECT id, nome FROM materia";
            //MySqlDataAdapter daMaterias = new MySqlDataAdapter(queryMaterias, conn);
            //DataTable dtMaterias = new DataTable();
            //daMaterias.Fill(dtMaterias);

            //comboBox2.DataSource = dtMaterias;
            //comboBox2.DisplayMember = "nome";
            //comboBox2.ValueMember = "id";
            //comboBox2.SelectedIndex = -1;
            //}
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Você precisa selecionar um aluno!");
                return;
            }
            if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Você precisa selecionar uma matéria!");
                return;
            }

            string cargaAluno = textBox2.Text.Trim();
            string nota1 = maskedTextBox1.Text.Trim();
            string nota2 = maskedTextBox2.Text.Trim();
            string nota3 = maskedTextBox3.Text.Trim();
            string media = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(cargaAluno) || string.IsNullOrEmpty(nota1) || string.IsNullOrEmpty(nota2) || string.IsNullOrEmpty(nota3) || string.IsNullOrEmpty(media))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!double.TryParse(nota1, out double n1) || !double.TryParse(nota2, out double n2) || !double.TryParse(nota3, out double n3))
            {
                MessageBox.Show("As notas devem ser números válidos.");
                return;
            }

            int id_aluno = Convert.ToInt32(comboBox1.SelectedValue);
            int id_materia = Convert.ToInt32(comboBox2.SelectedValue);
            int cargaAlunoInt = 0;
            if (!int.TryParse(cargaAluno, out cargaAlunoInt))
            {
                MessageBox.Show("Carga horária deve ser um número válido.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string query = "INSERT INTO aluno_materia (id_aluno, id_materia, nota1, nota2, nota3, carga_horaria) " +
                               "VALUES (@id_aluno, @id_materia, @nota1, @nota2, @nota3, @cargaAluno)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_aluno", id_aluno);
                cmd.Parameters.AddWithValue("@id_materia", id_materia);
                cmd.Parameters.AddWithValue("@nota1", n1);
                cmd.Parameters.AddWithValue("@nota2", n2);
                cmd.Parameters.AddWithValue("@nota3", n3);
                cmd.Parameters.AddWithValue("@cargaAluno", cargaAlunoInt);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Matéria cadastrada com sucesso!");

                comboBox1.SelectedIndex = -1;
                textBox1.Clear();
                comboBox2.SelectedIndex = -1;
                textBox2.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                maskedTextBox3.Clear();
                textBox3.Clear();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
                return;

            string materia = comboBox2.SelectedItem.ToString();


            switch (materia)
            {
                case "Matemática":
                case "Português":
                    textBox1.Text = "200 horas";
                    break;

                case "História":
                case "Geografia":
                    textBox1.Text = "160 horas";
                    break;

                case "Ciências":
                case "Inglês":
                    textBox1.Text = "120 horas";
                    break;

                case "Física":
                case "Química":
                case "Biologia":
                    textBox1.Text = "80 horas";
                    break;

                default:
                    textBox1.Text = "";
                    break;
            }
        }

        private void maskedTextBox3_Leave(object sender, EventArgs e)
        {
            bool n1ok = double.TryParse(maskedTextBox1.Text, out double nota1);
            bool n2ok = double.TryParse(maskedTextBox2.Text, out double nota2);
            bool n3ok = double.TryParse(maskedTextBox3.Text, out double nota3);

            if (!n1ok || !n2ok || !n3ok)
            {
                MessageBox.Show("Digite todas as 3 notas corretamente.");
                return;
            }

            double media = (nota1 + nota2 + nota3) / 3;

            textBox3.Text = $"{media:F2}";
        }
    }
}
