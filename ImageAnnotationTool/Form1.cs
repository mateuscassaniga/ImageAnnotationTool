using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAnnotationTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var node = treeView1.Nodes.Add("C:\\pasta\\imagens");
            for (int i = 0; i < 10; i++)
            {
                node.Nodes.Add("Image_00" + i + ".png");
            }
        }
    }
}
