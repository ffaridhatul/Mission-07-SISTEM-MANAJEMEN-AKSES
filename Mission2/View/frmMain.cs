using Mission2.Business;
using Mission2.Model;
using System;
using System.Windows.Forms;

namespace Mission2.View
{
    public partial class frmMain : Form
    {
        private AccessControlBiz accessControlBiz;

        public frmMain()
        {
            InitializeComponent();
            accessControlBiz = new AccessControlBiz(new FileDataSource()); // Inisialisasi di constructor
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tmrCheckPacketFile.Start();
            tmrSaveAccessRecord.Start();
            RefreshGrid();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Berhenti dan bersihkan resource timer saat form ditutup
            tmrCheckPacketFile.Stop();
            tmrSaveAccessRecord.Stop();
        }

        private void RefreshGrid()
        {
            try
            {
                string cardId = txtCardId.Text;
                DateTime fromDate = Convert.ToDateTime(dtFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime toDate = Convert.ToDateTime(dtFromDate.Value.AddDays(1).ToString("yyyy-MM-dd"));

                if (string.IsNullOrEmpty(cardId))
                    dgvAccessRecord.DataSource = accessControlBiz.GetAccessRecord(fromDate, toDate);
                else
                    dgvAccessRecord.DataSource = accessControlBiz.GetAccessRecord(cardId, fromDate, toDate);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid date format: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing the grid: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmrSaveAccessRecord_Tick(object sender, EventArgs e)
        {
            try
            {
                accessControlBiz.SaveAccessRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving access records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmrCheckPacketFile_Tick(object sender, EventArgs e)
        {
            try
            {
                var packetList = GatePacket.ReadFromFile();

                foreach (var packet in packetList)
                {
                    var accessRecord = new AccessRecord
                    {
                        RecordDate = packet.GetRecordDate(),
                        CardId = packet.GetCardId(),
                        GateId = packet.GetGateId(),
                        AccessType = packet.GetAccessType()
                    };

                    accessControlBiz.AddAccessRecord(accessRecord);
                }

                if (packetList.Count > 0)
                    RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing packet files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
