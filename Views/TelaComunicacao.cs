using System;
using System.IO.Ports;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCC
{
    public partial class TelaComunicacao : Form
    {
        private SerialPort serialPort;

        public TelaComunicacao()
        {
            serialPort = new SerialPort();
            serialPort.PortName = "COM7"; // Ajuste para a porta onde o ESP32 está conectado
            serialPort.BaudRate = 9600;
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();
            InitializeComponent();
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Lê os dados recebidos da porta serial
                string data = serialPort.ReadLine(); // Certifique-se que o ESP32 envia um '\n'

                // Atualiza o TextBox na thread principal
                Invoke(new Action(() => {
                    textBox1.Text = data; // Atualiza o conteúdo do TextBox
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao receber dados: {ex.Message}");
            }
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
       
            string datatx = sendDataTextBox.Text;

            serialPort.Write(datatx);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = "COM7";
                    serialPort.Open();
                    MessageBox.Show("Conectado ao ESP32!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        private void receivedDataTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
