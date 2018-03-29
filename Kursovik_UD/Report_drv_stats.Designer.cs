namespace Kursovik_UD
{
    partial class Report_drv_stats
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
            this.REPORT_DRIVER_STATSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaxiDataSet = new Kursovik_UD.TaxiDataSet();
            this.REPORT_DRIVERS_ZAYAVKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.REPORT_DRIVERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.REPORT_DRIVERSTableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.REPORT_DRIVERSTableAdapter();
            this.REPORT_DRIVERS_ZAYAVKITableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.REPORT_DRIVERS_ZAYAVKITableAdapter();
            this.REPORT_DRIVER_STATSTableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.REPORT_DRIVER_STATSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_DRIVER_STATSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_DRIVERS_ZAYAVKIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_DRIVERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // REPORT_DRIVER_STATSBindingSource
            // 
            this.REPORT_DRIVER_STATSBindingSource.DataMember = "REPORT_DRIVER_STATS";
            this.REPORT_DRIVER_STATSBindingSource.DataSource = this.TaxiDataSet;
            // 
            // TaxiDataSet
            // 
            this.TaxiDataSet.DataSetName = "TaxiDataSet";
            this.TaxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // REPORT_DRIVERS_ZAYAVKIBindingSource
            // 
            this.REPORT_DRIVERS_ZAYAVKIBindingSource.DataMember = "REPORT_DRIVERS_ZAYAVKI";
            this.REPORT_DRIVERS_ZAYAVKIBindingSource.DataSource = this.TaxiDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REPORT_DRIVER_STATSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kursovik_UD.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1020, 526);
            this.reportViewer1.TabIndex = 0;
            // 
            // REPORT_DRIVERSBindingSource
            // 
            this.REPORT_DRIVERSBindingSource.DataMember = "REPORT_DRIVERS";
            this.REPORT_DRIVERSBindingSource.DataSource = this.TaxiDataSet;
            // 
            // REPORT_DRIVERSTableAdapter
            // 
            this.REPORT_DRIVERSTableAdapter.ClearBeforeFill = true;
            // 
            // REPORT_DRIVERS_ZAYAVKITableAdapter
            // 
            this.REPORT_DRIVERS_ZAYAVKITableAdapter.ClearBeforeFill = true;
            // 
            // REPORT_DRIVER_STATSTableAdapter
            // 
            this.REPORT_DRIVER_STATSTableAdapter.ClearBeforeFill = true;
            // 
            // Report_drv_stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 526);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_drv_stats";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_DRIVER_STATSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_DRIVERS_ZAYAVKIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_DRIVERSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource REPORT_DRIVERSBindingSource;
        private TaxiDataSet TaxiDataSet;
        private TaxiDataSetTableAdapters.REPORT_DRIVERSTableAdapter REPORT_DRIVERSTableAdapter;
        private System.Windows.Forms.BindingSource REPORT_DRIVERS_ZAYAVKIBindingSource;
        private TaxiDataSetTableAdapters.REPORT_DRIVERS_ZAYAVKITableAdapter REPORT_DRIVERS_ZAYAVKITableAdapter;
        private System.Windows.Forms.BindingSource REPORT_DRIVER_STATSBindingSource;
        private TaxiDataSetTableAdapters.REPORT_DRIVER_STATSTableAdapter REPORT_DRIVER_STATSTableAdapter;
    }
}