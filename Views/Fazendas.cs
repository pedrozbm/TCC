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

namespace TCC
{
    public partial class Fazendas : Form
    {
        public Fazendas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                using (db) ;
                // Cria um novo objeto Fazendas
                var novaFazenda = new TCC.Models.Fazendas
                {
                    Nome_Fazenda = txbNome.Text,
                    Endereco = txbEndereco.Text,
                    ID_Cidade = (int?)cbCidade.SelectedValue, // Valor selecionado no ComboBox
                    ID_Estado = (int?)cbEstado.SelectedValue
                };

                // Adiciona a nova fazenda ao contexto
                db.Fazendas.Add(novaFazenda);

                // Salva as alterações no banco de dados
                db.SaveChanges();

                // Exibe mensagem de sucesso
                MessageBox.Show("Fazenda adicionada com sucesso!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
