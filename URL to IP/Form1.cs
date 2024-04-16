using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URL_to_IP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var url = URL_INPUT.Text;
            
            try
            {
                Uri myUri = new Uri(url);
                var ip = Dns.GetHostAddresses(myUri.Host)[0];
                TXT_IP.Text = ip.ToString();
            }
            catch (Exception)
            {
                TXT_IP.Text = "NOT FOUND";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TXT_IP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
