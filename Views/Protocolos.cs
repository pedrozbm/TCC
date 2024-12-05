using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Models;

namespace TCC.Views
{
   
    public partial class Protocolos : Form
    {
        private BluetoothHandler _bluetoothHandler;

        public Protocolos()
        {
            InitializeComponent();
            carregarIDAnimal();
            carregarSemen();
            _bluetoothHandler = new BluetoothHandler();
            _bluetoothHandler.SetupBluetoothConnection("COM7");
        }

        private void Protocolos_Load(object sender, EventArgs e)
        {

        }
        private void carregarIDAnimal()
        {
            using (tccEntities db = new tccEntities())
            {
                // Busca todas as raças no banco de dados
                var Animal = db.Animais
                    .Select(p => new { p.ID_Animal })
                    .ToList();

                // Configura o ComboBox com os dados
                cbIDAnimal.DataSource = Animal;
                cbIDAnimal.DisplayMember = "ID_Animal"; // Nome que será exibido no ComboBox
                cbIDAnimal.ValueMember = "ID_Animal";    // Valor associado a cada item
            }
        }
        private void carregarSemen()
        {
            using (tccEntities db = new tccEntities())
            {
                // Busca todas as raças no banco de dados
                var Animal = db.Semens
                    .Select(p => new { p.ID_Semen, p.Nome })
                    .ToList();

                // Configura o ComboBox com os dados
                cbSemen.DataSource = Animal;
                cbSemen.DisplayMember = "Nome"; // Nome que será exibido no ComboBox
                cbSemen.ValueMember = "ID_Semen";    // Valor associado a cada item
            }
        }

        private void dtpInseminacao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultarInseminacoes_Click(object sender, EventArgs e)
        {
            tccEntities tcc = new tccEntities();

            // Seleção dos animais e inclusão do nome do proprietário e raça
            var listInseminacoes = tcc.Inseminacoes
                .Select(a => new
                {
                    idInseminacao = a.ID_Inseminacao,
                    idAnimal = a.ID_Animal,
                    NomeAnimal = a.Animais.Nome, // Renomeado para NomeAnimal
                    dataInseminacao = a.Data_Inseminacao,
                    nomeProprietario = a.Animais.Proprietarios.Nome    // Renomeado para NomeProprietario
                })
                .ToList();

            // Definindo a fonte de dados do DataGridView
            dataGridView1.DataSource = listInseminacoes;
        }
    

