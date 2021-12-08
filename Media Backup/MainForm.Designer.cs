
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
            this.grb_preview = new System.Windows.Forms.GroupBox();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.lbl_media = new System.Windows.Forms.Label();
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
            this.lbl_trackbar = new System.Windows.Forms.Label();
            this.grb_tags = new System.Windows.Forms.GroupBox();
            this.lbl_selected = new System.Windows.Forms.Label();
            this.clb_media = new System.Windows.Forms.CheckedListBox();
            this.chb_checkall = new System.Windows.Forms.CheckBox();
            this.grb_preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_time)).BeginInit();
            this.grb_tags.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_preview
            // 
            this.grb_preview.Controls.Add(this.lbl_datetime);
            this.grb_preview.Controls.Add(this.lbl_counter);
            this.grb_preview.Controls.Add(this.lbl_media);
            this.grb_preview.Controls.Add(this.pcb_image);
            this.grb_preview.Location = new System.Drawing.Point(12, 66);
            this.grb_preview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_preview.Name = "grb_preview";
            this.grb_preview.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_preview.Size = new System.Drawing.Size(532, 520);
            this.grb_preview.TabIndex = 1;
            this.grb_preview.TabStop = false;
            this.grb_preview.Text = "Media preview";
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.AutoSize = true;
            this.lbl_datetime.Location = new System.Drawing.Point(31, 475);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(42, 20);
            this.lbl_datetime.TabIndex = 3;
            this.lbl_datetime.Text = "Time";
            this.lbl_datetime.Visible = false;
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Location = new System.Drawing.Point(479, 475);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(27, 20);
            this.lbl_counter.TabIndex = 2;
            this.lbl_counter.Text = "_/_";
            this.lbl_counter.Visible = false;
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(180, 30);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(49, 20);
            this.lbl_media.TabIndex = 1;
            this.lbl_media.Text = "Name";
            this.lbl_media.Visible = false;
            // 
            // pcb_image
            // 
            this.pcb_image.Location = new System.Drawing.Point(6, 66);
            this.pcb_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcb_image.Name = "pcb_image";
            this.pcb_image.Size = new System.Drawing.Size(520, 390);
            this.pcb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_image.TabIndex = 0;
            this.pcb_image.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(180, 600);
            this.btn_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(37, 29);
            this.btn_start.TabIndex = 2;
            this.btn_start.TabStop = false;
            this.btn_start.Text = "<<";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(320, 600);
            this.btn_end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(37, 29);
            this.btn_end.TabIndex = 5;
            this.btn_end.TabStop = false;
            this.btn_end.Text = ">>";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(220, 600);
            this.btn_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(37, 29);
            this.btn_left.TabIndex = 3;
            this.btn_left.TabStop = false;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(280, 600);
            this.btn_right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(37, 29);
            this.btn_right.TabIndex = 4;
            this.btn_right.TabStop = false;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(162, 27);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(155, 20);
            this.lbl_count.TabIndex = 6;
            this.lbl_count.Text = "_ new media detected";
            // 
            // txt_tag
            // 
            this.txt_tag.Location = new System.Drawing.Point(102, 191);
            this.txt_tag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tag.Name = "txt_tag";
            this.txt_tag.Size = new System.Drawing.Size(125, 27);
            this.txt_tag.TabIndex = 10;
            this.txt_tag.TabStop = false;
            // 
            // btn_tag
            // 
            this.btn_tag.Location = new System.Drawing.Point(256, 190);
            this.btn_tag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tag.Name = "btn_tag";
            this.btn_tag.Size = new System.Drawing.Size(94, 29);
            this.btn_tag.TabIndex = 11;
            this.btn_tag.TabStop = false;
            this.btn_tag.Text = "Add tag";
            this.btn_tag.UseVisualStyleBackColor = true;
            this.btn_tag.Click += new System.EventHandler(this.btn_tag_Click);
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Location = new System.Drawing.Point(30, 194);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(35, 20);
            this.lbl_tag.TabIndex = 9;
            this.lbl_tag.Text = "Tag:";
            // 
            // trb_time
            // 
            this.trb_time.Location = new System.Drawing.Point(27, 94);
            this.trb_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trb_time.Maximum = 5;
            this.trb_time.Name = "trb_time";
            this.trb_time.Size = new System.Drawing.Size(243, 56);
            this.trb_time.TabIndex = 8;
            this.trb_time.TabStop = false;
            this.trb_time.Scroll += new System.EventHandler(this.trb_time_Scroll);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(27, 42);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(173, 20);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "Time difference allowed:";
            // 
            // lbl_trackbar
            // 
            this.lbl_trackbar.AutoSize = true;
            this.lbl_trackbar.Location = new System.Drawing.Point(277, 94);
            this.lbl_trackbar.Name = "lbl_trackbar";
            this.lbl_trackbar.Size = new System.Drawing.Size(73, 20);
            this.lbl_trackbar.TabIndex = 12;
            this.lbl_trackbar.Text = "2 minutes";
            // 
            // grb_tags
            // 
            this.grb_tags.Controls.Add(this.lbl_selected);
            this.grb_tags.Controls.Add(this.lbl_time);
            this.grb_tags.Controls.Add(this.lbl_trackbar);
            this.grb_tags.Controls.Add(this.trb_time);
            this.grb_tags.Controls.Add(this.txt_tag);
            this.grb_tags.Controls.Add(this.btn_tag);
            this.grb_tags.Controls.Add(this.lbl_tag);
            this.grb_tags.Location = new System.Drawing.Point(569, 66);
            this.grb_tags.Name = "grb_tags";
            this.grb_tags.Size = new System.Drawing.Size(407, 243);
            this.grb_tags.TabIndex = 13;
            this.grb_tags.TabStop = false;
            this.grb_tags.Text = "Manage tags";
            // 
            // lbl_selected
            // 
            this.lbl_selected.AutoSize = true;
            this.lbl_selected.Location = new System.Drawing.Point(30, 142);
            this.lbl_selected.Name = "lbl_selected";
            this.lbl_selected.Size = new System.Drawing.Size(120, 20);
            this.lbl_selected.TabIndex = 13;
            this.lbl_selected.Text = "_ media selected";
            this.lbl_selected.Visible = false;
            // 
            // clb_media
            // 
            this.clb_media.FormattingEnabled = true;
            this.clb_media.Location = new System.Drawing.Point(569, 361);
            this.clb_media.Name = "clb_media";
            this.clb_media.Size = new System.Drawing.Size(350, 268);
            this.clb_media.TabIndex = 14;
            this.clb_media.SelectedIndexChanged += new System.EventHandler(this.clb_media_SelectedIndexChanged);
            this.clb_media.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clb_media_MouseDown);
            // 
            // chb_checkall
            // 
            this.chb_checkall.AutoSize = true;
            this.chb_checkall.Location = new System.Drawing.Point(569, 331);
            this.chb_checkall.Name = "chb_checkall";
            this.chb_checkall.Size = new System.Drawing.Size(90, 24);
            this.chb_checkall.TabIndex = 15;
            this.chb_checkall.Text = "Check all";
            this.chb_checkall.UseVisualStyleBackColor = true;
            this.chb_checkall.CheckedChanged += new System.EventHandler(this.chb_checkall_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 659);
            this.Controls.Add(this.chb_checkall);
            this.Controls.Add(this.clb_media);
            this.Controls.Add(this.grb_tags);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.grb_preview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Media Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
            this.grb_preview.ResumeLayout(false);
            this.grb_preview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_time)).EndInit();
            this.grb_tags.ResumeLayout(false);
            this.grb_tags.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox grb_preview;
        public System.Windows.Forms.PictureBox pcb_image;
        private System.Windows.Forms.Button btn_tag;
        public System.Windows.Forms.Label lbl_count;
        public System.Windows.Forms.Button btn_start;
        public System.Windows.Forms.Button btn_end;
        public System.Windows.Forms.Button btn_left;
        public System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Label lbl_tag;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_trackbar;
        public System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.GroupBox grb_tags;
        public System.Windows.Forms.CheckedListBox clb_media;
        public System.Windows.Forms.Label lbl_counter;
        public System.Windows.Forms.Label lbl_datetime;
        public System.Windows.Forms.TrackBar trb_time;
        public System.Windows.Forms.Label lbl_selected;
        public System.Windows.Forms.TextBox txt_tag;
        private System.Windows.Forms.CheckBox chb_checkall;
    }
}

