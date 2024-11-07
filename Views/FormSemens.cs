using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Views
{
    public partial class FormSemens : Form
    {
        public FormSemens()
        {
            InitializeComponent();
            CarregarSemens(); // Carrega os semens ao inicializar
        }
        private void ExcluirSemen()
        {
            try
            {
                // Verifica se algum semen foi selecionado na DataGridView
                if (dgvSemens.SelectedRows.Count > 0)
                {
                    // Obtém o ID do semen da linha selecionada
                    int idSemen = Convert.ToInt32(dgvSemens.SelectedRows[0].Cells["ID_Semen"].Value);

                    // Confirmação para excluir
                    DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este semen?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Comando SQL para excluir o semen
                        using (SqlConnection conexao = DatabaseConnection.GetConnection())
                        {
                            string strSQL = "DELETE FROM Semens WHERE ID_Semen = @ID_Semen";

                            SqlCommand comando = new SqlCommand(strSQL, conexao);
                            comando.Parameters.AddWithValue("@ID_Semen", idSemen);

                            conexao.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Semen excluído com sucesso!");

                            // Atualiza a lista de semens
                            CarregarSemens();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um semen para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir semen: " + ex.Message);
            }
        }

        private void CarregarSemens()
        {
            try
            {
                // Carregar os semens na DataGridView (atualize conforme necessário)
                using (SqlConnection conexao = DatabaseConnection.GetConnection())
                {
                    string strSQL = "SELECT ID_Semen, Nome, Quantidade, Data_Validade, ID_Proprietario FROM Semens";
                    SqlDataAdapter adapter = new SqlDataAdapter(strSQL, conexao);
                    DataTable dtSemens = new DataTable();
                    adapter.Fill(dtSemens);

                    dgvSemens.DataSource = dtSemens;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar semens: " + ex.Message);
            }
        }


        private void btnAdicionarSemen_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do FormAdicionarSemen
            FormAdicionarSemen formAdicionarSemen = new FormAdicionarSemen();

            // Exibe o FormAdicionarSemen para o usuário adicionar os dados
            formAdicionarSemen.ShowDialog();

            // Após o fechamento do FormAdicionarSemen, recarrega os semens para refletir a nova adição
            CarregarSemens();
        }

        

        private void btnExcluirSemen_Click(object sender, EventArgs e)
        {
                try
                {
                    // Verifica se algum semen foi selecionado na DataGridView
                    if (dgvSemens.SelectedRows.Count > 0)
                    {
                        // Obtém o ID do semen da linha selecionada
                        int idSemen = Convert.ToInt32(dgvSemens.SelectedRows[0].Cells["ID_Semen"].Value);

                        // Confirmação para excluir
                        DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este semen?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            // Comando SQL para excluir o semen
                            using (SqlConnection conexao = DatabaseConnection.GetConnection())
                            {
                                string strSQL = "DELETE FROM Semens WHERE ID_Semen = @ID_Semen";

                                SqlCommand comando = new SqlCommand(strSQL, conexao);
                                comando.Parameters.AddWithValue("@ID_Semen", idSemen);

                                conexao.Open();
                                comando.ExecuteNonQuery();
                                MessageBox.Show("Semen excluído com sucesso!");

                                // Atualiza a lista de semens
                                CarregarSemens();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecione um semen para excluir.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir semen: " + ex.Message);
                }
            }

        }
    }

    
