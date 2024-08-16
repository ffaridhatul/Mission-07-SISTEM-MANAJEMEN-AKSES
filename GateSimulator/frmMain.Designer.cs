namespace GateSimulator
{
    partial class frmMain
    {
        /// <summary>
        /// Ini adalah variabel desainer yang diperlukan.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Bersihkan semua resource yang digunakan.
        /// </summary>
        /// <param name="disposing">jika resource harus dihapus maka true, jika tidak maka false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Kode yang dibuat oleh desainer

        /// <summary>
        /// Metode ini diperlukan untuk dukungan desainer. 
        /// Jangan ubah konten metode ini dengan editor kode.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCardId = new System.Windows.Forms.TextBox();
            this.rdoLeave = new System.Windows.Forms.RadioButton();
            this.rdoEnter = new System.Windows.Forms.RadioButton();
            this.numGateId = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoProtocolB = new System.Windows.Forms.RadioButton();
            this.rdoProtocolA = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGateId)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCardId);
            this.groupBox1.Controls.Add(this.rdoLeave);
            this.groupBox1.Controls.Add(this.rdoEnter);
            this.groupBox1.Controls.Add(this.numGateId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(196, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gate signal";
            // 
            // txtCardId
            // 
            this.txtCardId.Location = new System.Drawing.Point(63, 22);
            this.txtCardId.MaxLength = 6;
            this.txtCardId.Name = "txtCardId";
            this.txtCardId.Size = new System.Drawing.Size(67, 21);
            this.txtCardId.TabIndex = 6;
            this.txtCardId.Text = "ABCD";
            // 
            // rdoLeave
            // 
            this.rdoLeave.AutoSize = true;
            this.rdoLeave.Location = new System.Drawing.Point(342, 24);
            this.rdoLeave.Name = "rdoLeave";
            this.rdoLeave.Size = new System.Drawing.Size(47, 16);
            this.rdoLeave.TabIndex = 5;
            this.rdoLeave.Text = "keluar";
            this.rdoLeave.UseVisualStyleBackColor = true;
            // 
            // rdoEnter
            // 
            this.rdoEnter.AutoSize = true;
            this.rdoEnter.Checked = true;
            this.rdoEnter.Location = new System.Drawing.Point(272, 24);
            this.rdoEnter.Name = "rdoEnter";
            this.rdoEnter.Size = new System.Drawing.Size(59, 16);
            this.rdoEnter.TabIndex = 4;
            this.rdoEnter.TabStop = true;
            this.rdoEnter.Text = "Masuk";
            this.rdoEnter.UseVisualStyleBackColor = true;
            // 
            // numGateId
            // 
            this.numGateId.Location = new System.Drawing.Point(192, 22);
            this.numGateId.Name = "numGateId";
            this.numGateId.Size = new System.Drawing.Size(64, 21);
            this.numGateId.TabIndex = 3;
            this.numGateId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "게이트ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "GateID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoProtocolB);
            this.groupBox2.Controls.Add(this.rdoProtocolA);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "protokol peralatan";
            // 
            // rdoProtocolB
            // 
            this.rdoProtocolB.AutoSize = true;
            this.rdoProtocolB.Location = new System.Drawing.Point(94, 21);
            this.rdoProtocolB.Name = "rdoProtocolB";
            this.rdoProtocolB.Size = new System.Drawing.Size(77, 16);
            this.rdoProtocolB.TabIndex = 7;
            this.rdoProtocolB.Text = "ProtocalB";
            this.rdoProtocolB.UseVisualStyleBackColor = true;
            this.rdoProtocolB.CheckedChanged += new System.EventHandler(this.rdoProtocolB_CheckedChanged);
            // 
            // rdoProtocolA
            // 
            this.rdoProtocolA.AutoSize = true;
            this.rdoProtocolA.Checked = true;
            this.rdoProtocolA.Location = new System.Drawing.Point(15, 21);
            this.rdoProtocolA.Name = "rdoProtocolA";
            this.rdoProtocolA.Size = new System.Drawing.Size(77, 16);
            this.rdoProtocolA.TabIndex = 6;
            this.rdoProtocolA.TabStop = true;
            this.rdoProtocolA.Text = "ProtocalA";
            this.rdoProtocolA.UseVisualStyleBackColor = true;
            this.rdoProtocolA.CheckedChanged += new System.EventHandler(this.rdoProtocolA_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(608, 21);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 46);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "transmisi paket";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 80);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gate simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGateId)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoLeave;
        private System.Windows.Forms.RadioButton rdoEnter;
        private System.Windows.Forms.NumericUpDown numGateId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoProtocolB;
        private System.Windows.Forms.RadioButton rdoProtocolA;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtCardId;
    }
}

