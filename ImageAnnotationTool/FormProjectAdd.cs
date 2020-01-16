using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAnnotationTool
{
    public partial class FormProjectAdd : Form
    {
        public FormProjectAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            var result = folder.ShowDialog();
            if (result == DialogResult.OK)
                txbImagesPath.Text = folder.SelectedPath;
        }

        private void txbImagesPath_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbImagesPath.Text.Trim()) && Directory.Exists(txbImagesPath.Text.Trim()))
            {
                var filter = new string[] { ".bmp", ".jpg", ".jpeg", ".png", ".gif", ".tiff", ".svg" };
                var files = Directory.GetFiles(txbImagesPath.Text.Trim(), "*.*", SearchOption.TopDirectoryOnly).Where(s=> filter.Any(s.ToLower().EndsWith)).ToList();
                lblImagesFound.Text = $"{files.Count} images found in this folder.";
                lblImagesFound.Visible = true;
            }
            else
            {
                lblImagesFound.Visible = false;
            }
        }
    }
}
