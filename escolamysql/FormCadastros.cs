namespace escolamysql
{
    public partial class FormCadastros : Form
    {
        public FormCadastros()
        {
            InitializeComponent();
        }

        FormEscola escola = new FormEscola();
        private void eSCOLAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            escola.ShowDialog();
        }

        FormTurma turma = new FormTurma();
        private void tURMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turma.ShowDialog();
        }

        FormAluno aluno = new FormAluno();
        private void aLUNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aluno.ShowDialog();
        }

        FormMateria materia = new FormMateria();
        private void mATERIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materia.ShowDialog();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
