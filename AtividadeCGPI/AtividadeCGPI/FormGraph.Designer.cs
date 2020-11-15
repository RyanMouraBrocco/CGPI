namespace AtividadeCGPI
{
    partial class FormGraph
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
            this.btnExporter = new System.Windows.Forms.Button();
            this.btnImporter = new System.Windows.Forms.Button();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMapping = new System.Windows.Forms.Button();
            this.btnComon = new System.Windows.Forms.Button();
            this.linkColor = new System.Windows.Forms.LinkLabel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.mapppedPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnExporter);
            this.panel1.Controls.Add(this.btnImporter);
            this.panel1.Controls.Add(this.btnRedraw);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnMapping);
            this.panel1.Controls.Add(this.btnComon);
            this.panel1.Controls.Add(this.linkColor);
            this.panel1.Controls.Add(this.panelColor);
            this.panel1.Controls.Add(this.btnPoint);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnExporter
            // 
            this.btnExporter.Location = new System.Drawing.Point(1077, 16);
            this.btnExporter.Name = "btnExporter";
            this.btnExporter.Size = new System.Drawing.Size(106, 43);
            this.btnExporter.TabIndex = 3;
            this.btnExporter.Text = "Exportar";
            this.btnExporter.UseVisualStyleBackColor = true;
            this.btnExporter.Click += new System.EventHandler(this.btnExporter_Click);
            // 
            // btnImporter
            // 
            this.btnImporter.Location = new System.Drawing.Point(965, 16);
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.Size = new System.Drawing.Size(106, 43);
            this.btnImporter.TabIndex = 3;
            this.btnImporter.Text = "Importar";
            this.btnImporter.UseVisualStyleBackColor = true;
            this.btnImporter.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // btnRedraw
            // 
            this.btnRedraw.Enabled = false;
            this.btnRedraw.Location = new System.Drawing.Point(480, 16);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(95, 46);
            this.btnRedraw.TabIndex = 0;
            this.btnRedraw.Text = "Redesenhar";
            this.btnRedraw.UseVisualStyleBackColor = true;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(372, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 46);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Apagar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMapping
            // 
            this.btnMapping.Location = new System.Drawing.Point(803, 16);
            this.btnMapping.Name = "btnMapping";
            this.btnMapping.Size = new System.Drawing.Size(95, 46);
            this.btnMapping.TabIndex = 0;
            this.btnMapping.Text = "Mapeamento";
            this.btnMapping.UseVisualStyleBackColor = true;
            this.btnMapping.Click += new System.EventHandler(this.btnMapping_Click);
            // 
            // btnComon
            // 
            this.btnComon.Location = new System.Drawing.Point(695, 16);
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
            this.linkColor.Location = new System.Drawing.Point(917, 44);
            this.linkColor.Name = "linkColor";
            this.linkColor.Size = new System.Drawing.Size(26, 15);
            this.linkColor.TabIndex = 2;
            this.linkColor.TabStop = true;
            this.linkColor.Text = "Cor";
            this.linkColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkColor_LinkClicked);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(918, 16);
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
            this.btnClear.Location = new System.Drawing.Point(589, 16);
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
            // mapppedPanel
            // 
            this.mapppedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mapppedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapppedPanel.Location = new System.Drawing.Point(928, 366);
            this.mapppedPanel.Name = "mapppedPanel";
            this.mapppedPanel.Size = new System.Drawing.Size(657, 354);
            this.mapppedPanel.TabIndex = 1;
            this.mapppedPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "Circulo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(803, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 46);
            this.button3.TabIndex = 0;
            this.button3.Text = "Mapeamento";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(690, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 46);
            this.button4.TabIndex = 0;
            this.button4.Text = "Imagens Complexas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(917, 44);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(26, 15);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cor";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(918, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 21);
            this.panel3.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 46);
            this.button5.TabIndex = 0;
            this.button5.Text = "Ponto";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(589, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 46);
            this.button6.TabIndex = 0;
            this.button6.Text = "Limpar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(259, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 46);
            this.button7.TabIndex = 0;
            this.button7.Text = "Circulo";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(145, 16);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 46);
            this.button8.TabIndex = 0;
            this.button8.Text = "Reta";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(372, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 46);
            this.button9.TabIndex = 0;
            this.button9.Text = "Circulo";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 732);
            this.Controls.Add(this.mapppedPanel);
            this.Controls.Add(this.panel1);
            this.Name = "FormGraph";
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
        private System.Windows.Forms.Panel mapppedPanel;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnImporter;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnExporter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

