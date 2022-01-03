
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_dest_text = new System.Windows.Forms.Label();
            this.btn_dest = new System.Windows.Forms.Button();
            this.grb_device = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_device = new System.Windows.Forms.Label();
            this.cmb_devices = new System.Windows.Forms.ComboBox();
            this.grb_dest = new System.Windows.Forms.GroupBox();
            this.txt_dest_path = new System.Windows.Forms.TextBox();
            this.chb_metafiles = new System.Windows.Forms.CheckBox();
            this.grb_source = new System.Windows.Forms.GroupBox();
            this.txt_source_path = new System.Windows.Forms.TextBox();
            this.lbl_source_text = new System.Windows.Forms.Label();
            this.btn_source = new System.Windows.Forms.Button();
            this.grb_media_formats = new System.Windows.Forms.GroupBox();
            this.chb_flv = new System.Windows.Forms.CheckBox();
            this.chb_mov = new System.Windows.Forms.CheckBox();
            this.chb_avi = new System.Windows.Forms.CheckBox();
            this.chb_wmv = new System.Windows.Forms.CheckBox();
            this.chb_mp4 = new System.Windows.Forms.CheckBox();
            this.chb_gif = new System.Windows.Forms.CheckBox();
            this.chb_svg = new System.Windows.Forms.CheckBox();
            this.chb_jpeg = new System.Windows.Forms.CheckBox();
            this.chb_png = new System.Windows.Forms.CheckBox();
            this.chb_jpg = new System.Windows.Forms.CheckBox();
            this.grb_device.SuspendLayout();
            this.grb_dest.SuspendLayout();
            this.grb_source.SuspendLayout();
            this.grb_media_formats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(12, 633);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(94, 29);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "Proceed";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(125, 633);
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
            this.lbl_dest_text.Size = new System.Drawing.Size(180, 20);
            this.lbl_dest_text.TabIndex = 4;
            this.lbl_dest_text.Text = "Choose destination folder";
            // 
            // btn_dest
            // 
            this.btn_dest.Location = new System.Drawing.Point(279, 33);
            this.btn_dest.Name = "btn_dest";
            this.btn_dest.Size = new System.Drawing.Size(94, 29);
            this.btn_dest.TabIndex = 5;
            this.btn_dest.TabStop = false;
            this.btn_dest.Text = "Browse";
            this.btn_dest.UseVisualStyleBackColor = true;
            this.btn_dest.Click += new System.EventHandler(this.btn_dest_Click);
            // 
            // grb_device
            // 
            this.grb_device.Controls.Add(this.btn_refresh);
            this.grb_device.Controls.Add(this.lbl_device);
            this.grb_device.Controls.Add(this.cmb_devices);
            this.grb_device.Location = new System.Drawing.Point(12, 12);
            this.grb_device.Name = "grb_device";
            this.grb_device.Size = new System.Drawing.Size(392, 148);
            this.grb_device.TabIndex = 7;
            this.grb_device.TabStop = false;
            this.grb_device.Text = "Device choice";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(279, 75);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(94, 29);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.TabStop = false;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_device
            // 
            this.lbl_device.AutoSize = true;
            this.lbl_device.Location = new System.Drawing.Point(24, 37);
            this.lbl_device.Name = "lbl_device";
            this.lbl_device.Size = new System.Drawing.Size(239, 20);
            this.lbl_device.TabIndex = 1;
            this.lbl_device.Text = "Choose which device to connect to";
            // 
            // cmb_devices
            // 
            this.cmb_devices.FormattingEnabled = true;
            this.cmb_devices.Location = new System.Drawing.Point(24, 75);
            this.cmb_devices.Name = "cmb_devices";
            this.cmb_devices.Size = new System.Drawing.Size(242, 28);
            this.cmb_devices.TabIndex = 0;
            // 
            // grb_dest
            // 
            this.grb_dest.Controls.Add(this.txt_dest_path);
            this.grb_dest.Controls.Add(this.lbl_dest_text);
            this.grb_dest.Controls.Add(this.btn_dest);
            this.grb_dest.Location = new System.Drawing.Point(12, 308);
            this.grb_dest.Name = "grb_dest";
            this.grb_dest.Size = new System.Drawing.Size(392, 128);
            this.grb_dest.TabIndex = 8;
            this.grb_dest.TabStop = false;
            this.grb_dest.Text = "Destination folder";
            // 
            // txt_dest_path
            // 
            this.txt_dest_path.Location = new System.Drawing.Point(24, 80);
            this.txt_dest_path.Name = "txt_dest_path";
            this.txt_dest_path.Size = new System.Drawing.Size(349, 27);
            this.txt_dest_path.TabIndex = 8;
            // 
            // chb_metafiles
            // 
            this.chb_metafiles.AutoSize = true;
            this.chb_metafiles.Location = new System.Drawing.Point(36, 589);
            this.chb_metafiles.Name = "chb_metafiles";
            this.chb_metafiles.Size = new System.Drawing.Size(254, 24);
            this.chb_metafiles.TabIndex = 9;
            this.chb_metafiles.Text = "Extract media info from file name";
            this.chb_metafiles.UseVisualStyleBackColor = true;
            // 
            // grb_source
            // 
            this.grb_source.Controls.Add(this.txt_source_path);
            this.grb_source.Controls.Add(this.lbl_source_text);
            this.grb_source.Controls.Add(this.btn_source);
            this.grb_source.Location = new System.Drawing.Point(12, 166);
            this.grb_source.Name = "grb_source";
            this.grb_source.Size = new System.Drawing.Size(392, 128);
            this.grb_source.TabIndex = 9;
            this.grb_source.TabStop = false;
            this.grb_source.Text = "Source folder";
            // 
            // txt_source_path
            // 
            this.txt_source_path.Location = new System.Drawing.Point(24, 84);
            this.txt_source_path.Name = "txt_source_path";
            this.txt_source_path.Size = new System.Drawing.Size(349, 27);
            this.txt_source_path.TabIndex = 7;
            // 
            // lbl_source_text
            // 
            this.lbl_source_text.AutoSize = true;
            this.lbl_source_text.Location = new System.Drawing.Point(24, 41);
            this.lbl_source_text.Name = "lbl_source_text";
            this.lbl_source_text.Size = new System.Drawing.Size(149, 20);
            this.lbl_source_text.TabIndex = 4;
            this.lbl_source_text.Text = "Choose source folder";
            // 
            // btn_source
            // 
            this.btn_source.Location = new System.Drawing.Point(279, 37);
            this.btn_source.Name = "btn_source";
            this.btn_source.Size = new System.Drawing.Size(94, 29);
            this.btn_source.TabIndex = 5;
            this.btn_source.TabStop = false;
            this.btn_source.Text = "Browse";
            this.btn_source.UseVisualStyleBackColor = true;
            this.btn_source.Click += new System.EventHandler(this.btn_source_Click);
            // 
            // grb_media_formats
            // 
            this.grb_media_formats.Controls.Add(this.chb_flv);
            this.grb_media_formats.Controls.Add(this.chb_mov);
            this.grb_media_formats.Controls.Add(this.chb_avi);
            this.grb_media_formats.Controls.Add(this.chb_wmv);
            this.grb_media_formats.Controls.Add(this.chb_mp4);
            this.grb_media_formats.Controls.Add(this.chb_gif);
            this.grb_media_formats.Controls.Add(this.chb_svg);
            this.grb_media_formats.Controls.Add(this.chb_jpeg);
            this.grb_media_formats.Controls.Add(this.chb_png);
            this.grb_media_formats.Controls.Add(this.chb_jpg);
            this.grb_media_formats.Location = new System.Drawing.Point(12, 443);
            this.grb_media_formats.Name = "grb_media_formats";
            this.grb_media_formats.Size = new System.Drawing.Size(392, 128);
            this.grb_media_formats.TabIndex = 10;
            this.grb_media_formats.TabStop = false;
            this.grb_media_formats.Text = "Media formats";
            // 
            // chb_flv
            // 
            this.chb_flv.AutoSize = true;
            this.chb_flv.Checked = true;
            this.chb_flv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_flv.Location = new System.Drawing.Point(293, 81);
            this.chb_flv.Name = "chb_flv";
            this.chb_flv.Size = new System.Drawing.Size(50, 24);
            this.chb_flv.TabIndex = 14;
            this.chb_flv.TabStop = false;
            this.chb_flv.Text = ".flv";
            this.chb_flv.UseVisualStyleBackColor = true;
            // 
            // chb_mov
            // 
            this.chb_mov.AutoSize = true;
            this.chb_mov.Checked = true;
            this.chb_mov.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_mov.Location = new System.Drawing.Point(221, 81);
            this.chb_mov.Name = "chb_mov";
            this.chb_mov.Size = new System.Drawing.Size(63, 24);
            this.chb_mov.TabIndex = 13;
            this.chb_mov.TabStop = false;
            this.chb_mov.Text = ".mov";
            this.chb_mov.UseVisualStyleBackColor = true;
            // 
            // chb_avi
            // 
            this.chb_avi.AutoSize = true;
            this.chb_avi.Checked = true;
            this.chb_avi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_avi.Location = new System.Drawing.Point(151, 81);
            this.chb_avi.Name = "chb_avi";
            this.chb_avi.Size = new System.Drawing.Size(53, 24);
            this.chb_avi.TabIndex = 12;
            this.chb_avi.TabStop = false;
            this.chb_avi.Text = ".avi";
            this.chb_avi.UseVisualStyleBackColor = true;
            // 
            // chb_wmv
            // 
            this.chb_wmv.AutoSize = true;
            this.chb_wmv.Checked = true;
            this.chb_wmv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_wmv.Location = new System.Drawing.Point(86, 81);
            this.chb_wmv.Name = "chb_wmv";
            this.chb_wmv.Size = new System.Drawing.Size(65, 24);
            this.chb_wmv.TabIndex = 11;
            this.chb_wmv.TabStop = false;
            this.chb_wmv.Text = ".wmv";
            this.chb_wmv.UseVisualStyleBackColor = true;
            // 
            // chb_mp4
            // 
            this.chb_mp4.AutoCheck = false;
            this.chb_mp4.AutoSize = true;
            this.chb_mp4.Checked = true;
            this.chb_mp4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_mp4.Location = new System.Drawing.Point(24, 81);
            this.chb_mp4.Name = "chb_mp4";
            this.chb_mp4.Size = new System.Drawing.Size(64, 24);
            this.chb_mp4.TabIndex = 10;
            this.chb_mp4.TabStop = false;
            this.chb_mp4.Text = ".mp4";
            this.chb_mp4.UseVisualStyleBackColor = true;
            // 
            // chb_gif
            // 
            this.chb_gif.AutoSize = true;
            this.chb_gif.Checked = true;
            this.chb_gif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_gif.Location = new System.Drawing.Point(293, 41);
            this.chb_gif.Name = "chb_gif";
            this.chb_gif.Size = new System.Drawing.Size(52, 24);
            this.chb_gif.TabIndex = 9;
            this.chb_gif.TabStop = false;
            this.chb_gif.Text = ".gif";
            this.chb_gif.UseVisualStyleBackColor = true;
            // 
            // chb_svg
            // 
            this.chb_svg.AutoSize = true;
            this.chb_svg.Checked = true;
            this.chb_svg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_svg.Location = new System.Drawing.Point(221, 41);
            this.chb_svg.Name = "chb_svg";
            this.chb_svg.Size = new System.Drawing.Size(56, 24);
            this.chb_svg.TabIndex = 8;
            this.chb_svg.TabStop = false;
            this.chb_svg.Text = ".svg";
            this.chb_svg.UseVisualStyleBackColor = true;
            // 
            // chb_jpeg
            // 
            this.chb_jpeg.AutoSize = true;
            this.chb_jpeg.Checked = true;
            this.chb_jpeg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_jpeg.Location = new System.Drawing.Point(151, 41);
            this.chb_jpeg.Name = "chb_jpeg";
            this.chb_jpeg.Size = new System.Drawing.Size(64, 24);
            this.chb_jpeg.TabIndex = 7;
            this.chb_jpeg.TabStop = false;
            this.chb_jpeg.Text = ".jpeg";
            this.chb_jpeg.UseVisualStyleBackColor = true;
            // 
            // chb_png
            // 
            this.chb_png.AutoSize = true;
            this.chb_png.Checked = true;
            this.chb_png.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_png.Location = new System.Drawing.Point(86, 41);
            this.chb_png.Name = "chb_png";
            this.chb_png.Size = new System.Drawing.Size(60, 24);
            this.chb_png.TabIndex = 6;
            this.chb_png.TabStop = false;
            this.chb_png.Text = ".png";
            this.chb_png.UseVisualStyleBackColor = true;
            // 
            // chb_jpg
            // 
            this.chb_jpg.AutoCheck = false;
            this.chb_jpg.AutoSize = true;
            this.chb_jpg.Checked = true;
            this.chb_jpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_jpg.Location = new System.Drawing.Point(24, 41);
            this.chb_jpg.Name = "chb_jpg";
            this.chb_jpg.Size = new System.Drawing.Size(56, 24);
            this.chb_jpg.TabIndex = 5;
            this.chb_jpg.TabStop = false;
            this.chb_jpg.Text = ".jpg";
            this.chb_jpg.UseVisualStyleBackColor = true;
            // 
            // ChooseDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 674);
            this.Controls.Add(this.grb_media_formats);
            this.Controls.Add(this.grb_source);
            this.Controls.Add(this.chb_metafiles);
            this.Controls.Add(this.grb_dest);
            this.Controls.Add(this.grb_device);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChooseDeviceForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.ChooseDeviceForm_Load);
            this.grb_device.ResumeLayout(false);
            this.grb_device.PerformLayout();
            this.grb_dest.ResumeLayout(false);
            this.grb_dest.PerformLayout();
            this.grb_source.ResumeLayout(false);
            this.grb_source.PerformLayout();
            this.grb_media_formats.ResumeLayout(false);
            this.grb_media_formats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_dest_text;
        private System.Windows.Forms.Button btn_dest;
        private System.Windows.Forms.GroupBox grb_device;
        private System.Windows.Forms.GroupBox grb_dest;
        private System.Windows.Forms.CheckBox chb_metafiles;
        private System.Windows.Forms.GroupBox grb_source;
        private System.Windows.Forms.Label lbl_source_text;
        private System.Windows.Forms.Button btn_source;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_device;
        public System.Windows.Forms.ComboBox cmb_devices;
        private System.Windows.Forms.TextBox txt_source_path;
        private System.Windows.Forms.TextBox txt_dest_path;
        private System.Windows.Forms.GroupBox grb_media_formats;
        private System.Windows.Forms.CheckBox chb_gif;
        private System.Windows.Forms.CheckBox chb_svg;
        private System.Windows.Forms.CheckBox chb_jpeg;
        private System.Windows.Forms.CheckBox chb_png;
        private System.Windows.Forms.CheckBox chb_jpg;
        private System.Windows.Forms.CheckBox chb_flv;
        private System.Windows.Forms.CheckBox chb_mov;
        private System.Windows.Forms.CheckBox chb_avi;
        private System.Windows.Forms.CheckBox chb_wmv;
        private System.Windows.Forms.CheckBox chb_mp4;
    }
}