        private void cbIDAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbIDAnimal.SelectedValue != null)
            {
                using (tccEntities db = new tccEntities())
                {
                    // Obtém o ID do animal selecionado
                    int idAnimalSelecionado = (int)cbIDAnimal.SelectedValue;

                    // Busca o nome do animal correspondente ao ID
                    var nomeAnimal = db.Animais
                                       .Where(a => a.ID_Animal == idAnimalSelecionado)
                                       .Select(a => a.Nome)  // Supondo que o nome do animal está na propriedade 'Nome'
                                       .FirstOrDefault();
                    var proprietario = db.Animais
                 .Where(a => a.ID_Animal == idAnimalSelecionado)
                 .Select(a => a.Proprietarios.Nome) // Obtém o nome do proprietário
                 .FirstOrDefault();

                    // Exibe o nome do proprietário no TextBox
                    tbInseminacao.Text = proprietario ?? "Proprietário não encontrado";

                    // Atualiza o TextBox com o nome do animal
                    tbInseminacao.Text = nomeAnimal ?? "Nome não encontrado";
                    textBox1.Text = proprietario;// Caso não encontre, exibe "Nome não encontrado"
                }
            }
        }
        private void tbInseminacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica se a tecla pressionada é Enter
            {
                using (tccEntities db = new tccEntities())
                {
                    // Obtém o nome digitado no TextBox
                    string nomeAnimal = tbInseminacao.Text.Trim();

                    // Consulta o ID do animal pelo nome
                    var animal = db.Animais
                        .Where(a => a.Nome == nomeAnimal)
                        .Select(a => new { a.ID_Animal })
                        .FirstOrDefault();

                    if (animal != null)
                    {
                        // Preenche o ComboBox com o ID do animal encontrado
                        cbIDAnimal.SelectedValue = animal.ID_Animal;
                    }
                    else
                    {
                        // Exibe mensagem se o animal não for encontrado
                        MessageBox.Show("Animal não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                e.Handled = true; // Impede o processamento adicional do evento
            }
        }

        private void btnInseminacao_Click(object sender, EventArgs e)
        {
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInseminacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBT_Click(object sender, EventArgs e)
        {
            using (tccEntities db = new tccEntities())
            {
                try
                {
                    // Obtém o ID do sêmen selecionado (touro)
                    int idSemenSelecionado = (int)cbSemen.SelectedValue;

                    // Verifica o sêmen (touro) no banco
                    var semen = db.Semens.FirstOrDefault(s => s.ID_Semen == idSemenSelecionado);

                    if (semen == null)
                    {
                        MessageBox.Show("Sêmen não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (semen.Quantidade <= 0)
                    {
                        MessageBox.Show("O estoque do sêmen selecionado está esgotado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Criar objeto Inseminacoes
                    var novaInseminacao = new TCC.Models.Inseminacoes
                    {
                        ID_Semen = idSemenSelecionado,
                        ID_Animal = (int)cbIDAnimal.SelectedValue,
                        Data_Inseminacao = dtpInseminacao.Value,
                    };

                    // Adicionar ao contexto
                    db.Inseminacoes.Add(novaInseminacao);

                    // Decrementar a quantidade do sêmen
                    semen.Quantidade--;

                    // Salvar no banco de dados
                    db.SaveChanges();

                    // Feedback ao usuário
                    MessageBox.Show("Inseminação adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Enviar os dados de inseminação via Bluetooth
                    if (novaInseminacao.ID_Semen != 0 && novaInseminacao.Data_Inseminacao != DateTime.MinValue)
                    {
                        // Aqui você prepara os dados a serem enviados via Bluetooth
                        string nomeTouro = semen.Nome;  // Nome do touro (sêmen)
                        string dadosParaEnviar = $"PROTOCOLO;{nomeTouro};{novaInseminacao.Data_Inseminacao:yyyy-MM-dd}";

                        // Enviar os dados por Bluetooth
                        _bluetoothHandler.EnviarDadosPorBluetooth(dadosParaEnviar);
                    }
                    else
                    {
                        MessageBox.Show("Nenhum dado disponível para envio. Verifique a inseminação.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar inseminação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (tccEntities db = new tccEntities())
            {
                try
                {
                    // Obtém o ID do sêmen selecionado
                    int idSemenSelecionado = (int)cbSemen.SelectedValue;

                    // Verifica a quantidade do sêmen no banco
                    var semen = db.Semens.FirstOrDefault(s => s.ID_Semen == idSemenSelecionado);

                    if (semen == null)
                    {
                        MessageBox.Show("Sêmen não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (semen.Quantidade <= 0)
                    {
                        MessageBox.Show("O estoque do sêmen selecionado está esgotado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Criar objeto Inseminacoes
                    var novaInseminacao = new TCC.Models.Inseminacoes
                    {
                        ID_Semen = idSemenSelecionado,
                        ID_Animal = (int)cbIDAnimal.SelectedValue,
                        Data_Inseminacao = dtpInseminacao.Value,
                    };

                    // Adicionar ao contexto
                    db.Inseminacoes.Add(novaInseminacao);

                    // Decrementar a quantidade do sêmen
                    semen.Quantidade--;

                    // Salvar no banco de dados
                    db.SaveChanges();

                    // Feedback ao usuário
                    MessageBox.Show("Inseminação adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar inseminação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
