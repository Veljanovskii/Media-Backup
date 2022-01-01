
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
            this.lbl_dest_text = new System.Windows.Forms.Label();
            this.btn_dest = new System.Windows.Forms.Button();
            this.lbl_dest_path = new System.Windows.Forms.Label();
            this.grb_device = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.grb_dest = new System.Windows.Forms.GroupBox();
            this.chb_metafiles = new System.Windows.Forms.CheckBox();
            this.grb_source = new System.Windows.Forms.GroupBox();
            this.lbl_source_text = new System.Windows.Forms.Label();
            this.lbl_source_path = new System.Windows.Forms.Label();
            this.btn_source = new System.Windows.Forms.Button();
            this.grb_device.SuspendLayout();
            this.grb_dest.SuspendLayout();
            this.grb_source.SuspendLayout();
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
            this.btn_ok.Location = new System.Drawing.Point(12, 573);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(94, 29);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "Proceed";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(125, 573);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_dest_text
            // 
            this.lbl_dest_text.AutoSize = true;
            this.lbl_dest_text.Location = new System.Drawing.Point(24, 37);
            this.lbl_dest_text.Name = "lbl_dest_text";
            this.lbl_dest_text.Size = new System.Drawing.Size(183, 20);
            this.lbl_dest_text.TabIndex = 4;
            this.lbl_dest_text.Text = "Choose destination folder:";
            // 
            // btn_dest
            // 
            this.btn_dest.Location = new System.Drawing.Point(223, 33);
            this.btn_dest.Name = "btn_dest";
            this.btn_dest.Size = new System.Drawing.Size(94, 29);
            this.btn_dest.TabIndex = 5;
            this.btn_dest.Text = "Browse";
            this.btn_dest.UseVisualStyleBackColor = true;
            this.btn_dest.Click += new System.EventHandler(this.btn_dest_Click);
            // 
            // lbl_dest_path
            // 
            this.lbl_dest_path.AutoSize = true;
            this.lbl_dest_path.Location = new System.Drawing.Point(24, 77);
            this.lbl_dest_path.Name = "lbl_dest_path";
            this.lbl_dest_path.Size = new System.Drawing.Size(50, 20);
            this.lbl_dest_path.TabIndex = 6;
            this.lbl_dest_path.Text = "label1";
            // 
            // grb_device
            // 
            this.grb_device.Controls.Add(this.btn_refresh);
            this.grb_device.Controls.Add(this.lbl_device);
            this.grb_device.Controls.Add(this.cmb_devices);
            this.grb_device.Location = new System.Drawing.Point(12, 12);
            this.grb_device.Name = "grb_device";
            this.grb_device.Size = new System.Drawing.Size(350, 172);
            this.grb_device.TabIndex = 7;
            this.grb_device.TabStop = false;
            this.grb_device.Text = "Device choice";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(223, 125);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(94, 29);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // grb_dest
            // 
            this.grb_dest.Controls.Add(this.lbl_dest_text);
            this.grb_dest.Controls.Add(this.lbl_dest_path);
            this.grb_dest.Controls.Add(this.btn_dest);
            this.grb_dest.Location = new System.Drawing.Point(12, 356);
            this.grb_dest.Name = "grb_dest";
            this.grb_dest.Size = new System.Drawing.Size(350, 157);
            this.grb_dest.TabIndex = 8;
            this.grb_dest.TabStop = false;
            this.grb_dest.Text = "Destination folder";
            // 
            // chb_metafiles
            // 
            this.chb_metafiles.AutoSize = true;
            this.chb_metafiles.Location = new System.Drawing.Point(36, 529);
            this.chb_metafiles.Name = "chb_metafiles";
            this.chb_metafiles.Size = new System.Drawing.Size(254, 24);
            this.chb_metafiles.TabIndex = 9;
            this.chb_metafiles.Text = "Extract media info from file name";
            this.chb_metafiles.UseVisualStyleBackColor = true;
            // 
            // grb_source
            // 
            this.grb_source.Controls.Add(this.lbl_source_text);
            this.grb_source.Controls.Add(this.lbl_source_path);
            this.grb_source.Controls.Add(this.btn_source);
            this.grb_source.Location = new System.Drawing.Point(12, 201);
            this.grb_source.Name = "grb_source";
            this.grb_source.Size = new System.Drawing.Size(350, 140);
            this.grb_source.TabIndex = 9;
            this.grb_source.TabStop = false;
            this.grb_source.Text = "Source folder";
            // 
            // lbl_source_text
            // 
            this.lbl_source_text.AutoSize = true;
            this.lbl_source_text.Location = new System.Drawing.Point(24, 37);
            this.lbl_source_text.Name = "lbl_source_text";
            this.lbl_source_text.Size = new System.Drawing.Size(152, 20);
            this.lbl_source_text.TabIndex = 4;
            this.lbl_source_text.Text = "Choose source folder:";
            // 
            // lbl_source_path
            // 
            this.lbl_source_path.AutoSize = true;
            this.lbl_source_path.Location = new System.Drawing.Point(24, 77);
            this.lbl_source_path.Name = "lbl_source_path";
            this.lbl_source_path.Size = new System.Drawing.Size(42, 20);
            this.lbl_source_path.TabIndex = 6;
            this.lbl_source_path.Text = "label";
            // 
            // btn_source
            // 
            this.btn_source.Location = new System.Drawing.Point(223, 33);
            this.btn_source.Name = "btn_source";
            this.btn_source.Size = new System.Drawing.Size(94, 29);
            this.btn_source.TabIndex = 5;
            this.btn_source.Text = "Browse";
            this.btn_source.UseVisualStyleBackColor = true;
            this.btn_source.Click += new System.EventHandler(this.btn_source_Click);
            // 
            // ChooseDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 627);
            this.Controls.Add(this.grb_source);
            this.Controls.Add(this.chb_metafiles);
            this.Controls.Add(this.grb_dest);
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
            this.grb_dest.ResumeLayout(false);
            this.grb_dest.PerformLayout();
            this.grb_source.ResumeLayout(false);
            this.grb_source.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_device;
        public System.Windows.Forms.ComboBox cmb_devices;
        public System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_dest_text;
        private System.Windows.Forms.Button btn_dest;
        private System.Windows.Forms.Label lbl_dest_path;
        private System.Windows.Forms.GroupBox grb_device;
        private System.Windows.Forms.GroupBox grb_dest;
        private System.Windows.Forms.CheckBox chb_metafiles;
        private System.Windows.Forms.GroupBox grb_source;
        private System.Windows.Forms.Label lbl_source_text;
        private System.Windows.Forms.Label lbl_source_path;
        private System.Windows.Forms.Button btn_source;
        private System.Windows.Forms.Button btn_refresh;
    }
}