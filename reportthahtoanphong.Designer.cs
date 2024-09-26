
namespace DangNhapSinhvien
{
    partial class reportthahtoanphong
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
            this.kY_TUC_XADataSet = new DangNhapSinhvien.KY_TUC_XADataSet();
            this.kYTUCXADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KY_TUC_XADataSet6 = new DangNhapSinhvien.KY_TUC_XADataSet6();
            this.Hoadon_thanhtoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Hoadon_thanhtoanTableAdapter = new DangNhapSinhvien.KY_TUC_XADataSet6TableAdapters.Hoadon_thanhtoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kY_TUC_XADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kYTUCXADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hoadon_thanhtoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Hoadon_thanhtoanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DangNhapSinhvien.reportthanhtoanphong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // kY_TUC_XADataSet
            // 
            this.kY_TUC_XADataSet.DataSetName = "KY_TUC_XADataSet";
            this.kY_TUC_XADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kYTUCXADataSetBindingSource
            // 
            this.kYTUCXADataSetBindingSource.DataSource = this.kY_TUC_XADataSet;
            this.kYTUCXADataSetBindingSource.Position = 0;
            // 
            // KY_TUC_XADataSet6
            // 
            this.KY_TUC_XADataSet6.DataSetName = "KY_TUC_XADataSet6";
            this.KY_TUC_XADataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Hoadon_thanhtoanBindingSource
            // 
            this.Hoadon_thanhtoanBindingSource.DataMember = "Hoadon_thanhtoan";
            this.Hoadon_thanhtoanBindingSource.DataSource = this.KY_TUC_XADataSet6;
            // 
            // Hoadon_thanhtoanTableAdapter
            // 
            this.Hoadon_thanhtoanTableAdapter.ClearBeforeFill = true;
            // 
            // reportthahtoanphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportthahtoanphong";
            this.Text = "reportthahtoanphong";
            this.Load += new System.EventHandler(this.reportthahtoanphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kY_TUC_XADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kYTUCXADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hoadon_thanhtoanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource kYTUCXADataSetBindingSource;
        private KY_TUC_XADataSet kY_TUC_XADataSet;
        private System.Windows.Forms.BindingSource Hoadon_thanhtoanBindingSource;
        private KY_TUC_XADataSet6 KY_TUC_XADataSet6;
        private KY_TUC_XADataSet6TableAdapters.Hoadon_thanhtoanTableAdapter Hoadon_thanhtoanTableAdapter;
    }
}