namespace SimpsonsDepartmentStore
{
    partial class BookingsReports
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
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautyAndCosmeticsDataSet = new SimpsonsDepartmentStore.BeautyAndCosmeticsDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bookingTableAdapter = new SimpsonsDepartmentStore.BeautyAndCosmeticsDataSetTableAdapters.BookingTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyAndCosmeticsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.beautyAndCosmeticsDataSet;
            // 
            // beautyAndCosmeticsDataSet
            // 
            this.beautyAndCosmeticsDataSet.DataSetName = "BeautyAndCosmeticsDataSet";
            this.beautyAndCosmeticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.reportViewer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            reportDataSource1.Name = "All_Bookings";
            reportDataSource1.Value = this.bookingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SimpsonsDepartmentStore.AllBookings.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 329);
            this.reportViewer1.TabIndex = 0;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reports menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookingsReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BookingsReports";
            this.Text = "BookingsReports";
            this.Load += new System.EventHandler(this.BookingsReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyAndCosmeticsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BeautyAndCosmeticsDataSet beautyAndCosmeticsDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private BeautyAndCosmeticsDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}