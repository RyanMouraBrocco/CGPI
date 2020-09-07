namespace AtividadeCGPI
{
    partial class FormComplexGraph
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDivisionQuantity = new System.Windows.Forms.Label();
            this.mskDivisionQuantity = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkSecondColor = new System.Windows.Forms.LinkLabel();
            this.linkFirstColor = new System.Windows.Forms.LinkLabel();
            this.mskLength = new System.Windows.Forms.MaskedTextBox();
            this.mskLengthFromCenter = new System.Windows.Forms.MaskedTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelSecondColor = new System.Windows.Forms.Panel();
            this.panelFirstColor = new System.Windows.Forms.Panel();
            this.btnLines = new System.Windows.Forms.Button();
            this.btnCommon = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lblDivisionQuantity);
            this.panel1.Controls.Add(this.mskDivisionQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkSecondColor);
            this.panel1.Controls.Add(this.linkFirstColor);
            this.panel1.Controls.Add(this.mskLength);
            this.panel1.Controls.Add(this.mskLengthFromCenter);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.panelSecondColor);
            this.panel1.Controls.Add(this.panelFirstColor);
            this.panel1.Controls.Add(this.btnLines);
            this.panel1.Controls.Add(this.btnCommon);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 177);
            this.panel1.TabIndex = 0;
            // 
            // lblDivisionQuantity
            // 
            this.lblDivisionQuantity.AutoSize = true;
            this.lblDivisionQuantity.Location = new System.Drawing.Point(197, 125);
            this.lblDivisionQuantity.Name = "lblDivisionQuantity";
            this.lblDivisionQuantity.Size = new System.Drawing.Size(112, 15);
            this.lblDivisionQuantity.TabIndex = 4;
            this.lblDivisionQuantity.Text = "Número de divisões";
            // 
            // mskDivisionQuantity
            // 
            this.mskDivisionQuantity.Location = new System.Drawing.Point(197, 143);
            this.mskDivisionQuantity.Mask = "00000";
            this.mskDivisionQuantity.Name = "mskDivisionQuantity";
            this.mskDivisionQuantity.Size = new System.Drawing.Size(35, 23);
            this.mskDivisionQuantity.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Espessura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tamanho";
            // 
            // linkSecondColor
            // 
            this.linkSecondColor.AutoSize = true;
            this.linkSecondColor.Location = new System.Drawing.Point(95, 125);
            this.linkSecondColor.Name = "linkSecondColor";
            this.linkSecondColor.Size = new System.Drawing.Size(86, 15);
            this.linkSecondColor.TabIndex = 3;
            this.linkSecondColor.TabStop = true;
            this.linkSecondColor.Text = "Cor secundária";
            this.linkSecondColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSecondColor_LinkClicked);
            // 
            // linkFirstColor
            // 
            this.linkFirstColor.AutoSize = true;
            this.linkFirstColor.Location = new System.Drawing.Point(13, 125);
            this.linkFirstColor.Name = "linkFirstColor";
            this.linkFirstColor.Size = new System.Drawing.Size(75, 15);
            this.linkFirstColor.TabIndex = 3;
            this.linkFirstColor.TabStop = true;
            this.linkFirstColor.Text = "Cor principal";
            this.linkFirstColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFirstColor_LinkClicked);
            // 
            // mskLength
            // 
            this.mskLength.Location = new System.Drawing.Point(261, 95);
            this.mskLength.Mask = "00000";
            this.mskLength.Name = "mskLength";
            this.mskLength.Size = new System.Drawing.Size(35, 23);
            this.mskLength.TabIndex = 2;
            // 
            // mskLengthFromCenter
            // 
            this.mskLengthFromCenter.Location = new System.Drawing.Point(197, 95);
            this.mskLengthFromCenter.Mask = "00000";
            this.mskLengthFromCenter.Name = "mskLengthFromCenter";
            this.mskLengthFromCenter.Size = new System.Drawing.Size(39, 23);
            this.mskLengthFromCenter.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(249, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 48);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelSecondColor
            // 
            this.panelSecondColor.Location = new System.Drawing.Point(122, 84);
            this.panelSecondColor.Name = "panelSecondColor";
            this.panelSecondColor.Size = new System.Drawing.Size(35, 34);
            this.panelSecondColor.TabIndex = 1;
            // 
            // panelFirstColor
            // 
            this.panelFirstColor.Location = new System.Drawing.Point(34, 84);
            this.panelFirstColor.Name = "panelFirstColor";
            this.panelFirstColor.Size = new System.Drawing.Size(35, 34);
            this.panelFirstColor.TabIndex = 1;
            // 
            // btnLines
            // 
            this.btnLines.Location = new System.Drawing.Point(129, 14);
            this.btnLines.Name = "btnLines";
            this.btnLines.Size = new System.Drawing.Size(114, 48);
            this.btnLines.TabIndex = 0;
            this.btnLines.Text = "Figura de linhas";
            this.btnLines.UseVisualStyleBackColor = true;
            this.btnLines.Click += new System.EventHandler(this.btnLines_Click);
            // 
            // btnCommon
            // 
            this.btnCommon.Location = new System.Drawing.Point(9, 14);
            this.btnCommon.Name = "btnCommon";
            this.btnCommon.Size = new System.Drawing.Size(114, 48);
            this.btnCommon.TabIndex = 0;
            this.btnCommon.Text = "Imagem Comum";
            this.btnCommon.UseVisualStyleBackColor = true;
            this.btnCommon.Click += new System.EventHandler(this.btnCommon_Click);
            // 
            // FormComplexGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 525);
            this.Controls.Add(this.panel1);
            this.Name = "FormComplexGraph";
            this.Text = "FormComplexGraph";
            this.Load += new System.EventHandler(this.FormComplexGraph_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormComplexGraph_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkSecondColor;
        private System.Windows.Forms.LinkLabel linkFirstColor;
        private System.Windows.Forms.MaskedTextBox mskLength;
        private System.Windows.Forms.MaskedTextBox mskLengthFromCenter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelSecondColor;
        private System.Windows.Forms.Panel panelFirstColor;
        private System.Windows.Forms.Button btnLines;
        private System.Windows.Forms.Button btnCommon;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblDivisionQuantity;
        private System.Windows.Forms.MaskedTextBox mskDivisionQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}