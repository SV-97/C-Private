namespace _003_FunctionPlotterImplementation
{
    partial class Form1
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
            this.Txt_m = new System.Windows.Forms.TextBox();
            this.Txt_t = new System.Windows.Forms.TextBox();
            this.Lbl_m = new System.Windows.Forms.Label();
            this.Lbl_t = new System.Windows.Forms.Label();
            this.Btn_Done = new System.Windows.Forms.Button();
            this.plotBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.plotBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_m
            // 
            this.Txt_m.Location = new System.Drawing.Point(34, 9);
            this.Txt_m.Name = "Txt_m";
            this.Txt_m.Size = new System.Drawing.Size(35, 20);
            this.Txt_m.TabIndex = 0;
            // 
            // Txt_t
            // 
            this.Txt_t.Location = new System.Drawing.Point(34, 35);
            this.Txt_t.Name = "Txt_t";
            this.Txt_t.Size = new System.Drawing.Size(35, 20);
            this.Txt_t.TabIndex = 1;
            // 
            // Lbl_m
            // 
            this.Lbl_m.AutoSize = true;
            this.Lbl_m.Location = new System.Drawing.Point(13, 12);
            this.Lbl_m.Name = "Lbl_m";
            this.Lbl_m.Size = new System.Drawing.Size(15, 13);
            this.Lbl_m.TabIndex = 2;
            this.Lbl_m.Text = "m";
            // 
            // Lbl_t
            // 
            this.Lbl_t.AutoSize = true;
            this.Lbl_t.Location = new System.Drawing.Point(18, 35);
            this.Lbl_t.Name = "Lbl_t";
            this.Lbl_t.Size = new System.Drawing.Size(10, 13);
            this.Lbl_t.TabIndex = 3;
            this.Lbl_t.Text = "t";
            // 
            // Btn_Done
            // 
            this.Btn_Done.Location = new System.Drawing.Point(12, 227);
            this.Btn_Done.Name = "Btn_Done";
            this.Btn_Done.Size = new System.Drawing.Size(75, 23);
            this.Btn_Done.TabIndex = 4;
            this.Btn_Done.Text = "Done";
            this.Btn_Done.UseVisualStyleBackColor = true;
            // 
            // plotBox
            // 
            this.plotBox.Location = new System.Drawing.Point(172, 9);
            this.plotBox.Name = "plotBox";
            this.plotBox.Size = new System.Drawing.Size(100, 50);
            this.plotBox.TabIndex = 5;
            this.plotBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.plotBox);
            this.Controls.Add(this.Btn_Done);
            this.Controls.Add(this.Lbl_t);
            this.Controls.Add(this.Lbl_m);
            this.Controls.Add(this.Txt_t);
            this.Controls.Add(this.Txt_m);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.plotBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_m;
        private System.Windows.Forms.TextBox Txt_t;
        private System.Windows.Forms.Label Lbl_m;
        private System.Windows.Forms.Label Lbl_t;
        private System.Windows.Forms.Button Btn_Done;
        private System.Windows.Forms.PictureBox plotBox;
    }
}

