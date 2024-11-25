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
    public partial class Semens : Form
    {
        public Semens()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (tccEntities db = new tccEntities())
            {
                // Criar objeto Semens
                using (db) ;
               var novoSemen = new TCC.Models.Semens
                {
                    Nome = txtNome.Text,
                    Quantidade = (int?)numQuantidade.Value,
                    Data_Validade = dtpValidade.Value,
                    ID_Proprietario = (int?)cbProprietario.SelectedValue // Obtem o ID do proprietário
                };

                // Adicionar ao contexto
                db.Semens.Add(novoSemen);

                // Salvar no banco de dados
                db.SaveChanges();

                // Feedback ao usuário
                MessageBox.Show("Sêmen adicionado com sucesso!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
