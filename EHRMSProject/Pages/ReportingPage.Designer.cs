namespace EHRMSProject
{
    partial class ReportingPage
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
            this.lblReportingPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReportingPage
            // 
            this.lblReportingPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReportingPage.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportingPage.Location = new System.Drawing.Point(0, 0);
            this.lblReportingPage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReportingPage.Name = "lblReportingPage";
            this.lblReportingPage.Size = new System.Drawing.Size(1333, 77);
            this.lblReportingPage.TabIndex = 1;
            this.lblReportingPage.Text = "Reporting Page";
            this.lblReportingPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReportingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 652);
            this.Controls.Add(this.lblReportingPage);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ReportingPage";
            this.Text = "ReportingPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportingPage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReportingPage;
    }
}