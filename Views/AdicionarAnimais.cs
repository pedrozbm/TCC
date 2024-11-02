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
    public partial class AdicionarAnimais : Form
    {
        public AdicionarAnimais()
        {
            InitializeComponent();
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarAnimais_Load(object sender, EventArgs e)
        {
            using (SqlConnection conexao = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter adapter;

                // Generos
                adapter = new SqlDataAdapter("SELECT ID_Genero, Tipo_Genero FROM Generos", conexao);
                DataTable dtGeneros = new DataTable();
                adapter.Fill(dtGeneros);
                cbGenero.DataSource = dtGeneros;
                cbGenero.DisplayMember = "Tipo_Genero"; 
                cbGenero.ValueMember = "ID_Genero";

                // Raca
                adapter = new SqlDataAdapter("SELECT ID_Raca, Nome_Raca FROM Racas", conexao);
                DataTable dtRacas = new DataTable();
                adapter.Fill(dtRacas);
                cbRaca.DataSource = dtRacas;
                cbRaca.DisplayMember = "Nome_Raca";  
                cbRaca.ValueMember = "ID_Raca";

                // Proprietários
                adapter = new SqlDataAdapter("SELECT ID_Proprietario, Nome FROM Proprietarios", conexao);
                DataTable dtProprietarios = new DataTable();
                adapter.Fill(dtProprietarios);
                cbProprietario.DataSource = dtProprietarios;
                cbProprietario.DisplayMember = "Nome";        
                cbProprietario.ValueMember = "ID_Proprietario";


                //  Fazendas
                adapter = new SqlDataAdapter("SELECT ID_Fazenda, Nome_Fazenda FROM Fazendas", conexao);
                DataTable dtFazendas = new DataTable();
                adapter.Fill(dtFazendas);
                cbFazenda.DataSource = dtFazendas;
                cbFazenda.DisplayMember = "Nome_Fazenda";   
                cbFazenda.ValueMember = "ID_Fazenda";        
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se uma fazenda foi selecionada
                if (cbFazenda.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecione uma fazenda.");
                    return;
                }

                // Verificar se a data de nascimento foi digitada corretamente
                if (!DateTime.TryParse(tbNascimento.Text, out DateTime dataNascimento))
                {
                    MessageBox.Show("Por favor, digite uma data de nascimento válida (formato: dd/MM/yyyy).");
                    return;
                }

                using (SqlConnection conexao = DatabaseConnection.GetConnection())
                {
                    // Comando SQL para inserir os dados na tabela de Animais
                    string strSQL = @"
            INSERT INTO Animais (Nome, ID_Raca, ID_Genero, Data_Nascimento, ID_Proprietario, ID_Fazenda) 
            VALUES (@Nome, @ID_Raca, @ID_Genero, @Data_Nascimento, @ID_Proprietario, @ID_Fazenda)";

                    SqlCommand comando = new SqlCommand(strSQL, conexao);

                    // Parâmetros para o comando SQL
                    comando.Parameters.AddWithValue("@Nome", tbNome.Text); // Nome do Animal
                    comando.Parameters.AddWithValue("@ID_Raca", cbRaca.SelectedValue); // Raça selecionada
                    comando.Parameters.AddWithValue("@ID_Genero", cbGenero.SelectedValue); // Gênero selecionado
                    comando.Parameters.AddWithValue("@Data_Nascimento", dataNascimento); // Data de Nascimento
                    comando.Parameters.AddWithValue("@ID_Proprietario", cbProprietario.SelectedValue); // Proprietário selecionado
                    comando.Parameters.AddWithValue("@ID_Fazenda", cbFazenda.SelectedValue); // Fazenda selecionada

                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Animal adicionado com sucesso!");

                    this.Close(); // Fecha o formulário após salvar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar animal: " + ex.Message);
            }
        }

    }


}


