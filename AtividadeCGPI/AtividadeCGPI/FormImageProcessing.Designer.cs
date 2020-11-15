namespace AtividadeCGPI
{
    partial class FormImageProcessing
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnGrayScale = new System.Windows.Forms.Button();
            this.btnBlackWhite = new System.Windows.Forms.Button();
            this.btnSepiaTone = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHistogram = new System.Windows.Forms.DataGridView();
            this.btnUpdateHistogram = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(338, 41);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(629, 297);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(849, 12);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(118, 23);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "Carregar Imagem";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnGrayScale
            // 
            this.btnGrayScale.Location = new System.Drawing.Point(26, 22);
            this.btnGrayScale.Name = "btnGrayScale";
            this.btnGrayScale.Size = new System.Drawing.Size(75, 38);
            this.btnGrayScale.TabIndex = 2;
            this.btnGrayScale.Text = "Cinza";
            this.btnGrayScale.UseVisualStyleBackColor = true;
            this.btnGrayScale.Click += new System.EventHandler(this.btnGrayScale_Click);
            // 
            // btnBlackWhite
            // 
            this.btnBlackWhite.Location = new System.Drawing.Point(116, 22);
            this.btnBlackWhite.Name = "btnBlackWhite";
            this.btnBlackWhite.Size = new System.Drawing.Size(75, 38);
            this.btnBlackWhite.TabIndex = 3;
            this.btnBlackWhite.Text = "Preto e Branco";
            this.btnBlackWhite.UseVisualStyleBackColor = true;
            this.btnBlackWhite.Click += new System.EventHandler(this.btnBlackWhite_Click);
            // 
            // btnSepiaTone
            // 
            this.btnSepiaTone.Location = new System.Drawing.Point(26, 75);
            this.btnSepiaTone.Name = "btnSepiaTone";
            this.btnSepiaTone.Size = new System.Drawing.Size(75, 38);
            this.btnSepiaTone.TabIndex = 4;
            this.btnSepiaTone.Text = "Tom sépia";
            this.btnSepiaTone.UseVisualStyleBackColor = true;
            this.btnSepiaTone.Click += new System.EventHandler(this.btnSepiaTone_Click);
            // 
            // Color
            // 
            this.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Color.HeaderText = "Cor";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Valor";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgHistogram
            // 
            this.dgHistogram.AllowUserToAddRows = false;
            this.dgHistogram.AllowUserToDeleteRows = false;
            this.dgHistogram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistogram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Color,
            this.Quantity});
            this.dgHistogram.Location = new System.Drawing.Point(12, 188);
            this.dgHistogram.Name = "dgHistogram";
            this.dgHistogram.ReadOnly = true;
            this.dgHistogram.RowHeadersVisible = false;
            this.dgHistogram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHistogram.Size = new System.Drawing.Size(310, 150);
            this.dgHistogram.TabIndex = 5;
            this.dgHistogram.Text = "dataGridView1";
            // 
            // btnUpdateHistogram
            // 
            this.btnUpdateHistogram.Location = new System.Drawing.Point(247, 159);
            this.btnUpdateHistogram.Name = "btnUpdateHistogram";
            this.btnUpdateHistogram.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateHistogram.TabIndex = 6;
            this.btnUpdateHistogram.Text = "Atualizar";
            this.btnUpdateHistogram.UseVisualStyleBackColor = true;
            this.btnUpdateHistogram.Click += new System.EventHandler(this.btnUpdateHistogram_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(116, 75);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(75, 38);
            this.btnNegative.TabIndex = 7;
            this.btnNegative.Text = "Negativo";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(338, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "Restaurar";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(863, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 390);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnUpdateHistogram);
            this.Controls.Add(this.dgHistogram);
            this.Controls.Add(this.btnSepiaTone);
            this.Controls.Add(this.btnBlackWhite);
            this.Controls.Add(this.btnGrayScale);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormImageProcessing";
            this.Text = "FormImageProcessing";
            this.Load += new System.EventHandler(this.FormImageProcessing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnGrayScale;
        private System.Windows.Forms.Button btnBlackWhite;
        private System.Windows.Forms.Button btnSepiaTone;
        private System.Windows.Forms.DataGridView dgHistogram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnUpdateHistogram;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}