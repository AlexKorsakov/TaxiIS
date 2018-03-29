namespace Kursovik_UD
{
    partial class Report_technic
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
            this.REPORT_technicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaxiDataSet = new Kursovik_UD.TaxiDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.REPORT_technicTableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.REPORT_technicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_technicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // REPORT_technicBindingSource
            // 
            this.REPORT_technicBindingSource.DataMember = "REPORT_technic";
            this.REPORT_technicBindingSource.DataSource = this.TaxiDataSet;
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
            reportDataSource1.Value = this.REPORT_technicBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kursovik_UD.Report_tehnic1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(904, 484);
            this.reportViewer1.TabIndex = 0;
            // 
            // REPORT_technicTableAdapter
            // 
            this.REPORT_technicTableAdapter.ClearBeforeFill = true;
            // 
            // Report_technic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 484);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_technic";
            this.Text = "Report_technic";
            this.Load += new System.EventHandler(this.Report_technic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_technicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource REPORT_technicBindingSource;
        private TaxiDataSet TaxiDataSet;
        private TaxiDataSetTableAdapters.REPORT_technicTableAdapter REPORT_technicTableAdapter;
    }
}