
using System.Data;
namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBAgenda.CriarDataBase();
            DBAgenda.CriarTabela();
            ExibirDados();
        }
        private void ExibirDados()
        {
            try
            {
                DataTable table = new DataTable();
                table = DBAgenda.GetContatos();
                dGDados.DataSource = table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(txtId.Text);
                contato.Nome = txtNome.Text;
                contato.Telefone = txtTelefone.Text;

                DBAgenda.InserirContato(contato);
                ExibirDados();

                txtId.Clear();
                txtNome.Clear();
                txtTelefone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(txtId.Text);
                contato.Nome = txtNome.Text;
                contato.Telefone = txtTelefone.Text;

                DBAgenda.AlterarContato(contato);
                ExibirDados();

                txtId.Clear();
                txtNome.Clear();
                txtTelefone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                int id = Convert.ToInt32(txtId.Text);

                table = DBAgenda.GetContatoById(id);
                dGDados.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);

                DBAgenda.ExcluirContato(id);
                ExibirDados();

                txtId.Clear();
                txtNome.Clear();
                txtTelefone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            // form2.ShowDialog();

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dGDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGDados_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            dGDados.CurrentRow.Selected = true;

            txtId.Text = dGDados.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();

            txtNome.Text = dGDados.Rows[e.RowIndex].Cells["Nome"].FormattedValue.ToString();

            txtTelefone.Text = dGDados.Rows[e.RowIndex].Cells["Telefone"].FormattedValue.ToString();

        }
    }
}
