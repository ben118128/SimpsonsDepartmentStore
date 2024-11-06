namespace SimpsonsDepartmentStore
{
    partial class StaffReports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.beautyAndCosmeticsDataSet1 = new SimpsonsDepartmentStore.BeautyAndCosmeticsDataSet1();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new SimpsonsDepartmentStore.BeautyAndCosmeticsDataSet1TableAdapters.StaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.beautyAndCosmeticsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reports menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.reportViewer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            reportDataSource1.Name = "AllStaffDataSet";
            reportDataSource1.Value = this.staffBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SimpsonsDepartmentStore.AllStaff.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 314);
            this.reportViewer1.TabIndex = 3;
            // 
            // beautyAndCosmeticsDataSet1
            // 
            this.beautyAndCosmeticsDataSet1.DataSetName = "BeautyAndCosmeticsDataSet1";
            this.beautyAndCosmeticsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.beautyAndCosmeticsDataSet1;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // StaffReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Name = "StaffReports";
            this.Text = "TreatmentsReports";
            this.Load += new System.EventHandler(this.TreatmentsReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautyAndCosmeticsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BeautyAndCosmeticsDataSet1 beautyAndCosmeticsDataSet1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private BeautyAndCosmeticsDataSet1TableAdapters.StaffTableAdapter staffTableAdapter;
    }
}