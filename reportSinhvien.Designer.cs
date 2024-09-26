
namespace DangNhapSinhvien
{
    partial class reportSinhvien
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
            this.KY_TUC_XADataSet4 = new DangNhapSinhvien.KY_TUC_XADataSet4();
            this.sinh_vienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinh_vienTableAdapter = new DangNhapSinhvien.KY_TUC_XADataSet4TableAdapters.sinh_vienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinh_vienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sinh_vienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DangNhapSinhvien.ReportSinhvien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // KY_TUC_XADataSet4
            // 
            this.KY_TUC_XADataSet4.DataSetName = "KY_TUC_XADataSet4";
            this.KY_TUC_XADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinh_vienBindingSource
            // 
            this.sinh_vienBindingSource.DataMember = "sinh_vien";
            this.sinh_vienBindingSource.DataSource = this.KY_TUC_XADataSet4;
            // 
            // sinh_vienTableAdapter
            // 
            this.sinh_vienTableAdapter.ClearBeforeFill = true;
            // 
            // reportSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportSinhvien";
            this.Text = "reportSinhvien";
            this.Load += new System.EventHandler(this.reportSinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinh_vienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sinh_vienBindingSource;
        private KY_TUC_XADataSet4 KY_TUC_XADataSet4;
        private KY_TUC_XADataSet4TableAdapters.sinh_vienTableAdapter sinh_vienTableAdapter;
    }
}