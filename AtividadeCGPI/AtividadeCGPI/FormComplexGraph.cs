using AtividadeCGPI.ComplexGraphic.CommonImage;
using AtividadeCGPI.ComplexGraphic.LinesFigure;
using AtividadeCGPI.Graphic.Point;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadeCGPI
{
    public partial class FormComplexGraph : Form
    {
        private Color firstColor;
        private Color secondColor;
        int state = 0;

        public FormComplexGraph()
        {
            InitializeComponent();
        }

        private void FormComplexGraph_Load(object sender, EventArgs e)
        {
            firstColor = Color.Black;
            secondColor = Color.Black;
            UpdatePanelColor();
            mskDivisionQuantity.Text = "2";
            mskLength.Text = "5";
            mskLengthFromCenter.Text = "100";
        }

        private void UpdatePanelColor()
        {
            panelFirstColor.BackColor = firstColor;
            panelSecondColor.BackColor = secondColor;
            lblDivisionQuantity.Visible = false;
            mskDivisionQuantity.Visible = false;
        }

        private void FormComplexGraph_MouseDown(object sender, MouseEventArgs e)
        {
            switch (state)
            {
                case 0:
                    CommonImageGraph commomImage = new CommonImageGraph(new PointGraph(e.X, e.Y), GetLength(), GetLengthFromCenter(), firstColor, secondColor);
                    commomImage.Draw(this);
                    break;
                case 1:
                    LinesFigureGraph linesFigure = new LinesFigureGraph(new PointGraph(e.X, e.Y), GetDivisionQuantity(), GetLength(), GetLengthFromCenter(), firstColor);
                    linesFigure.Draw(this);
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void linkFirstColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                firstColor = colorDialog1.Color;
                UpdatePanelColor();
            }
        }

        private void linkSecondColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                secondColor = colorDialog1.Color;
                UpdatePanelColor();
            }
        }

        private void btnCommon_Click(object sender, EventArgs e)
        {
            state = 0;
            lblDivisionQuantity.Visible = false;
            mskDivisionQuantity.Visible = false;
            panelSecondColor.Visible = true;
            linkSecondColor.Visible = true;
        }

        private void btnLines_Click(object sender, EventArgs e)
        {
            state = 1;
            lblDivisionQuantity.Visible = true;
            mskDivisionQuantity.Visible = true;
            panelSecondColor.Visible = false;
            linkSecondColor.Visible = false;
        }

        private int GetLength()
        {
            if (string.IsNullOrEmpty(mskLength.Text.Trim()) || int.Parse(mskLength.Text) == 0)
                return 1;

            return int.Parse(mskLength.Text);
        }

        private int GetLengthFromCenter()
        {
            if (string.IsNullOrEmpty(mskLengthFromCenter.Text.Trim()) || int.Parse(mskLengthFromCenter.Text) == 0)
                return 1;

            return int.Parse(mskLengthFromCenter.Text);
        }
        private int GetDivisionQuantity()
        {
            if (string.IsNullOrEmpty(mskDivisionQuantity.Text.Trim()) || int.Parse(mskDivisionQuantity.Text) == 0)
                return 1;

            return int.Parse(mskDivisionQuantity.Text);
        }
    }
}
