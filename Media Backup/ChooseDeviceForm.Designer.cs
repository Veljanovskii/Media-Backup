
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
            this.lbl_device = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_folder_text = new System.Windows.Forms.Label();
            this.btn_folder = new System.Windows.Forms.Button();
            this.lbl_folder_path = new System.Windows.Forms.Label();
            this.grb_device = new System.Windows.Forms.GroupBox();
            this.grb_folder = new System.Windows.Forms.GroupBox();
            this.chb_metafiles = new System.Windows.Forms.CheckBox();
            this.grb_device.SuspendLayout();
            this.grb_folder.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_devices
            // 
            this.cmb_devices.FormattingEnabled = true;
            this.cmb_devices.Location = new System.Drawing.Point(24, 75);
            this.cmb_devices.Name = "cmb_devices";
            this.cmb_devices.Size = new System.Drawing.Size(242, 28);
            this.cmb_devices.TabIndex = 0;
            // 
            // lbl_device
            // 
            this.lbl_device.AutoSize = true;
            this.lbl_device.Location = new System.Drawing.Point(24, 37);
            this.lbl_device.Name = "lbl_device";
            this.lbl_device.Size = new System.Drawing.Size(242, 20);
            this.lbl_device.TabIndex = 1;
            this.lbl_device.Text = "Choose which device to connect to:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(12, 396);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(94, 29);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "Proceed";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(125, 396);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_folder_text
            // 
            this.lbl_folder_text.AutoSize = true;
            this.lbl_folder_text.Location = new System.Drawing.Point(24, 37);
            this.lbl_folder_text.Name = "lbl_folder_text";
            this.lbl_folder_text.Size = new System.Drawing.Size(183, 20);
            this.lbl_folder_text.TabIndex = 4;
            this.lbl_folder_text.Text = "Choose destination folder:";
            // 
            // btn_folder
            // 
            this.btn_folder.Location = new System.Drawing.Point(223, 33);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(94, 29);
            this.btn_folder.TabIndex = 5;
            this.btn_folder.Text = "Change";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // lbl_folder_path
            // 
            this.lbl_folder_path.AutoSize = true;
            this.lbl_folder_path.Location = new System.Drawing.Point(24, 77);
            this.lbl_folder_path.Name = "lbl_folder_path";
            this.lbl_folder_path.Size = new System.Drawing.Size(50, 20);
            this.lbl_folder_path.TabIndex = 6;
            this.lbl_folder_path.Text = "label1";
            // 
            // grb_device
            // 
            this.grb_device.Controls.Add(this.lbl_device);
            this.grb_device.Controls.Add(this.cmb_devices);
            this.grb_device.Location = new System.Drawing.Point(12, 12);
            this.grb_device.Name = "grb_device";
            this.grb_device.Size = new System.Drawing.Size(350, 137);
            this.grb_device.TabIndex = 7;
            this.grb_device.TabStop = false;
            this.grb_device.Text = "Device choice";
            // 
            // grb_folder
            // 
            this.grb_folder.Controls.Add(this.lbl_folder_text);
            this.grb_folder.Controls.Add(this.lbl_folder_path);
            this.grb_folder.Controls.Add(this.btn_folder);
            this.grb_folder.Location = new System.Drawing.Point(12, 170);
            this.grb_folder.Name = "grb_folder";
            this.grb_folder.Size = new System.Drawing.Size(350, 157);
            this.grb_folder.TabIndex = 8;
            this.grb_folder.TabStop = false;
            this.grb_folder.Text = "Destination folder";
            // 
            // chb_metafiles
            // 
            this.chb_metafiles.AutoSize = true;
            this.chb_metafiles.Location = new System.Drawing.Point(36, 349);
            this.chb_metafiles.Name = "chb_metafiles";
            this.chb_metafiles.Size = new System.Drawing.Size(123, 24);
            this.chb_metafiles.TabIndex = 9;
            this.chb_metafiles.Text = "Use metadata";
            this.chb_metafiles.UseVisualStyleBackColor = true;
            // 
            // ChooseDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 437);
            this.Controls.Add(this.chb_metafiles);
            this.Controls.Add(this.grb_folder);
            this.Controls.Add(this.grb_device);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChooseDeviceForm";
            this.Text = "Detected devices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseDeviceForm_FormClosing);
            this.Load += new System.EventHandler(this.ChooseDeviceForm_Load);
            this.grb_device.ResumeLayout(false);
            this.grb_device.PerformLayout();
            this.grb_folder.ResumeLayout(false);
            this.grb_folder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_device;
        public System.Windows.Forms.ComboBox cmb_devices;
        public System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_folder_text;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.Label lbl_folder_path;
        private System.Windows.Forms.GroupBox grb_device;
        private System.Windows.Forms.GroupBox grb_folder;
        private System.Windows.Forms.CheckBox chb_metafiles;
    }
}