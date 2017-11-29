namespace _007_MassCalculator
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
            this.components = new System.ComponentModel.Container();
            this.dimension1 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dimension2 = new System.Windows.Forms.TextBox();
            this.dimension3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.massBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dimension1
            // 
            this.dimension1.Location = new System.Drawing.Point(64, 23);
            this.dimension1.Name = "dimension1";
            this.dimension1.Size = new System.Drawing.Size(100, 20);
            this.dimension1.TabIndex = 0;
            this.dimension1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dimension1.TextChanged += new System.EventHandler(this.dimension1_TextChanged);
            this.dimension1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dimension1_KeyDown);
            // 
            // dimension2
            // 
            this.dimension2.Location = new System.Drawing.Point(64, 49);
            this.dimension2.Name = "dimension2";
            this.dimension2.Size = new System.Drawing.Size(100, 20);
            this.dimension2.TabIndex = 1;
            this.dimension2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dimension2.TextChanged += new System.EventHandler(this.dimension2_TextChanged);
            this.dimension2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dimension2_KeyDown);
            // 
            // dimension3
            // 
            this.dimension3.Location = new System.Drawing.Point(64, 75);
            this.dimension3.Name = "dimension3";
            this.dimension3.Size = new System.Drawing.Size(100, 20);
            this.dimension3.TabIndex = 2;
            this.dimension3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dimension3.TextChanged += new System.EventHandler(this.dimension3_TextChanged);
            this.dimension3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dimension3_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Länge 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Länge 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Länge 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dichte";
            // 
            // dropdown
            // 
            this.dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Items.AddRange(new object[] {
            "Stahl",
            "Aluminium"});
            this.dropdown.Location = new System.Drawing.Point(64, 101);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(121, 21);
            this.dropdown.TabIndex = 7;
            this.dropdown.SelectedIndexChanged += new System.EventHandler(this.dropdown_SelectedIndexChanged);
            this.dropdown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dropdown_KeyDown);
            // 
            // massBox
            // 
            this.massBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.massBox.Location = new System.Drawing.Point(64, 125);
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(100, 23);
            this.massBox.TabIndex = 8;
            this.massBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Masse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Input überprüfen!";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 192);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.massBox);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimension3);
            this.Controls.Add(this.dimension2);
            this.Controls.Add(this.dimension1);
            this.Name = "Form1";
            this.Text = "Masse Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dimension1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox dimension2;
        private System.Windows.Forms.TextBox dimension3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.Label massBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

