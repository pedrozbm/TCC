using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void atualizalistaCOMs()
        {
            int i;
            bool quantDiferente = false;
            i = 0;

            if(comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                  foreach(string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false) {

                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            if( quantDiferente == false) {
                return;
            }
            comboBox1.Items.Clear();

            foreach(string s in SerialPort.GetPortNames() )
            {
                comboBox1.Items.Add(s);
            }
            comboBox1.SelectedItem = 0;
        }


    }
}
