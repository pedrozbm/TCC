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
    public partial class FormGerenciarFazendas : Form
    {
        private void CarregarFazendas()
        {
            try
            {
                using (SqlConnection conexao = DatabaseConnection.GetConnection())
                {
                    string strSQL = @"
                SELECT 
                    F.ID_Fazenda, 
                    F.Nome_Fazenda, 
                    F.Endereco, 
                    C.Nome_Cidade, 
                    E.Nome_Estado
                FROM 
                    Fazendas F
                JOIN 
                    Cidades C ON F.ID_Cidade = C.ID_Cidade
                JOIN 
                    Estados E ON F.ID_Estado = E.ID_Estado";

                    SqlDataAdapter adapter = new SqlDataAdapter(strSQL, conexao);
                    DataTable dtFazendas = new DataTable();
                    adapter.Fill(dtFazendas);

                    // Adicione log para verificar o número de registros retornados
                    if (dtFazendas.Rows.Count > 0)
                    {
                        dgvFazendas.DataSource = dtFazendas;
                    }
                    else
                    {
                        MessageBox.Show("Não há fazendas para exibir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFazendas.SelectedRows.Count > 0)
            {
                int idFazenda = Convert.ToInt32(dgvFazendas.SelectedRows[0].Cells["ID_Fazenda"].Value);

                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir esta fazenda?", "Excluir Fazenda", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    ExcluirFazenda(idFazenda);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma fazenda para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ExcluirFazenda(int idFazenda)
        {
            try
            {
                using (SqlConnection conexao = DatabaseConnection.GetConnection())
                {
                    string strSQL = "DELETE FROM Fazendas WHERE ID_Fazenda = @ID_Fazenda";
                    SqlCommand comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@ID_Fazenda", idFazenda);

                    conexao.Open();
                    int rowsAffected = comando.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Fazenda excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarFazendas(); // Atualiza a DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir a fazenda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a fazenda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormGerenciarFazendas()
        {
            InitializeComponent();
        }

        private void FormGerenciarFazendas_Load(object sender, EventArgs e)
        {
            CarregarFazendas();
        }
    }
}
