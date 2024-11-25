using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TCC.Views;


namespace TCC
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.panelContanedor.GetType()
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(this.panelContanedor, true, null);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();
        [DllImport("user32.dll", EntryPoint ="SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam);



        private void MenuInicial_Load(object sender, EventArgs e)
        {

        }
        public void abrirFormNoPainel(Object formhijo)
        {
            if (this.panelContanedor.Controls.Count > 0)
                this.panelContanedor.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContanedor.Controls.Add(fh);
            this.panelContanedor.Tag = fh;
            fh.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContanedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFazendas_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new Fazendas());
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new Animais());

        }

        private void btnSêmens_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new Semens());
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new TelaComunicacao());

        }
    }
}
