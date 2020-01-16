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
    public partial class FormProjects : Form
    {
        public FormProjects()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormProjectAdd f = new FormProjectAdd();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
