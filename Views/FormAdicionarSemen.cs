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
    public partial class FormAdicionarSemen : Form
    {
        public FormAdicionarSemen()
        {
            InitializeComponent();
            CarregarProprietarios(); // Carregar os proprietários no ComboBox
        }

        private void CarregarProprietarios()
        {
            try
            {
                using (SqlConnection conexao = DatabaseConnection.GetConnection())
                {
                    string strSQL = "SELECT ID_Proprietario, Nome FROM Proprietarios";
                    SqlDataAdapter adapter = new SqlDataAdapter(strSQL, conexao);
                    DataTable dtProprietarios = new DataTable();
                    adapter.Fill(dtProprietarios);

                    comboBoxProprietarios.DataSource = dtProprietarios;
                    comboBoxProprietarios.DisplayMember = "Nome";
                    comboBoxProprietarios.ValueMember = "ID_Proprietario";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar proprietários: " + ex.Message);
            }
        }

   
        private void btnSalvarSemen_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = DatabaseConnection.GetConnection())
                {
                    string strSQL = @"
                    INSERT INTO Semens (Nome, Quantidade, Data_Validade, ID_Proprietario)
                    VALUES (@Nome, @Quantidade, @Data_Validade, @ID_Proprietario)";

                    SqlCommand comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@Nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@Quantidade", txtQuantidade.Text);
                    comando.Parameters.AddWithValue("@Data_Validade", dtpDataValidade.Value);
                    comando.Parameters.AddWithValue("@ID_Proprietario", comboBoxProprietarios.SelectedValue);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Semen adicionado com sucesso!");

                    // Fecha o formulário após salvar
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar semen: " + ex.Message);
            }

        }
    }
}

