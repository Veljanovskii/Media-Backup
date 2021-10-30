
namespace Media_Backup
{
    partial class ChooseDeviceForm
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
            this.cmb_devices = new System.Windows.Forms.ComboBox();
            this.lbl_text = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_devices
            // 
            this.cmb_devices.FormattingEnabled = true;
            this.cmb_devices.Location = new System.Drawing.Point(36, 63);
            this.cmb_devices.Name = "cmb_devices";
            this.cmb_devices.Size = new System.Drawing.Size(242, 28);
            this.cmb_devices.TabIndex = 0;
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(36, 21);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(242, 20);
            this.lbl_text.TabIndex = 1;
            this.lbl_text.Text = "Choose which device to connect to:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(36, 124);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(94, 29);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(154, 124);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ChooseDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 171);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.cmb_devices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChooseDeviceForm";
            this.Text = "Detected devices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseDeviceForm_FormClosing);
            this.Load += new System.EventHandler(this.ChooseDeviceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_text;
        public System.Windows.Forms.ComboBox cmb_devices;
        public System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.Button btn_cancel;
    }
}