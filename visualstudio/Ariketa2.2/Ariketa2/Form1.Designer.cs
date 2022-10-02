namespace Ariketa2
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

        
       
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
            this.textua = new System.Windows.Forms.Label();
            this.txtZenb = new System.Windows.Forms.TextBox();
            this.Hurrengoa_klik = new System.Windows.Forms.Button();
            this.Garbitu_klik = new System.Windows.Forms.Button();
            this.Irten_klik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textua
            // 
            this.textua.AutoSize = true;
            this.textua.BackColor = System.Drawing.SystemColors.Control;
            this.textua.CausesValidation = false;
            this.textua.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textua.Location = new System.Drawing.Point(59, 78);
            this.textua.Name = "textua";
            this.textua.Size = new System.Drawing.Size(155, 32);
            this.textua.TabIndex = 0;
            this.textua.Text = "Zenbakia 1";
            // 
            // txtZenb
            // 
            this.txtZenb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtZenb.Location = new System.Drawing.Point(232, 85);
            this.txtZenb.Name = "txtZenb";
            this.txtZenb.Size = new System.Drawing.Size(414, 25);
            this.txtZenb.TabIndex = 1;
            this.txtZenb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZenb_KeyPress);
            // 
            // Hurrengoa_klik
            // 
            this.Hurrengoa_klik.Location = new System.Drawing.Point(69, 148);
            this.Hurrengoa_klik.Name = "Hurrengoa_klik";
            this.Hurrengoa_klik.Size = new System.Drawing.Size(75, 23);
            this.Hurrengoa_klik.TabIndex = 2;
            this.Hurrengoa_klik.Text = "Hurrengoa";
            this.Hurrengoa_klik.UseVisualStyleBackColor = true;
            this.Hurrengoa_klik.Click += new System.EventHandler(this.Hurrengoa_Click);
            // 
            // Garbitu_klik
            // 
            this.Garbitu_klik.Location = new System.Drawing.Point(199, 148);
            this.Garbitu_klik.Name = "Garbitu_klik";
            this.Garbitu_klik.Size = new System.Drawing.Size(75, 23);
            this.Garbitu_klik.TabIndex = 3;
            this.Garbitu_klik.Text = "Garbitu";
            this.Garbitu_klik.UseVisualStyleBackColor = true;
            this.Garbitu_klik.Click += new System.EventHandler(this.Garbitu_Click);
            // 
            // Irten_klik
            // 
            this.Irten_klik.Location = new System.Drawing.Point(338, 148);
            this.Irten_klik.Name = "Irten_klik";
            this.Irten_klik.Size = new System.Drawing.Size(75, 23);
            this.Irten_klik.TabIndex = 4;
            this.Irten_klik.Text = "Irten";
            this.Irten_klik.UseVisualStyleBackColor = true;
            this.Irten_klik.Click += new System.EventHandler(this.Irten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 208);
            this.Controls.Add(this.Irten_klik);
            this.Controls.Add(this.Garbitu_klik);
            this.Controls.Add(this.Hurrengoa_klik);
            this.Controls.Add(this.txtZenb);
            this.Controls.Add(this.textua);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textua;
        private TextBox txtZenb;
        private Button Hurrengoa_klik;
        private Button Garbitu_klik;
        private Button Irten_klik;
    }
}