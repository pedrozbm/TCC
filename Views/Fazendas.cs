using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TCC.Models;


namespace TCC
{
    public partial class Fazendas : Form
    {
        public Fazendas()
        {
            InitializeComponent();
            CarregarCidades();
            CarregarEstados();
            CarregarProprietarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (tccEntities tcc = new tccEntities())
            {
                // Primeiro, verifica se há fazendas
                int totalFazendas = tcc.Fazendas.Count();

                // Consulta detalhada com carregamento de entidades relacionadas
                var listFazendas = tcc.Fazendas
                    .Select(a => new
                    {
                        ID_Fazenda = a.ID_Fazenda,
                        Nome_Fazenda = a.Nome_Fazenda,
                        Endereco = a.Endereco,
                        Proprietario = a.Proprietarios.Nome,
                        NomeCidade = a.Cidades.Nome_Cidade ?? "Cidade não encontrada",
                        NomeEstado = a.Estados.Nome_Estado ?? "Estado não encontrado"
                    })
                    .ToList();

                // Verifica se a lista tem resultados
                if (listFazendas.Count == 0)
                {
                    MessageBox.Show("Nenhuma fazenda encontrada.");
                    return;
                }

                // Configuração do DataGridView
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = listFazendas;
                //dataGridView1.Columns["ID_Fazenda"].Visible = false;

            }
        }

        private void Fazendas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (tccEntities db = new tccEntities())
            {
                // Verifica se um estado foi realmente selecionado
                int? estadoSelecionado = cbEstado.SelectedValue as int?;
                Estados estado = null;

                if (estadoSelecionado.HasValue)
                {
                    // Busca o estado no banco de dados para garantir que existe
                    estado = db.Estados.FirstOrDefault(est => est.ID_Estado == estadoSelecionado.Value);
                }

                // Se estado não foi encontrado, trata o erro
                if (estado == null)
                {
                    MessageBox.Show("Por favor, selecione um estado válido.");
                    return;
                }

                // Primeiro, garanta que a cidade está cadastrada
                Cidades cidade = null;
                if (!string.IsNullOrWhiteSpace(cbCidade.Text))
                {
                    // Verifica se a cidade já existe (ignorando maiúsculas/minúsculas)
                    cidade = db.Cidades
                               .FirstOrDefault(c => c.Nome_Cidade.ToLower() == cbCidade.Text.ToLower());

                    // Se não existir, cria uma nova cidade
                    if (cidade == null)
                    {
                        cidade = new Cidades
                        {
                            Nome_Cidade = cbCidade.Text,
                            ID_Estado = estado.ID_Estado  // Adiciona o ID do estado à nova cidade
                        };
                        db.Cidades.Add(cidade);
                        db.SaveChanges();
                    }
                }
                int? idProprietarioSelecionado = comboBoxProprietario.SelectedValue as int?;
                if (idProprietarioSelecionado == null)
                {
                    MessageBox.Show("Por favor, selecione um proprietário válido.");
                    return;
                }

                // Cria a nova fazenda com os dados
                var novaFazenda = new TCC.Models.Fazendas
                {
                    Nome_Fazenda = txbNome.Text,
                    Endereco = txbEndereco.Text,
                    ID_Cidade = cidade?.ID_Cidade,
                    ID_Estado = estado.ID_Estado,
                    ID_Proprietario = idProprietarioSelecionado.Value // Associa o proprietário selecionado
                };

                // Verifica se todos os campos obrigatórios estão preenchidos
                if (string.IsNullOrWhiteSpace(novaFazenda.Nome_Fazenda) ||
                    string.IsNullOrWhiteSpace(novaFazenda.Endereco) ||
                    novaFazenda.ID_Cidade == null ||
                    novaFazenda.ID_Estado == null)
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                    return;
                }

                // Adiciona a nova fazenda ao contexto
                db.Fazendas.Add(novaFazenda);

                // Salva as alterações no banco de dados
                db.SaveChanges();

                // Exibe mensagem de sucesso
                MessageBox.Show("Fazenda adicionada com sucesso!");

