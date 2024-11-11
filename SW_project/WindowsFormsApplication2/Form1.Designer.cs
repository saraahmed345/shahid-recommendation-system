
namespace shahid
{
    partial class Form1
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.content_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateReport_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.watch_list_transfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // content_cmb
            // 
            this.content_cmb.FormattingEnabled = true;
            this.content_cmb.Location = new System.Drawing.Point(41, 103);
            this.content_cmb.Name = "content_cmb";
            this.content_cmb.Size = new System.Drawing.Size(121, 21);
            this.content_cmb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONTENT TYPE";
            // 
            // GenerateReport_btn
            // 
            this.GenerateReport_btn.Location = new System.Drawing.Point(60, 130);
            this.GenerateReport_btn.Name = "GenerateReport_btn";
            this.GenerateReport_btn.Size = new System.Drawing.Size(75, 24);
            this.GenerateReport_btn.TabIndex = 4;
            this.GenerateReport_btn.Text = "Generate Report";
            this.GenerateReport_btn.UseVisualStyleBackColor = true;
            this.GenerateReport_btn.Click += new System.EventHandler(this.GenerateReport_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "show watch list report";
            // 
            // watch_list_transfer
            // 
            this.watch_list_transfer.Location = new System.Drawing.Point(58, 307);
            this.watch_list_transfer.Name = "watch_list_transfer";
            this.watch_list_transfer.Size = new System.Drawing.Size(75, 23);
            this.watch_list_transfer.TabIndex = 6;
            this.watch_list_transfer.Text = "show";
            this.watch_list_transfer.UseVisualStyleBackColor = true;
            this.watch_list_transfer.Click += new System.EventHandler(this.watch_list_transfer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.watch_list_transfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenerateReport_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.content_cmb);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox content_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateReport_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button watch_list_transfer;
    }
}