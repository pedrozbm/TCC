using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TCC.Views;

namespace TCC
{
    public partial class Animais : Form
    {
        public Animais()
        {
            InitializeComponent();
        }
        private void CarregarAnimais()
{
    using (SqlConnection conexao = DatabaseConnection.GetConnection())
    {
        string strSQL = @"
        SELECT 
            A.Nome AS Animal, 
            R.Nome_Raca AS Raça, 
            G.Tipo_Genero AS Sexo, 
            P.Nome AS Proprietario, 
            F.Nome_Fazenda AS Fazenda
        FROM 
            Animais A
        JOIN 
            Racas R ON A.ID_Raca = R.ID_Raca
        JOIN 
            Generos G ON A.ID_Genero = G.ID_Genero
        JOIN 
            Proprietarios P ON A.ID_Proprietario = P.ID_Proprietario
        JOIN 
            Fazendas F ON P.ID_Fazenda = F.ID_Fazenda";

        SqlDataAdapter adapter = new SqlDataAdapter(strSQL, conexao);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);

        dgvAnimais.DataSource = dataTable;
    }
}


        private void btnConsultaAnimais_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = DatabaseConnection.GetConnection())
                {
                    string strSQL = @"
                SELECT 
                     A.ID_Animal,
                    A.Nome AS Animal, 
                    R.Nome_Raca AS Raça, 
                    G.Tipo_Genero AS Sexo, 
                    P.Nome AS Proprietario, 
                    F.Nome_Fazenda as Fazenda
                FROM 
                    Animais A
                JOIN 
                    Racas R ON A.ID_Raca = R.ID_Raca
                JOIN 
                    Generos G ON A.ID_Genero = G.ID_Genero
                JOIN 
                    Proprietarios P ON A.ID_Proprietario = P.ID_Proprietario
                JOIN 
                    Fazendas F ON P.ID_Fazenda = F.ID_Fazenda";

                    if (cbFazendas.SelectedValue != DBNull.Value)
                    {
                        strSQL += " WHERE F.ID_Fazenda = @ID_Fazenda";
                    }

                    SqlCommand comando = new SqlCommand(strSQL, conexao);

                    if (cbFazendas.SelectedValue != DBNull.Value)
                    {
                        comando.Parameters.AddWithValue("@ID_Fazenda", cbFazendas.SelectedValue);
                    }

                    conexao.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvAnimais.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdicionarAnimal_Click(object sender, EventArgs e)
        {
            // Instanciar o formulário de adição de animal
            AdicionarAnimais formAdicionarAnimal = new AdicionarAnimais();

            // Exibir o formulário como uma janela modal
            formAdicionarAnimal.ShowDialog();

          
            
        }

        private void btnAlterarAnimal_Click(object sender, EventArgs e)
        {
            if (dgvAnimais.SelectedRows.Count > 0)
            {
                int idAnimal = Convert.ToInt32(dgvAnimais.SelectedRows[0].Cells["ID_Animal"].Value);
                AdicionarAnimais formAlterarAnimal = new AdicionarAnimais(idAnimal);
                formAlterarAnimal.ShowDialog();

                CarregarAnimais(); // Atualiza a lista de animais após a edição
            }
            else
            {
                MessageBox.Show("Por favor, selecione um animal para alterar.");
            }
        }

        private void dgvAnimais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluirAnimal_Click(object sender, EventArgs e)
        {
            // Verifica se alguma linha foi selecionada na DataGridView
            if (dgvAnimais.SelectedRows.Count > 0)
            {
                // Obtém o ID do animal selecionado na DataGridView
                int idAnimal = Convert.ToInt32(dgvAnimais.SelectedRows[0].Cells["ID_Animal"].Value);

                // Confirmação para o usuário
                DialogResult dialogResult = MessageBox.Show("Tem certeza de que deseja excluir este animal?", "Excluir Animal", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    // Chama o método para excluir o animal do banco de dados
                    ExcluirAnimal(idAnimal);

                    // Atualiza a lista de animais após a exclusão
                    CarregarAnimais();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um animal para excluir.");
            }
        }

        private void ExcluirAnimal(int idAnimal)
        {
            try
            {
                using (SqlConnection conexao = DatabaseConnection.GetConnection())
                {
                    // Consulta SQL para excluir o animal pelo ID
                    string strSQL = "DELETE FROM Animais WHERE ID_Animal = @ID_Animal";

                    SqlCommand comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@ID_Animal", idAnimal);

                    conexao.Open();
                    comando.ExecuteNonQuery();  // Executa a exclusão

                    MessageBox.Show("Animal excluído com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir animal: " + ex.Message);
            }
        }
    }
    }


