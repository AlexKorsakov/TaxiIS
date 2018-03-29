namespace Kursovik_UD
{
    partial class Report_drv_profit
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
            this.REPORT_DRIVER_PROFITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaxiDataSet = new Kursovik_UD.TaxiDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.REPORT_DRIVER_PROFITTableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.REPORT_DRIVER_PROFITTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_DRIVER_PROFITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // REPORT_DRIVER_PROFITBindingSource
            // 
            this.REPORT_DRIVER_PROFITBindingSource.DataMember = "REPORT_DRIVER_PROFIT";
            this.REPORT_DRIVER_PROFITBindingSource.DataSource = this.TaxiDataSet;
            // 
            // TaxiDataSet
            // 
            this.TaxiDataSet.DataSetName = "TaxiDataSet";
            this.TaxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REPORT_DRIVER_PROFITBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kursovik_UD.Report_drv_prof1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1039, 520);
            this.reportViewer1.TabIndex = 0;
            // 
            // REPORT_DRIVER_PROFITTableAdapter
            // 
            this.REPORT_DRIVER_PROFITTableAdapter.ClearBeforeFill = true;
            // 
            // Report_drv_profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 520);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_drv_profit";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Report_drv_profit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_DRIVER_PROFITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource REPORT_DRIVER_PROFITBindingSource;
        private TaxiDataSet TaxiDataSet;
        private TaxiDataSetTableAdapters.REPORT_DRIVER_PROFITTableAdapter REPORT_DRIVER_PROFITTableAdapter;
    }
}