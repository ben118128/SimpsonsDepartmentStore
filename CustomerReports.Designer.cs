namespace SimpsonsDepartmentStore
{
    partial class CustomerReports
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
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautyAndCosmeticsDataSet1 = new SimpsonsDepartmentStore.BeautyAndCosmeticsDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.beautyAndCosmeticsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new SimpsonsDepartmentStore.BeautyAndCosmeticsDataSet1TableAdapters.CustomerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyAndCosmeticsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyAndCosmeticsDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.beautyAndCosmeticsDataSet1;
            // 
            // beautyAndCosmeticsDataSet1
            // 
            this.beautyAndCosmeticsDataSet1.DataSetName = "BeautyAndCosmeticsDataSet1";
            this.beautyAndCosmeticsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.reportViewer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            reportDataSource1.Name = "AllCustomers";
            reportDataSource1.Value = this.customerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SimpsonsDepartmentStore.AllCustomers.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 331);
            this.reportViewer1.TabIndex = 0;
            // 
            // beautyAndCosmeticsDataSet1BindingSource
            // 
            this.beautyAndCosmeticsDataSet1BindingSource.DataSource = this.beautyAndCosmeticsDataSet1;
            this.beautyAndCosmeticsDataSet1BindingSource.Position = 0;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CustomerReports";
            this.Text = "CustomerReports";
            this.Load += new System.EventHandler(this.CustomerReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyAndCosmeticsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyAndCosmeticsDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource beautyAndCosmeticsDataSet1BindingSource;
        private BeautyAndCosmeticsDataSet1 beautyAndCosmeticsDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BeautyAndCosmeticsDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}