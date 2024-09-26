
namespace DangNhapSinhvien
{
    partial class reportthoigianvangmat
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
            this.KY_TUC_XADataSet2 = new DangNhapSinhvien.KY_TUC_XADataSet2();
            this.thoigian_vangmatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoigian_vangmatTableAdapter = new DangNhapSinhvien.KY_TUC_XADataSet2TableAdapters.thoigian_vangmatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoigian_vangmatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.thoigian_vangmatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DangNhapSinhvien.Reportthoigianvangmat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // KY_TUC_XADataSet2
            // 
            this.KY_TUC_XADataSet2.DataSetName = "KY_TUC_XADataSet2";
            this.KY_TUC_XADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thoigian_vangmatBindingSource
            // 
            this.thoigian_vangmatBindingSource.DataMember = "thoigian_vangmat";
            this.thoigian_vangmatBindingSource.DataSource = this.KY_TUC_XADataSet2;
            // 
            // thoigian_vangmatTableAdapter
            // 
            this.thoigian_vangmatTableAdapter.ClearBeforeFill = true;
            // 
            // reportthoigianvangmat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportthoigianvangmat";
            this.Text = "reportthoigianvangmat";
            this.Load += new System.EventHandler(this.reportthoigianvangmat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoigian_vangmatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource thoigian_vangmatBindingSource;
        private KY_TUC_XADataSet2 KY_TUC_XADataSet2;
        private KY_TUC_XADataSet2TableAdapters.thoigian_vangmatTableAdapter thoigian_vangmatTableAdapter;
    }
}