
namespace Media_Backup
{
    partial class ProgressBarForm
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
            this.pgb_bar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pgb_bar
            // 
            this.pgb_bar.Location = new System.Drawing.Point(64, 75);
            this.pgb_bar.Name = "pgb_bar";
            this.pgb_bar.Size = new System.Drawing.Size(243, 29);
            this.pgb_bar.TabIndex = 0;
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 116);
            this.Controls.Add(this.pgb_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressBarForm";
            this.ShowInTaskbar = false;
            this.Text = "Transfering...";
            this.Load += new System.EventHandler(this.ProgressBarForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb_bar;
    }
}