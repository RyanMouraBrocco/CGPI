namespace AtividadeCGPI
{
    partial class FormMenu
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
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(12, 12);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(289, 139);
            this.btnGraph.TabIndex = 0;
            this.btnGraph.Text = "Figuras gráficas";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(322, 12);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(289, 139);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "Processamento de imagem";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 166);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnGraph);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnImage;
    }
}