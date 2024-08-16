using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GateSimulator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string packet = "";

            if (rdoProtocolA.Checked && txtCardId.Text.Length != 4)
            {
                MessageBox.Show("ID Card Protokol A terdiri dari 4 karakter.");
                return;
            }
            else if (rdoProtocolB.Checked && txtCardId.Text.Length != 6)
            {
                MessageBox.Show("ID Protokol B terdiri dari 6 karakter.");
                return;
            }

            if (rdoProtocolA.Checked)
            {
                packet = $"A{numGateId.Value:00}{txtCardId.Text}{(rdoEnter.Checked ? "E" : "L")}{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }
            else
            {
                packet = $"B{numGateId.Value:00}{txtCardId.Text}{(rdoEnter.Checked ? "E" : "L")}{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }

            using (var writer = new StreamWriter(new FileStream("Packet.txt", FileMode.Append | FileMode.OpenOrCreate), Encoding.Default))
            {
                writer.WriteLine(packet);
            }
        }

        private void rdoProtocolA_CheckedChanged(object sender, EventArgs e)
        {
            txtCardId.Text = "ABCD";
        }

        private void rdoProtocolB_CheckedChanged(object sender, EventArgs e)
        {
            txtCardId.Text = "ABCDEF";
        }
    }
}
