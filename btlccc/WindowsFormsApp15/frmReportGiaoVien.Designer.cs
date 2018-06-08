namespace WindowsFormsApp15
{
    partial class frmReportGiaoVien
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
            this.dsGiaoVien = new WindowsFormsApp15.dsGiaoVien();
            this.CanBoGiaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CanBoGiaoVienTableAdapter = new WindowsFormsApp15.dsGiaoVienTableAdapters.CanBoGiaoVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CanBoGiaoVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsGiaoVien";
            reportDataSource1.Value = this.CanBoGiaoVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp15.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(763, 340);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsGiaoVien
            // 
            this.dsGiaoVien.DataSetName = "dsGiaoVien";
            this.dsGiaoVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CanBoGiaoVienBindingSource
            // 
            this.CanBoGiaoVienBindingSource.DataMember = "CanBoGiaoVien";
            this.CanBoGiaoVienBindingSource.DataSource = this.dsGiaoVien;
            // 
            // CanBoGiaoVienTableAdapter
            // 
            this.CanBoGiaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 340);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportGiaoVien";
            this.Text = "frmReportGiaoVien";
            this.Load += new System.EventHandler(this.frmReportGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CanBoGiaoVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CanBoGiaoVienBindingSource;
        private dsGiaoVien dsGiaoVien;
        private dsGiaoVienTableAdapters.CanBoGiaoVienTableAdapter CanBoGiaoVienTableAdapter;
    }
}