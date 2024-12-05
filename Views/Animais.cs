using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TCC.Models;
using TCC.Views;

namespace TCC
{
    public partial class Animais : Form
    {
        public Animais()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tccEntities tcc = new tccEntities();

            // Seleção dos animais e inclusão do nome do proprietário e raça
            var listAnimais = tcc.Animais
                .Select(a => new
                {
                    ID_Animal = a.ID_Animal,
                    NomeAnimal = a.Nome, // Renomeado para NomeAnimal
                    NomeProprietario = a.Proprietarios.Nome, // Renomeado para NomeProprietario
                    NomeRaca = a.Racas.Nome_Raca // Renomeado para NomeRaca
                })
                .ToList();

            // Definindo a fonte de dados do DataGridView
            dataGridView1.DataSource = listAnimais;
        }
        private void AtualizarDataGrid()
        {
            using (tccEntities tcc = new tccEntities())
            {
                // Carrega os dados mais recentes do banco de dados
                var listAnimais = tcc.Animais
                 .Select(a => new
                 {
                     ID_Animal = a.ID_Animal,
                     NomeAnimal = a.Nome, // Renomeado para NomeAnimal
                     NomeProprietario = a.Proprietarios.Nome, // Renomeado para NomeProprietario
                     NomeRaca = a.Racas.Nome_Raca // Renomeado para NomeRaca
                 })
                 .ToList();

                // Atualiza o DataGridView com os dados
                dataGridView1.DataSource = listAnimais;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Animais_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MenuInicial menuInicial = Application.OpenForms.OfType<MenuInicial>().FirstOrDefault();

            // Verifica se MenuInicial foi encontrado antes de continuar
            if (menuInicial != null)
            {
                // Passa a instância de MenuInicial ao criar AdicionarAnimais
                menuInicial.abrirFormNoPainel(new AdicionarAnimais(menuInicial));
            }
            else
            {
                MessageBox.Show("Erro: MenuInicial não está aberto.");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Obtenha o valor do ID da fazenda
                int idAnimal = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Animal"].Value);

                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este item?",
                                                    "Confirmação",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (tccEntities tcc = new tccEntities())
                    {
                        // Verificar se a fazenda está sendo usada como chave estrangeira em outras tabelas
                        var existeReferencia = tcc.Inseminacoes.Any(o => o.ID_Animal == idAnimal);  // Substitua "OutrasTabelas" pelo nome das suas tabelas de referência

                        if (existeReferencia)
                        {
                            MessageBox.Show("Não é possível excluir esta fazenda, pois ela está sendo usada em outras tabelas.");
                            return; // Impede a exclusão
                        }

                        // Se não houver referências, podemos proceder com a exclusão
                        var animais = tcc.Animais.FirstOrDefault(a => a.ID_Animal == idAnimal);
                        if (animais != null)
                        {
                            tcc.Animais.Remove(animais);
                            tcc.SaveChanges();
                            MessageBox.Show("Item excluído com sucesso!");
                            AtualizarDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("Item não encontrado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um item para excluir.");
                }
            }
        }
    }
}
