
namespace DangNhapSinhvien
{
    partial class reportlichsuchuyenphong
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
            this.KY_TUC_XADataSet8 = new DangNhapSinhvien.KY_TUC_XADataSet8();
            this.lichsu_chuyenphongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lichsu_chuyenphongTableAdapter = new DangNhapSinhvien.KY_TUC_XADataSet8TableAdapters.lichsu_chuyenphongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichsu_chuyenphongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lichsu_chuyenphongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DangNhapSinhvien.Reportlichsuchuyenphong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // KY_TUC_XADataSet8
            // 
            this.KY_TUC_XADataSet8.DataSetName = "KY_TUC_XADataSet8";
            this.KY_TUC_XADataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lichsu_chuyenphongBindingSource
            // 
            this.lichsu_chuyenphongBindingSource.DataMember = "lichsu_chuyenphong";
            this.lichsu_chuyenphongBindingSource.DataSource = this.KY_TUC_XADataSet8;
            // 
            // lichsu_chuyenphongTableAdapter
            // 
            this.lichsu_chuyenphongTableAdapter.ClearBeforeFill = true;
            // 
            // reportlichsuchuyenphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportlichsuchuyenphong";
            this.Text = "reportlichsuchuyenphong";
            this.Load += new System.EventHandler(this.reportlichsuchuyenphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichsu_chuyenphongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lichsu_chuyenphongBindingSource;
        private KY_TUC_XADataSet8 KY_TUC_XADataSet8;
        private KY_TUC_XADataSet8TableAdapters.lichsu_chuyenphongTableAdapter lichsu_chuyenphongTableAdapter;
    }
}