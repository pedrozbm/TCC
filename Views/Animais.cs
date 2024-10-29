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

namespace TCC
{
    public partial class Animais : Form
    {
        public Animais()
        {
            InitializeComponent();
        }
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        private void btnConsultaAnimais_Click(object sender, EventArgs e)
        {
            try
            {
                // Conexão com o banco de dados
                conexao = new SqlConnection(@"Server = DESKTOP-VQFPMN5; Database = tcc; User Id = .; Integrated Security=true;");

                // Consulta SQL com filtro para a fazenda
                string strSQL = @"
            SELECT 
                A.Nome AS Nome_Animal, 
                R.Nome_Raca, 
                G.Tipo_Genero AS Tipo_Genero, 
                P.Nome AS Nome_Proprietario, 
                F.Nome_Fazenda 
            FROM 
                Animais A
            JOIN 
                Racas R ON A.ID_Raca = R.ID_Raca
            JOIN 
                Generos G ON A.ID_Genero = G.ID_Genero
            JOIN 
                Proprietarios P ON A.ID_Proprietario = P.ID_Proprietario
            JOIN 
                Fazendas F ON P.ID_Fazenda = F.ID_Fazenda
            WHERE 
                F.ID_Fazenda = @ID_Fazenda;
        ";

                // Criar o comando e adicionar o parâmetro
                SqlCommand comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID_Fazenda", cbFazendas.SelectedValue); // Utiliza o valor selecionado no ComboBox

                // Abrir conexão e preencher o DataTable
                conexao.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Configurar o DataGridView
                dgvAnimais.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        }
        }
       
