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

        private void btnConsultaAnimais_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = DatabaseConnection.GetConnection())
                {
                    string strSQL = @"
                SELECT 
                    
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
    }
}

