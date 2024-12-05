using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TCC.Models;

namespace TCC.Views
{
    public partial class Semens : Form
    {
        public Semens()
        {
            InitializeComponent();
            CarregarProprietarios();
            CarregarTouros();
        }
        private void cbNomeTouro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeTouro = cbNomeTouro.Text.Trim();
            int quantidade = (int?)numQuantidade.Value ?? 0;
            int? idProprietario = (int?)cbProprietario.SelectedValue;

            // Verifica se o nome do touro e o proprietário foram fornecidos
            if (string.IsNullOrWhiteSpace(nomeTouro) || !idProprietario.HasValue)
            {
                MessageBox.Show("Nome do touro e proprietário são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (tccEntities db = new tccEntities())
            {
                // Verifica se o sêmen com o mesmo nome e proprietário já existe
                var semenExistente = db.Semens
                    .FirstOrDefault(s => s.Nome.ToLower() == nomeTouro.ToLower() && s.ID_Proprietario == idProprietario);

                if (semenExistente != null)
                {
                    // Se o sêmen já existe com o mesmo nome e proprietário, atualiza a quantidade
                    semenExistente.Quantidade += quantidade;

                    // Atualiza o banco de dados
                    db.SaveChanges();

                    // Feedback ao usuário
                    MessageBox.Show("Quantidade de sêmen atualizada com sucesso!");
                }
                else
                {
                    // Se o sêmen não existe, cria um novo registro
                    var novoSemen = new TCC.Models.Semens
                    {
                        Nome = nomeTouro,
                        Quantidade = quantidade,
                        Data_Validade = dtpValidade.Value,
                        ID_Proprietario = idProprietario.Value // Obtem o ID do proprietário
                    };

                    // Adiciona o novo sêmen ao banco de dados
                    db.Semens.Add(novoSemen);

                    // Salva no banco de dados
                    db.SaveChanges();

                    // Feedback ao usuário
                    MessageBox.Show("Sêmen adicionado com sucesso!");
                }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void CarregarProprietarios()
        {
            using (tccEntities db = new tccEntities())
            {
                // Busca todas as raças no banco de dados
                var proprietario = db.Proprietarios
                    .Select(p => new { p.ID_Proprietario, p.Nome })
                    .ToList();

                // Configura o ComboBox com os dados
                cbProprietario.DataSource = proprietario;
                cbProprietario.DisplayMember = "Nome"; // Nome que será exibido no ComboBox
                cbProprietario.ValueMember = "ID_Proprietario";    // Valor associado a cada item
            }
        }
        private void cbProprietario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnConsultarSemen_Click(object sender, EventArgs e)
        {
            using (tccEntities tcc = new tccEntities())
            {
                // Primeiro, verifica se há fazendas
                int totalSemens = tcc.Semens.Count();

                // Consulta detalhada com carregamento de entidades relacionadas
                var listSemens = tcc.Semens
                    .Select(a => new
                    {
                        Nome_touro = a.Nome,
                        Proprietario = a.Proprietarios.Nome,
                        Quantidade = a.Quantidade,
                        data_aquisicao = a.Data_Validade
                    })
                    .ToList();

                // Verifica se a lista tem resultados
                if (listSemens.Count == 0)
                {
                    MessageBox.Show("Nenhuma fazenda encontrada.");
                    return;
                }

                // Configuração do DataGridView
                dataGridView1.DataSource = listSemens;
                dataGridView1.AutoGenerateColumns = true;
                //dataGridView1.Columns["ID_Fazenda"].Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpValidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void CarregarTouros()
        {

            using (tccEntities db = new tccEntities())
            {
                //// Busca todas as raças no banco de dados
                //var Touros = db.Semens
                //    .Select(p => new { p.ID_Semen, p.Nome })
                //    .ToList();

                var touros = db.Semens
             .GroupBy(p => p.Nome) // Agrupa pelos nomes para evitar repetição
             .Select(g => g.FirstOrDefault()) // Seleciona apenas o primeiro de cada grupo
             .Select(c => new { c.ID_Semen, c.Nome })
             .ToList();

                // Configura o ComboBox com os dados
                cbNomeTouro.DataSource = touros;
                cbNomeTouro.DisplayMember = "Nome"; // Nome que será exibido no ComboBox
                cbNomeTouro.ValueMember = "Nome";    // Valor associado a cada item
            }

        }

        


    }
}
