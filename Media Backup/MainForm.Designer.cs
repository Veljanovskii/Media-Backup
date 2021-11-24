
namespace Media_Backup
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grb_preview = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pcb_image = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.txt_tag = new System.Windows.Forms.TextBox();
            this.btn_tag = new System.Windows.Forms.Button();
            this.lbl_tag = new System.Windows.Forms.Label();
            this.trb_time = new System.Windows.Forms.TrackBar();
            this.lbl_time = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_time)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_preview
            // 
            this.grb_preview.Controls.Add(this.axWindowsMediaPlayer1);
            this.grb_preview.Controls.Add(this.pcb_image);
            this.grb_preview.Location = new System.Drawing.Point(12, 38);
            this.grb_preview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_preview.Name = "grb_preview";
            this.grb_preview.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_preview.Size = new System.Drawing.Size(532, 352);
            this.grb_preview.TabIndex = 1;
            this.grb_preview.TabStop = false;
            this.grb_preview.Text = "Media preview";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 29);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(520, 312);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // pcb_image
            // 
            this.pcb_image.Location = new System.Drawing.Point(6, 29);
            this.pcb_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcb_image.Name = "pcb_image";
            this.pcb_image.Size = new System.Drawing.Size(520, 312);
            this.pcb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_image.TabIndex = 0;
            this.pcb_image.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(180, 400);
            this.btn_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(37, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.TabStop = false;
            this.btn_start.Text = "<<";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(320, 400);
            this.btn_end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(37, 23);
            this.btn_end.TabIndex = 5;
            this.btn_end.TabStop = false;
            this.btn_end.Text = ">>";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(220, 400);
            this.btn_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(37, 23);
            this.btn_left.TabIndex = 3;
            this.btn_left.TabStop = false;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(280, 400);
            this.btn_right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(37, 23);
            this.btn_right.TabIndex = 4;
            this.btn_right.TabStop = false;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(591, 46);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(46, 17);
            this.lbl_count.TabIndex = 6;
            this.lbl_count.Text = "label1";
            // 
            // txt_tag
            // 
            this.txt_tag.Location = new System.Drawing.Point(678, 265);
            this.txt_tag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tag.Name = "txt_tag";
            this.txt_tag.Size = new System.Drawing.Size(125, 22);
            this.txt_tag.TabIndex = 10;
            this.txt_tag.TabStop = false;
            // 
            // btn_tag
            // 
            this.btn_tag.Location = new System.Drawing.Point(606, 302);
            this.btn_tag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tag.Name = "btn_tag";
            this.btn_tag.Size = new System.Drawing.Size(94, 23);
            this.btn_tag.TabIndex = 11;
            this.btn_tag.TabStop = false;
            this.btn_tag.Text = "Add tag";
            this.btn_tag.UseVisualStyleBackColor = true;
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Location = new System.Drawing.Point(606, 267);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(37, 17);
            this.lbl_tag.TabIndex = 9;
            this.lbl_tag.Text = "Tag:";
            // 
            // trb_time
            // 
            this.trb_time.Location = new System.Drawing.Point(591, 182);
            this.trb_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trb_time.Maximum = 5;
            this.trb_time.Name = "trb_time";
            this.trb_time.Size = new System.Drawing.Size(243, 56);
            this.trb_time.TabIndex = 8;
            this.trb_time.TabStop = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(591, 141);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(157, 17);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "Allowed time difference:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_settings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_settings
            // 
            this.tsmi_settings.Name = "tsmi_settings";
            this.tsmi_settings.Size = new System.Drawing.Size(76, 24);
            this.tsmi_settings.Text = "Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 518);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.trb_time);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.lbl_tag);
            this.Controls.Add(this.btn_tag);
            this.Controls.Add(this.txt_tag);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.grb_preview);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Media Backup";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
            this.grb_preview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_time)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox grb_preview;
        public System.Windows.Forms.PictureBox pcb_image;
        private System.Windows.Forms.TextBox txt_tag;
        private System.Windows.Forms.Button btn_tag;
        public System.Windows.Forms.Label lbl_count;
        public System.Windows.Forms.Button btn_start;
        public System.Windows.Forms.Button btn_end;
        public System.Windows.Forms.Button btn_left;
        public System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Label lbl_tag;
        private System.Windows.Forms.TrackBar trb_time;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_settings;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

