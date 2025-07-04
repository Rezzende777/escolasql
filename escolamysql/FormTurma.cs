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
    public partial class FormTurma : Form
    {
        bool carregando = false;
        string[] turnos = { "Matutino", "Vespertino", "Noturno" };
        string conexao = "server=127.0.0.1;user=root;password=;database=escolarezzende";
       

        public FormTurma()
        {
            
            InitializeComponent();
            CarregarEscolas();
        }
        private void CarregarEscolas()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT id_escola, nome_fantasia FROM escola";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "nome_fantasia"; 
                comboBox5.ValueMember = "id_escola";      
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

            comboBox1.Items.AddRange(new string[] { "Fundamental", "Médio" });
            comboBox3.Items.AddRange(new string[] { "Sala A", "Sala B", "Sala C", "Sala D" });
            comboBox4.Items.AddRange(new string[] { "Matutino", "Vespertino", "Noturno" });

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                // Consulta para listar as escolas
                string queryEscolas = "SELECT id_escola, nome_fantasia FROM escola";
                MySqlDataAdapter daEscola = new MySqlDataAdapter(queryEscolas, conn);
                DataTable dtEscola = new DataTable();
                daEscola.Fill(dtEscola);

                comboBox5.DataSource = dtEscola;
                comboBox5.DisplayMember = "nome_fantasia";
                comboBox5.ValueMember = "id_escola";
                comboBox5.SelectedIndex = -1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem?.ToString() == "Fundamental")
            {
                comboBox2.Items.AddRange(new string[]
                {
                  "1º ano", "2º ano", "3º ano", "4º ano", "5º ano",
                  "6º ano", "7º ano", "8º ano", "9º ano"
                });
            }
            else if (comboBox1.SelectedItem?.ToString() == "Médio")
            {
                comboBox2.Items.AddRange(new string[]
                {
                  "1ª série", "2ª série", "3ª série"
                });
            }

            comboBox2.SelectedIndex = -1;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //ensino
        {
            string anoLetivoSelecionado = comboBox2.SelectedItem.ToString();


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) //serie
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idEscolaSelecionada = Convert.ToInt32(comboBox5.SelectedValue);

            string ensino = comboBox1.Text.Trim();
            string serie = comboBox2.Text.Trim();
            string sala = comboBox3.Text.Trim();
            string turno = comboBox4.Text.Trim();
            

            if (ensino == "" || serie == "" || sala == "" || turno == "")
            {
                MessageBox.Show("Campos obrigatórios: ensino, serie, sala e truno");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string query = "INSERT INTO turma (ensino, serie, sala, turno, id_escola) " +
                                   "VALUES (@ensino, @serie, @sala, @turno, @id_escola)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ensino", ensino);
                    cmd.Parameters.AddWithValue("@serie", serie);
                    cmd.Parameters.AddWithValue("@sala", sala);
                    cmd.Parameters.AddWithValue("@turno", turno);
                    cmd.Parameters.AddWithValue("@id_escola", idEscolaSelecionada);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Turma cadastrada!");


                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                    comboBox4.SelectedIndex = -1;
                    comboBox5.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar turma: " + ex.Message);
            }

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

