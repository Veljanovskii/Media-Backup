using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Media_Backup;
using System.IO;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace Media_Backup
{
    public partial class MainForm : Form
    {
        public DataClass proxy { get; set; }        

        public MainForm()
        {
            InitializeComponent();
            proxy = new DataClass();
            Core.Initialize();            
            clb_media.CheckOnClick = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            /*Choosing which device, if there are multiple*/
            ChooseDeviceForm form = new ChooseDeviceForm(this, proxy.GetDevices());
            var res = form.ShowDialog();
            if (res == DialogResult.Cancel)
                Environment.Exit(0);

            this.Text = proxy.MediaDevice.FriendlyName;

            /*Trackbar settings*/
            trb_time.Minimum = 2;
            trb_time.Maximum = 120;
            trb_time.TickFrequency = 10;

            /*Accessing data from the device*/
            proxy.TransferMedia();

            /*Fill checklist*/
            proxy.FillMediaList(this);

            /*Media preview*/            
            proxy.MediaPreview(this);
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (proxy.MediaIndex < proxy.NewFiles.Count - 1)
            {
                proxy.MediaIndex++;
                proxy.MediaPreview(this);
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (proxy.MediaIndex > 0)
            {
                proxy.MediaIndex--;
                proxy.MediaPreview(this);
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            proxy.MediaIndex = proxy.NewFiles.Count - 1;
            proxy.MediaPreview(this);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            proxy.MediaIndex = 0;
            proxy.MediaPreview(this);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            /*VLC Media Controls*/
            switch (e.KeyCode)
            {                
                case Keys.Add:
                    if (proxy.IsPlaying == true)
                    {
                        proxy._mp.Pause();
                        proxy.IsPlaying = false;
                    }
                    else
                    {
                        proxy._mp.Play();
                        proxy.IsPlaying = true;
                    }
                    break;
            }
        }

        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            /*Prevents focus change*/
            var keys = new[] { Keys.Add };
            if (keys.Contains(e.KeyData))
                e.IsInputKey = true;
        }

        private void trb_time_Scroll(object sender, EventArgs e)
        {
            lbl_trackbar.Text = trb_time.Value + " minutes";
            proxy.MinutesRange = trb_time.Value;
            proxy.FindInRange(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (proxy.videoView != null) 
                proxy.videoView.Dispose();
            if (proxy._mp != null)
                proxy._mp.Dispose();
            if (proxy._libVLC != null)
                proxy._libVLC.Dispose();
        }

        private void btn_tag_Click(object sender, EventArgs e)
        {
            if (txt_tag.Text != "")
            {
                if (proxy.TagIndexes.Count == 0)
                {
                    MessageBox.Show("No media were selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                proxy.MoveMedia(this);
                txt_tag.Text = "";
            }
            else
            {
                MessageBox.Show("No valid tag was entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void clb_media_SelectedIndexChanged(object sender, EventArgs e)
        {
            proxy.TagIndexes.Clear();
            proxy.TagIndexes = clb_media.CheckedIndices.Cast<int>().ToList();
            lbl_selected.Text = proxy.TagIndexes.Count + " media selected";

            ////TODO
            //clb_media.SetItemColor(1, Color.Red);

            //ImprovedCheckedListBox lmao = new ImprovedCheckedListBox();
            //lmao.SetItemColor
        }

        private void clb_media_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = clb_media.IndexFromPoint(e.Location);
                {
                    if (index != clb_media.SelectedIndex)
                    {
                        proxy.MediaIndex = index;
                        proxy.MediaPreview(this);
                    }
                }
            }
        }

        private void chb_checkall_CheckedChanged(object sender, EventArgs e)
        {
            proxy.TagIndexes.Clear();

            if (chb_checkall.Checked)
            {
                for (int i = 0; i < clb_media.Items.Count; i++)
                {
                    clb_media.SetItemChecked(i, true);
                    proxy.TagIndexes.Add(i);
                }
            }
            else
            {
                for (int i = 0; i < clb_media.Items.Count; i++)
                {
                    clb_media.SetItemChecked(i, false);
                }
                proxy.TagIndexes.Clear();
            }

            lbl_selected.Text = proxy.TagIndexes.Count + " media selected";
        }
    }

    public class ImprovedCheckedListBox : CheckedListBox
    {
        private Color highlight = SystemColors.Highlight;
        private IDictionary<int, Color> colorList;

        public ImprovedCheckedListBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;

            this.colorList = new Dictionary<int, Color>();
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (this.Font.Height < 0)
                this.Font = Control.DefaultFont;

            if (e.Index < 0)
                return;

            if (this.Items.Count == 0)
            {
                return;
            }

            Rectangle rect = base.GetItemRectangle(e.Index);

            Color highlight;
            if ((this.SelectionMode != SelectionMode.None) && ((e.State & DrawItemState.Selected) == DrawItemState.Selected))
                highlight = this.highlight;
            else
                highlight = this.BackColor;

            using (Brush brush = new SolidBrush(highlight))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            Color textColor = Color.Empty;
            if (colorList.Count > 0)
            {
                if ((this.SelectionMode != SelectionMode.None) && ((e.State & DrawItemState.Selected) != DrawItemState.Selected))
                {
                    textColor = GetItemColor(e.Index);

                    if (textColor.IsEmpty)
                    {
                        textColor = base.ForeColor;
                    }
                }
                else
                {
                    textColor = GetItemColor(e.Index);
                }
            }

            string text = this.Items[e.Index].ToString();

            TextRenderer.DrawText(e.Graphics, text, this.Font, rect, textColor, TextFormatFlags.GlyphOverhangPadding);
        }

        public void SetItemColor(int index, Color color)
        {
            colorList.Add(index, color);
        }

        public Color GetItemColor(int index)
        {
            if (colorList.ContainsKey(index))
            {
                return colorList[index];
            }
            else
            {
                return base.ForeColor;
            }
        }
    }
}