                // Limpa os campos após adicionar
                LimparCampos();
            }
        }

        // Método para carregar estados com verificação adicional
        private void CarregarEstados()
        {
            using (tccEntities db = new tccEntities())
            {
                // Busca os estados no banco de dados
                var estados = db.Estados
                                .Select(e => new { e.ID_Estado, e.Nome_Estado })
                                .ToList();

                // Verifica se há estados
                if (estados.Count == 0)
                {
                    MessageBox.Show("Nenhum estado encontrado no banco de dados. Por favor, adicione estados primeiro.");
                    return;
                }

                // Configura o ComboBox com os estados
                cbEstado.DataSource = estados;
                cbEstado.DisplayMember = "Nome_Estado"; // Nome exibido no ComboBox
                cbEstado.ValueMember = "ID_Estado";    // Valor associado ao item

                // Seleciona o primeiro estado
                cbEstado.SelectedIndex = 0;
            }
        }
        private void LimparCampos()
        {
            txbNome.Clear();
            txbEndereco.Clear();
            cbCidade.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
        }
        public void CarregarProprietarios()
        {
            using (tccEntities db = new tccEntities())
            {
                // Busca os proprietários no banco de dados, eliminando duplicatas
                var proprietarios = db.Proprietarios
             .GroupBy(p => p.Nome) // Agrupa pelos nomes para evitar repetição
             .Select(g => g.FirstOrDefault()) // Seleciona apenas o primeiro de cada grupo
             .Select(c => new { c.ID_Proprietario, c.Nome })
             .ToList();

                // Configura o ComboBox com os proprietários
                comboBoxProprietario.DataSource = proprietarios;
                comboBoxProprietario.DisplayMember = "Nome"; // Nome exibido no ComboBox
                comboBoxProprietario.ValueMember = "ID_Proprietario"; // Valor associado ao item

                // Certifique-se de que o primeiro valor selecionado não seja nulo
                if (proprietarios.Count > 0)
                {
                    comboBoxProprietario.SelectedIndex = 0; // Seleciona o primeiro item
                }
            }
        }

        private void CarregarCidades()
        {
            using (tccEntities db = new tccEntities())
            {
                var cidades = db.Cidades
                                .Select(c => new { c.ID_Cidade, c.Nome_Cidade })
                                .ToList();

                // Configura o ComboBox com as cidades
                cbCidade.DataSource = cidades;
                cbCidade.DisplayMember = "Nome_Cidade"; // Nome exibido no ComboBox
                cbCidade.ValueMember = "ID_Cidade";    // Valor associado ao item

                if (cidades.Count > 0)
                {
                    cbCidade.SelectedIndex = 0;  // Seleciona o primeiro item
                }
            }
        }

        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbCidade.Text))
            {
                using (tccEntities db = new tccEntities())
                {
                    var cidadeExistente = db.Cidades
                                            .FirstOrDefault(c => c.Nome_Cidade.ToLower() == cbCidade.Text.ToLower());

                    if (cidadeExistente == null)
                    {
                        // Se a cidade não existe, cria uma nova
                        var novaCidade = new TCC.Models.Cidades
                        {
                            Nome_Cidade = cbCidade.Text
                        };

                        // Adiciona a nova cidade ao banco de dados
                        db.Cidades.Add(novaCidade);
                        db.SaveChanges();

                        // Recarrega as cidades para atualizar o ComboBox
                        CarregarCidades();

                        // Seleciona a nova cidade
                        cbCidade.SelectedValue = novaCidade.ID_Cidade;
                    }
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void AtualizarDataGrid()
        {
            using (tccEntities tcc = new tccEntities())
            {
                var listFazendas = tcc.Fazendas
                    .Select(a => new
                    {
                        ID_Fazenda = a.ID_Fazenda,
                        Nome_Fazenda = a.Nome_Fazenda,
                        Endereco = a.Endereco,
                        Proprietario = a.Proprietarios.Nome,
                        NomeCidade = a.Cidades.Nome_Cidade ?? "Cidade não encontrada",
                        NomeEstado = a.Estados.Nome_Estado ?? "Estado não encontrado"
                    })
                    .ToList();

                dataGridView1.DataSource = listFazendas;
                //dataGridView1.Columns["ID_Fazenda"].Visible = false; // Oculta a coluna de ID
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Obtenha o valor do ID da fazenda
                int idFazenda = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Fazenda"].Value);

                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este item?",
                                                    "Confirmação",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (tccEntities tcc = new tccEntities())
                    {
                        // Verificar se a fazenda está sendo usada como chave estrangeira em outras tabelas
                        var existeReferencia = tcc.Animais.Any(o => o.ID_Fazenda == idFazenda);  // Substitua "OutrasTabelas" pelo nome das suas tabelas de referência

                        if (existeReferencia)
                        {
                            MessageBox.Show("Não é possível excluir esta fazenda, pois ela está sendo usada em outras tabelas.");
                            return; // Impede a exclusão
                        }

                        // Se não houver referências, podemos proceder com a exclusão
                        var fazenda = tcc.Fazendas.FirstOrDefault(f => f.ID_Fazenda == idFazenda);
                        if (fazenda != null)
                        {
                            tcc.Fazendas.Remove(fazenda);
                            tcc.SaveChanges();
                            MessageBox.Show("Item excluído com sucesso!");

                            // Recarregar o DataGridView
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

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProprietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se o usuário digitou algo no ComboBox
            if (!string.IsNullOrWhiteSpace(comboBoxProprietario.Text))
            {
                using (tccEntities db = new tccEntities())
                {
                    // Verifica se a cidade já existe (ignorando maiúsculas/minúsculas)
                    var proprietarioExistente = db.Proprietarios
                                            .FirstOrDefault(c => c.Nome.ToLower() == comboBoxProprietario.Text.ToLower());

                    if (proprietarioExistente == null)
                    {
                        // Se a cidade não existe, cria uma nova
                        var novoProprietario = new TCC.Models.Proprietarios
                        {
                            Nome = comboBoxProprietario.Text
                        };

                        // Adiciona a nova cidade ao banco de dados
                        db.Proprietarios.Add(novoProprietario);
                        db.SaveChanges();

                        // Recarrega as cidades para atualizar o ComboBox
                        CarregarProprietarios();

                        // Seleciona a nova cidade
                        comboBoxProprietario.SelectedValue = novoProprietario.ID_Proprietario;
                    }
                }
            }
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
