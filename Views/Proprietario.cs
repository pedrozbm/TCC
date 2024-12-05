using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TCC.Models;

namespace TCC.Views
{
    public partial class Proprietario : Form
    {
        public Proprietario()
        {
            InitializeComponent();
        }

        private void Proprietario_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (tccEntities tcc = new tccEntities())
            {
                var listProprietarios = tcc.Proprietarios
                    .Select(a => new
                    {
                        a.Nome,
                        a.Numero_Contato,  // Exemplo de outra coluna
                        a.Email     // Exemplo de outra coluna
                    })
                    .ToList();

                // Atualiza a DataGridView
                dataGridView1.DataSource = listProprietarios;
                dataGridView1.AutoGenerateColumns = true;
                // Força a atualização da DataGridView
            }

        }


        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionarProprietario_Click(object sender, EventArgs e)
        {
            using (tccEntities db = new tccEntities())
            {
                // Verifica se os campos não estão vazios
                if (string.IsNullOrEmpty(tbNome.Text) || string.IsNullOrEmpty(tbContato.Text) || string.IsNullOrEmpty(tbEmail.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }

                // Cria o novo proprietário com os dados do formulário
                var novoProprietario = new Proprietarios
                {
                    Nome = tbNome.Text,
                    Numero_Contato = tbContato.Text,
                    Email = tbEmail.Text
                };

                // Adiciona o novo proprietário à tabela
                db.Proprietarios.Add(novoProprietario);

                // Salva as alterações no banco de dados
                db.SaveChanges();

                // Exibe mensagem de sucesso
                MessageBox.Show("Proprietário adicionado com sucesso!");

                // Atualiza a DataGridView com os novos dados
                btnConsultar_Click(sender, e);

                // Opcional: Limpar os campos após o cadastro
                LimparCampos();
            }
        }


        private void LimparCampos()
        {
            tbNome.Clear();
            tbContato.Clear();
            tbEmail.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.Black; // Cor de fundo
            e.CellStyle.ForeColor = Color.LimeGreen; // Cor do texto
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
