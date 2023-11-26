namespace TGDI_Vorbereiter
{
    partial class BasisN
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.prüfenBtn = new System.Windows.Forms.Button();
            this.zahlensystemeMatrix = new System.Windows.Forms.DataGridView();
            this.Bin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oktal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dezimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hexadezimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generierenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zahlensystemeMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // prüfenBtn
            // 
            this.prüfenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prüfenBtn.Location = new System.Drawing.Point(349, 270);
            this.prüfenBtn.Name = "prüfenBtn";
            this.prüfenBtn.Size = new System.Drawing.Size(136, 30);
            this.prüfenBtn.TabIndex = 0;
            this.prüfenBtn.Text = "Prüfen";
            this.prüfenBtn.UseVisualStyleBackColor = true;
            this.prüfenBtn.Click += new System.EventHandler(this.prüfenBtn_Click);
            // 
            // zahlensystemeMatrix
            // 
            this.zahlensystemeMatrix.AllowUserToAddRows = false;
            this.zahlensystemeMatrix.AllowUserToDeleteRows = false;
            this.zahlensystemeMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zahlensystemeMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bin,
            this.Oktal,
            this.Dezimal,
            this.Hexadezimal});
            this.zahlensystemeMatrix.Location = new System.Drawing.Point(41, 29);
            this.zahlensystemeMatrix.Name = "zahlensystemeMatrix";
            this.zahlensystemeMatrix.Size = new System.Drawing.Size(444, 227);
            this.zahlensystemeMatrix.TabIndex = 1;
            // 
            // Bin
            // 
            this.Bin.HeaderText = "Binär";
            this.Bin.Name = "Bin";
            // 
            // Oktal
            // 
            this.Oktal.HeaderText = "Oktal";
            this.Oktal.Name = "Oktal";
            // 
            // Dezimal
            // 
            this.Dezimal.HeaderText = "Dezimal";
            this.Dezimal.Name = "Dezimal";
            // 
            // Hexadezimal
            // 
            this.Hexadezimal.HeaderText = "Hexadezimal";
            this.Hexadezimal.Name = "Hexadezimal";
            // 
            // generierenBtn
            // 
            this.generierenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generierenBtn.Location = new System.Drawing.Point(41, 270);
            this.generierenBtn.Name = "generierenBtn";
            this.generierenBtn.Size = new System.Drawing.Size(163, 30);
            this.generierenBtn.TabIndex = 2;
            this.generierenBtn.Text = "Neu generieren";
            this.generierenBtn.UseVisualStyleBackColor = true;
            this.generierenBtn.Click += new System.EventHandler(this.generierenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 321);
            this.Controls.Add(this.generierenBtn);
            this.Controls.Add(this.zahlensystemeMatrix);
            this.Controls.Add(this.prüfenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Zahlen in andere Basen umrechnen";
            ((System.ComponentModel.ISupportInitialize)(this.zahlensystemeMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prüfenBtn;
        private System.Windows.Forms.DataGridView zahlensystemeMatrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oktal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dezimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hexadezimal;
        private System.Windows.Forms.Button generierenBtn;
    }
}

