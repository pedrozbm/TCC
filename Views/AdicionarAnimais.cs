using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Models;

namespace TCC.Views
{
    public partial class AdicionarAnimais : Form
    {
        private MenuInicial _menuInicial;
        private BluetoothHandler _bluetoothHandler;
        private int _ultimoAnimalId;
        private DateTime? _ultimaDataNascimento;
        public AdicionarAnimais(MenuInicial menuinicial)
        {
            InitializeComponent();
            _menuInicial = menuinicial;
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas e barra de título
            _bluetoothHandler = new BluetoothHandler();
            _bluetoothHandler.SetupBluetoothConnection("COM7");
            CarregarFazendas(); 
            CarregarProprietarios();
            CarregarGeneros();
            CarregarRacas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Usando o DbContext dentro do bloco using para garantir que seja descartado corretamente após o uso
            using (tccEntities db = new tccEntities())
            {
                // Cria um novo objeto Animal
                var novoAnimal = new TCC.Models.Animais
                {
                    Nome = tbNome.Text,
                    ID_Raca = (int?)cbRaca.SelectedValue, // Valor selecionado no ComboBox
                    ID_Genero = (int?)cbGenero.SelectedValue,
                    ID_Proprietario = (int?)comboBoxProprietario.SelectedValue,
                    ID_Fazenda = (int?)cbFazenda.SelectedValue,
                    Data_Nascimento = dtpDataNascimento.Value
                };
                _ultimoAnimalId = novoAnimal.ID_Animal;
                _ultimaDataNascimento = novoAnimal.Data_Nascimento;
                // Adiciona o novo animal ao contexto
                db.Animais.Add(novoAnimal);

                // Salva as mudanças no banco de dados
                db.SaveChanges();

                // Exibe mensagem de sucesso
                MessageBox.Show("Animal adicionado com sucesso!");

                // Opcional: Limpa os campos (descomentando a linha abaixo se necessário)
                LimparCampos();
            }
        }
        private void LimparCampos()
        {
            tbNome.Clear();
            cbFazenda.SelectedIndex = 0;
            cbGenero.SelectedIndex = 0;
            comboBoxProprietario.SelectedIndex = 0;
            cbRaca.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelProprietario_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void CarregarRacas()

        {
            using (tccEntities db = new tccEntities())
            {
                // Busca todas as raças no banco de dados
                var racas = db.Racas
                    .Select(r => new { r.ID_Raca, r.Nome_Raca })
                    .ToList();

                // Configura o ComboBox com os dados
                cbRaca.DataSource = racas;
                cbRaca.DisplayMember = "Nome_Raca"; // Nome que será exibido no ComboBox
                cbRaca.ValueMember = "ID_Raca";    // Valor associado a cada item
            }
        }
        private void CarregarFazendas()
        {
            using (tccEntities db = new tccEntities())
            {
                // Busca todas as raças no banco de dados
                var fazendas = db.Fazendas
                    .Select(f => new { f.ID_Fazenda, f.Nome_Fazenda })
                    .ToList();

                // Configura o ComboBox com os dados
                cbFazenda.DataSource = fazendas;
                cbFazenda.DisplayMember = "Nome_Fazenda"; // Nome que será exibido no ComboBox
                cbFazenda.ValueMember = "ID_Fazenda";    // Valor associado a cada item
            }
        }

        private void cbRaca_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (tccEntities tcc = new tccEntities())
                if (cbRaca.SelectedValue != null)
                {
                    // Obtém o ID da raça selecionada
                    int selectedRacaId = (int)cbRaca.SelectedValue;


                }
        }
        private void CarregarGeneros()
        {
            using (tccEntities db = new tccEntities())
            {
                // Busca os gêneros no banco de dados
                var generos = db.Generos
                    .Select(g => new { g.ID_Genero, g.Tipo_Genero })
                    .ToList();

                // Configura o ComboBox com os dados
                cbGenero.DataSource = generos;
                cbGenero.DisplayMember = "Tipo_Genero"; // Nome que será exibido no ComboBox
                cbGenero.ValueMember = "ID_Genero";    // Valor associado a cada item
            }
        }
        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbGenero.SelectedValue != null)
            {
                // Obtém o ID do gênero selecionado
                int selectedGeneroId = (int)cbGenero.SelectedValue;
            }
        }

        private void btnFazendas_Click(object sender, EventArgs e)
        {
            _menuInicial.abrirFormNoPainel(new Fazendas()); // Usa o método da instância passada
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
                comboBoxProprietario.DataSource = proprietario;
                comboBoxProprietario.DisplayMember = "Nome"; // Nome que será exibido no ComboBox
                comboBoxProprietario.ValueMember = "ID_Proprietario";    // Valor associado a cada item
            }
        }

        private void cbFazenda_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (tccEntities tcc = new tccEntities())
                if (cbFazenda.SelectedValue != null)
                {
                    // Obtém o ID da raça selecionada
                    int selectedFazendaID = (int)cbFazenda.SelectedValue;


                }
        }

        private void cbProprietario_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProprietário_Click(object sender, EventArgs e)
        {
            _menuInicial.abrirFormNoPainel(new Proprietario()); // Usa o método da instância passada
        }
        private SerialPort _serialPort = new SerialPort();

        private void btnBluetooth_Click(object sender, EventArgs e)
        {
             using (tccEntities db = new tccEntities())
            {
                // Cria um novo objeto Animal
                var novoAnimal = new TCC.Models.Animais
                {
                    Nome = tbNome.Text,
                    ID_Raca = (int?)cbRaca.SelectedValue, // Valor selecionado no ComboBox
                    ID_Genero = (int?)cbGenero.SelectedValue,
                    ID_Proprietario = (int?)comboBoxProprietario.SelectedValue,
                    ID_Fazenda = (int?)cbFazenda.SelectedValue,
                    Data_Nascimento = dtpDataNascimento.Value
                };
                _ultimoAnimalId = novoAnimal.ID_Animal;
                _ultimaDataNascimento = novoAnimal.Data_Nascimento;
                // Adiciona o novo animal ao contexto
                db.Animais.Add(novoAnimal);

                // Salva as mudanças no banco de dados
                db.SaveChanges();

                // Exibe mensagem de sucesso
                MessageBox.Show("Animal adicionado com sucesso!");

                // Opcional: Limpa os campos (descomentando a linha abaixo se necessário)
                LimparCampos();

                if (novoAnimal.ID_Animal != 0 && novoAnimal.Data_Nascimento != DateTime.MinValue)
                {
                    _bluetoothHandler.EnviarDadosPorBluetooth(novoAnimal.ID_Animal, novoAnimal.Data_Nascimento);
                }
                else
                {
                    MessageBox.Show("Nenhum dado disponível para envio. Adicione um animal primeiro.");
                }
            }
            
        }
    }
}
