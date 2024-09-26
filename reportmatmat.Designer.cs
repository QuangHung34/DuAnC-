
namespace DangNhapSinhvien
{
    partial class reportmatmat
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
            this.KY_TUC_XADataSet7 = new DangNhapSinhvien.KY_TUC_XADataSet7();
            this.mat_matBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mat_matTableAdapter = new DangNhapSinhvien.KY_TUC_XADataSet7TableAdapters.mat_matTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mat_matBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mat_matBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DangNhapSinhvien.Reportmatmat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // KY_TUC_XADataSet7
            // 
            this.KY_TUC_XADataSet7.DataSetName = "KY_TUC_XADataSet7";
            this.KY_TUC_XADataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mat_matBindingSource
            // 
            this.mat_matBindingSource.DataMember = "mat_mat";
            this.mat_matBindingSource.DataSource = this.KY_TUC_XADataSet7;
            // 
            // mat_matTableAdapter
            // 
            this.mat_matTableAdapter.ClearBeforeFill = true;
            // 
            // reportmatmat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportmatmat";
            this.Text = "reportmatmat";
            this.Load += new System.EventHandler(this.reportmatmat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KY_TUC_XADataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mat_matBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mat_matBindingSource;
        private KY_TUC_XADataSet7 KY_TUC_XADataSet7;
        private KY_TUC_XADataSet7TableAdapters.mat_matTableAdapter mat_matTableAdapter;
    }
}