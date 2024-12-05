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

            // Remove as bordas do formulário (caso esteja utilizando bordas personalizadas)
            this.FormBorderStyle = FormBorderStyle.Sizable;  // Permite redimensionamento e exibe os botões de minimizar/maximizar


            // Criar o botão de maximizar
            Button btnMaximizar = new Button
            {
                Text = "[ ]", // Texto que representará o botão de maximizar
                Size = new Size(30, 30), // Definindo tamanho do botão
                Location = new Point(this.ClientSize.Width - 60, 5) // Definindo a posição do botão
            };
            btnMaximizar.Click += (sender, e) =>
            {
                this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            };
            this.Controls.Add(btnMaximizar);

            // Criar o botão de fechar
            Button btnFechar = new Button
            {
                Text = "X", // Texto do botão de fechar
                Size = new Size(30, 30),
                Location = new Point(this.ClientSize.Width - 30, 5)
            };
            btnFechar.Click += (sender, e) => { this.Close(); };
            this.Controls.Add(btnFechar);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static IntPtr SendMessage(IntPtr hwnd, uint wmsg, uint wparam, uint lparam);

        // Maximizar a janela
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MAXIMIZE = 0xF030;

        private void MaximizarJanela()
        {
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
        }

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
            abrirFormNoPainel(new Animais()); // Passa o MenuInicial

        }

        private void btnSêmens_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new Semens());
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new TelaComunicacao());

        }

        private void btnProprietários_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new Proprietario());

        }

        private void btnProtocolos_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new Protocolos());
        }
    }
}
