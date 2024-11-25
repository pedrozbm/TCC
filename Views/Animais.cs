using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var listAnimais = tcc.Animais.ToList();
            dataGridView1.DataSource = listAnimais;


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
            menuInicial.abrirFormNoPainel(new AdicionarAnimais());

        }
    }
}
