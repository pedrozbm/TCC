using System;
using System.IO.Ports;
using System.Windows.Forms;

public class BluetoothHandler
{
    private SerialPort _serialPort;

    public void SetupBluetoothConnection(string portName = "COM7", int baudRate = 9600)
    {
        _serialPort = new SerialPort
        {
            PortName = portName, 
            BaudRate = baudRate,
            Parity = Parity.None,
            DataBits = 8,
            StopBits = StopBits.One
        };

        try
        {
            _serialPort.Open();
            MessageBox.Show("Conexão Bluetooth estabelecida!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao conectar via Bluetooth: " + ex.Message);
        }
    }

    public void EnviarDadosPorBluetooth(int animalId, DateTime? dataNascimento)
    {
        if (_serialPort != null)
        {
            try
            {
                // Formatar os dados para envio
                string dados = $"ANIMAL;{animalId};{dataNascimento:yyyy-MM-dd}";
                _serialPort.WriteLine(dados);
                MessageBox.Show("Dados enviados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar dados: " + ex.Message);
            }
        }
        else
        {
            MessageBox.Show("Conexão Bluetooth não está aberta.");
        }
    }
    public void EnviarDadosPorBluetooth(string dados)
    {
        if (_serialPort != null)
        {
            try
            {
                _serialPort.WriteLine(dados);  // Envia os dados por Bluetooth
                MessageBox.Show("Dados enviados por Bluetooth com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar dados por Bluetooth: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Conexão Bluetooth não está aberta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



    public void CloseConnection()
    {
        if (_serialPort != null && _serialPort.IsOpen)
        {
            _serialPort.Close();
            MessageBox.Show("Conexão Bluetooth encerrada.");
        }
    }
}
