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
    public partial class Form5 : Form
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

        public Form5()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(materiasComCarga.Keys.ToArray());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string materia = comboBox1.SelectedItem.ToString();

            if (materiasComCarga.ContainsKey(materia))
            {
                textBox1.Text = materiasComCarga[materia] + " horas por semana";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
