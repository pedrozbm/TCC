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
    public partial class AdicionarAnimais : Form
    {
        public AdicionarAnimais()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas e barra de título

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (tccEntities db = new tccEntities())
            {
                using (db) ;
                var novoAnimal = new TCC.Models.Animais
                {
                    Nome = "pedro",
                    ID_Raca = (int?)cbRaca.SelectedValue, // Valor selecionado no ComboBox
                    ID_Genero = (int?)cbGenero.SelectedValue,
                    ID_Proprietario = (int?)cbProprietario.SelectedValue,
                    ID_Fazenda = (int?)cbFazenda.SelectedValue,
                    Data_Nascimento = dtpDataNascimento.Value
                };

                // Adiciona ao contexto
                db.Animais.Add(novoAnimal);

                // Salva no banco de dados
                db.SaveChanges();

                // Exibe mensagem de sucesso
                MessageBox.Show("Animal adicionado com sucesso!");

                // Opcional: Limpa os campos
                //LimparCampos();
            }
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
    }

    // Método para limpar os campos após salvar
    //private void LimparCampos()
    //{
    //    using (tccEntities db = new tccEntities()) ;

    //    txtNome.Clear();
    //    cbRaca.SelectedIndex = -1;
    //    cbGenero.SelectedIndex = -1;
    //    cbProprietario.SelectedIndex = -1;
    //    cbFazenda.SelectedIndex = -1;
    //    dtpDataNascimento.Value = DateTime.Now;
    //}

}

