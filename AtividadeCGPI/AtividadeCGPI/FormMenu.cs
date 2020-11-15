using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadeCGPI
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            FormGraph form = new FormGraph();
            form.ShowDialog();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            FormImageProcessing form = new FormImageProcessing();
            form.ShowDialog();
        }
    }
}
