﻿
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.pcb_image = new System.Windows.Forms.PictureBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_tag = new System.Windows.Forms.Button();
            this.grb_source = new System.Windows.Forms.GroupBox();
            this.lbl_source_path = new System.Windows.Forms.Label();
            this.btn_source = new System.Windows.Forms.Button();
            this.lbl_tag = new System.Windows.Forms.Label();
            this.trb_time = new System.Windows.Forms.TrackBar();
            this.lbl_time = new System.Windows.Forms.Label();
            this.grb_preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_image)).BeginInit();
            this.grb_source.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_time)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_preview
            // 
            this.grb_preview.Controls.Add(this.btn_start);
            this.grb_preview.Controls.Add(this.btn_end);
            this.grb_preview.Controls.Add(this.btn_left);
            this.grb_preview.Controls.Add(this.btn_right);
            this.grb_preview.Controls.Add(this.pcb_image);
            this.grb_preview.Location = new System.Drawing.Point(12, 12);
            this.grb_preview.Name = "grb_preview";
            this.grb_preview.Size = new System.Drawing.Size(532, 608);
            this.grb_preview.TabIndex = 1;
            this.grb_preview.TabStop = false;
            this.grb_preview.Text = "Media preview";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(172, 573);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(37, 29);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "<<";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(314, 573);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(37, 29);
            this.btn_end.TabIndex = 3;
            this.btn_end.Text = ">>";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(215, 573);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(37, 29);
            this.btn_left.TabIndex = 2;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(271, 573);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(37, 29);
            this.btn_right.TabIndex = 1;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // pcb_image
            // 
            this.pcb_image.Location = new System.Drawing.Point(6, 36);
            this.pcb_image.Name = "pcb_image";
            this.pcb_image.Size = new System.Drawing.Size(520, 520);
            this.pcb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_image.TabIndex = 0;
            this.pcb_image.TabStop = false;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(589, 48);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(50, 20);
            this.lbl_count.TabIndex = 2;
            this.lbl_count.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(678, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // btn_tag
            // 
            this.btn_tag.Location = new System.Drawing.Point(606, 378);
            this.btn_tag.Name = "btn_tag";
            this.btn_tag.Size = new System.Drawing.Size(94, 29);
            this.btn_tag.TabIndex = 4;
            this.btn_tag.Text = "Add tag";
            this.btn_tag.UseVisualStyleBackColor = true;
            // 
            // grb_source
            // 
            this.grb_source.Controls.Add(this.lbl_source_path);
            this.grb_source.Controls.Add(this.btn_source);
            this.grb_source.Location = new System.Drawing.Point(589, 103);
            this.grb_source.Name = "grb_source";
            this.grb_source.Size = new System.Drawing.Size(316, 125);
            this.grb_source.TabIndex = 5;
            this.grb_source.TabStop = false;
            this.grb_source.Text = "Source path";
            // 
            // lbl_source_path
            // 
            this.lbl_source_path.AutoSize = true;
            this.lbl_source_path.Location = new System.Drawing.Point(17, 44);
            this.lbl_source_path.Name = "lbl_source_path";
            this.lbl_source_path.Size = new System.Drawing.Size(50, 20);
            this.lbl_source_path.TabIndex = 1;
            this.lbl_source_path.Text = "label1";
            // 
            // btn_source
            // 
            this.btn_source.Location = new System.Drawing.Point(17, 90);
            this.btn_source.Name = "btn_source";
            this.btn_source.Size = new System.Drawing.Size(94, 29);
            this.btn_source.TabIndex = 0;
            this.btn_source.Text = "Change";
            this.btn_source.UseVisualStyleBackColor = true;
            this.btn_source.Click += new System.EventHandler(this.btn_source_Click);
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Location = new System.Drawing.Point(606, 334);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(35, 20);
            this.lbl_tag.TabIndex = 6;
            this.lbl_tag.Text = "Tag:";
            // 
            // trb_time
            // 
            this.trb_time.Location = new System.Drawing.Point(606, 494);
            this.trb_time.Maximum = 5;
            this.trb_time.Name = "trb_time";
            this.trb_time.Size = new System.Drawing.Size(243, 56);
            this.trb_time.TabIndex = 7;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(606, 443);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(172, 20);
            this.lbl_time.TabIndex = 8;
            this.lbl_time.Text = "Allowed time difference:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 704);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.trb_time);
            this.Controls.Add(this.lbl_tag);
            this.Controls.Add(this.grb_source);
            this.Controls.Add(this.btn_tag);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.grb_preview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Media Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grb_preview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_image)).EndInit();
            this.grb_source.ResumeLayout(false);
            this.grb_source.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox grb_preview;
        public System.Windows.Forms.PictureBox pcb_image;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_tag;
        private System.Windows.Forms.GroupBox grb_source;
        private System.Windows.Forms.Button btn_source;
        private System.Windows.Forms.Label lbl_source_path;
        public System.Windows.Forms.Label lbl_count;
        public System.Windows.Forms.Button btn_start;
        public System.Windows.Forms.Button btn_end;
        public System.Windows.Forms.Button btn_left;
        public System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Label lbl_tag;
        private System.Windows.Forms.TrackBar trb_time;
        private System.Windows.Forms.Label lbl_time;
    }
}

