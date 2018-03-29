namespace Kursovik_UD
{
    partial class Report_medic
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TaxiDataSet = new Kursovik_UD.TaxiDataSet();
            this.REPORT_medicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.REPORT_medicTableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.REPORT_medicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TaxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_medicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REPORT_medicBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kursovik_UD.Report_MEDIC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(899, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // TaxiDataSet
            // 
            this.TaxiDataSet.DataSetName = "TaxiDataSet";
            this.TaxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // REPORT_medicBindingSource
            // 
            this.REPORT_medicBindingSource.DataMember = "REPORT_medic";
            this.REPORT_medicBindingSource.DataSource = this.TaxiDataSet;
            // 
            // REPORT_medicTableAdapter
            // 
            this.REPORT_medicTableAdapter.ClearBeforeFill = true;
            // 
            // Report_medic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 453);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_medic";
            this.Text = "Report_medic";
            this.Load += new System.EventHandler(this.Report_medic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_medicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource REPORT_medicBindingSource;
        private TaxiDataSet TaxiDataSet;
        private TaxiDataSetTableAdapters.REPORT_medicTableAdapter REPORT_medicTableAdapter;
    }
}