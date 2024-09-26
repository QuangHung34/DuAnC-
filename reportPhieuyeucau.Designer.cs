
namespace DangNhapSinhvien
{
    partial class reportPhieuyeucau
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
            this.KY_TUC_XADataSet1 = new DangNhapSinhvien.KY_TUC_XADataSet1();
            this.phieu_yeucauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieu_yeucauTableAdapter = new DangNhapSinhvien.KY_TUC_XADataSet1TableAdapters.phieu_yeucauTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieu_yeucauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.phieu_yeucauBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DangNhapSinhvien.reportPhieuyeucau.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // KY_TUC_XADataSet1
            // 
            this.KY_TUC_XADataSet1.DataSetName = "KY_TUC_XADataSet1";
            this.KY_TUC_XADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieu_yeucauBindingSource
            // 
            this.phieu_yeucauBindingSource.DataMember = "phieu_yeucau";
            this.phieu_yeucauBindingSource.DataSource = this.KY_TUC_XADataSet1;
            // 
            // phieu_yeucauTableAdapter
            // 
            this.phieu_yeucauTableAdapter.ClearBeforeFill = true;
            // 
            // reportPhieuyeucau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportPhieuyeucau";
            this.Text = "reportPhieuyeucau";
            this.Load += new System.EventHandler(this.reportPhieuyeucau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieu_yeucauBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource phieu_yeucauBindingSource;
        private KY_TUC_XADataSet1 KY_TUC_XADataSet1;
        private KY_TUC_XADataSet1TableAdapters.phieu_yeucauTableAdapter phieu_yeucauTableAdapter;
    }
}