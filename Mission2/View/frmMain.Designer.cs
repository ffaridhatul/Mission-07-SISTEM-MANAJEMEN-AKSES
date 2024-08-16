namespace Mission2.View
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAccessRecord = new System.Windows.Forms.DataGridView();
            this.tmrSaveAccessRecord = new System.Windows.Forms.Timer(this.components);
            this.tmrCheckPacketFile = new System.Windows.Forms.Timer(this.components);
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCardId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessRecord)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccessRecord
            // 
            this.dgvAccessRecord.AllowUserToAddRows = false;
            this.dgvAccessRecord.AllowUserToDeleteRows = false;
            this.dgvAccessRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccessRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvAccessRecord.Location = new System.Drawing.Point(15, 121);
            this.dgvAccessRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAccessRecord.MultiSelect = false;
            this.dgvAccessRecord.Name = "dgvAccessRecord";
            this.dgvAccessRecord.ReadOnly = true;
            this.dgvAccessRecord.RowHeadersWidth = 62;
            this.dgvAccessRecord.RowTemplate.Height = 23;
            this.dgvAccessRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccessRecord.Size = new System.Drawing.Size(872, 658);
            this.dgvAccessRecord.TabIndex = 0;
            // 
            // tmrSaveAccessRecord
            // 
            this.tmrSaveAccessRecord.Interval = 10000;
            this.tmrSaveAccessRecord.Tick += new System.EventHandler(this.tmrSaveAccessRecord_Tick);
            // 
            // tmrCheckPacketFile
            // 
            this.tmrCheckPacketFile.Interval = 500;
            this.tmrCheckPacketFile.Tick += new System.EventHandler(this.tmrCheckPacketFile_Tick);
            // 
            // dtFromDate
            // 
            this.dtFromDate.Location = new System.Drawing.Point(15, 41);
            this.dtFromDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(277, 26);
            this.dtFromDate.TabIndex = 1;
            // 
            // dtToDate
            // 
            this.dtToDate.Location = new System.Drawing.Point(316, 41);
            this.dtToDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(263, 26);
            this.dtToDate.TabIndex = 2;
            this.dtToDate.ValueChanged += new System.EventHandler(this.dtToDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "~";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtToDate);
            this.groupBox1.Controls.Add(this.dtFromDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(167, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(616, 95);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "inquiry period";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCardId);
            this.groupBox2.Location = new System.Drawing.Point(15, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(134, 95);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CardID";
            // 
            // txtCardId
            // 
            this.txtCardId.Location = new System.Drawing.Point(31, 38);
            this.txtCardId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardId.MaxLength = 6;
            this.txtCardId.Name = "txtCardId";
            this.txtCardId.Size = new System.Drawing.Size(76, 26);
            this.txtCardId.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(791, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 78);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "History search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RecordDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.FillWeight = 150F;
            this.Column4.HeaderText = "Catat tanggal dan waktu";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CardId";
            this.Column1.FillWeight = 90F;
            this.Column1.HeaderText = "CardID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GateId";
            this.Column2.FillWeight = 90F;
            this.Column2.HeaderText = "GateID";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "AccessType";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.FillWeight = 60F;
            this.Column3.HeaderText = "Bagian";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 803);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAccessRecord);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sistem kontrol akses";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccessRecord;
        private System.Windows.Forms.Timer tmrSaveAccessRecord;
        private System.Windows.Forms.Timer tmrCheckPacketFile;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCardId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}