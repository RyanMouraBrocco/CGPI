namespace AtividadeCGPI
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMapping = new System.Windows.Forms.Button();
            this.btnComon = new System.Windows.Forms.Button();
            this.linkColor = new System.Windows.Forms.LinkLabel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnMapping);
            this.panel1.Controls.Add(this.btnComon);
            this.panel1.Controls.Add(this.linkColor);
            this.panel1.Controls.Add(this.panelColor);
            this.panel1.Controls.Add(this.btnPoint);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Location = new System.Drawing.Point(10, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnMapping
            // 
            this.btnMapping.Location = new System.Drawing.Point(604, 16);
            this.btnMapping.Name = "btnMapping";
            this.btnMapping.Size = new System.Drawing.Size(95, 46);
            this.btnMapping.TabIndex = 0;
            this.btnMapping.Text = "Mapeamento";
            this.btnMapping.UseVisualStyleBackColor = true;
            this.btnMapping.Click += new System.EventHandler(this.btnMapping_Click);
            // 
            // btnComon
            // 
            this.btnComon.Location = new System.Drawing.Point(491, 16);
            this.btnComon.Name = "btnComon";
            this.btnComon.Size = new System.Drawing.Size(95, 46);
            this.btnComon.TabIndex = 0;
            this.btnComon.Text = "Imagens Complexas";
            this.btnComon.UseVisualStyleBackColor = true;
            this.btnComon.Click += new System.EventHandler(this.btnCommon_Click);
            // 
            // linkColor
            // 
            this.linkColor.AutoSize = true;
            this.linkColor.Location = new System.Drawing.Point(774, 44);
            this.linkColor.Name = "linkColor";
            this.linkColor.Size = new System.Drawing.Size(26, 15);
            this.linkColor.TabIndex = 2;
            this.linkColor.TabStop = true;
            this.linkColor.Text = "Cor";
            this.linkColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkColor_LinkClicked);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(775, 16);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(25, 21);
            this.panelColor.TabIndex = 1;
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(33, 16);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(95, 46);
            this.btnPoint.TabIndex = 0;
            this.btnPoint.Text = "Ponto";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(375, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 46);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(259, 16);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(95, 46);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Circulo";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(145, 16);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(95, 46);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Reta";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(928, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 354);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 732);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.LinkLabel linkColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnComon;
        private System.Windows.Forms.Button btnMapping;
        private System.Windows.Forms.Panel panel2;
    }
}

