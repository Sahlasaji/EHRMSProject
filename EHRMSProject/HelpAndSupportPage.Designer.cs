namespace EHRMSProject
{
    partial class HelpAndSupportPage
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
            this.lblHelpAndSupportPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelpAndSupportPage
            // 
            this.lblHelpAndSupportPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHelpAndSupportPage.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpAndSupportPage.Location = new System.Drawing.Point(0, 0);
            this.lblHelpAndSupportPage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHelpAndSupportPage.Name = "lblHelpAndSupportPage";
            this.lblHelpAndSupportPage.Size = new System.Drawing.Size(1333, 77);
            this.lblHelpAndSupportPage.TabIndex = 1;
            this.lblHelpAndSupportPage.Text = "Help And Support Page";
            this.lblHelpAndSupportPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HelpAndSupportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 652);
            this.Controls.Add(this.lblHelpAndSupportPage);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "HelpAndSupportPage";
            this.Text = "HelpAndSupportPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HelpAndSupportPage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHelpAndSupportPage;
    }
}