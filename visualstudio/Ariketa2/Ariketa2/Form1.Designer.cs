namespace Ariketa2
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
            this.testua = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Hurrengoa = new System.Windows.Forms.Button();
            this.Garbitu = new System.Windows.Forms.Button();
            this.Irten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testua
            // 
            this.testua.AutoSize = true;
            this.testua.Location = new System.Drawing.Point(167, 65);
            this.testua.Name = "testua";
            this.testua.Size = new System.Drawing.Size(38, 15);
            this.testua.TabIndex = 0;
            this.testua.Text = "label1";
            this.testua.Click += new System.EventHandler(this.testua_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(378, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Hurrengoa
            // 
            this.Hurrengoa.Location = new System.Drawing.Point(176, 156);
            this.Hurrengoa.Name = "Hurrengoa";
            this.Hurrengoa.Size = new System.Drawing.Size(75, 23);
            this.Hurrengoa.TabIndex = 2;
            this.Hurrengoa.Text = "Hurrengoa";
            this.Hurrengoa.UseVisualStyleBackColor = true;
            this.Hurrengoa.Click += new System.EventHandler(this.Hurrengoa_Click);
            // 
            // Garbitu
            // 
            this.Garbitu.Location = new System.Drawing.Point(337, 165);
            this.Garbitu.Name = "Garbitu";
            this.Garbitu.Size = new System.Drawing.Size(75, 23);
            this.Garbitu.TabIndex = 3;
            this.Garbitu.Text = "Garbitu";
            this.Garbitu.UseVisualStyleBackColor = true;
            this.Garbitu.Click += new System.EventHandler(this.Garbitu_Click);
            // 
            // Irten
            // 
            this.Irten.Location = new System.Drawing.Point(509, 179);
            this.Irten.Name = "Irten";
            this.Irten.Size = new System.Drawing.Size(75, 23);
            this.Irten.TabIndex = 4;
            this.Irten.Text = "Irten";
            this.Irten.UseVisualStyleBackColor = true;
            this.Irten.Click += new System.EventHandler(this.Irten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Irten);
            this.Controls.Add(this.Garbitu);
            this.Controls.Add(this.Hurrengoa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.testua);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label testua;
        private TextBox textBox1;
        private Button Hurrengoa;
        private Button Garbitu;
        private Button Irten;
    }
}