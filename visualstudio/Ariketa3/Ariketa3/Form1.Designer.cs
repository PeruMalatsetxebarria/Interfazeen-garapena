namespace Ariketa3
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
            this.textBox_nan = new System.Windows.Forms.TextBox();
            this.textBox_izena = new System.Windows.Forms.TextBox();
            this.textBox_abizena = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_nan = new System.Windows.Forms.Label();
            this.label_izena = new System.Windows.Forms.Label();
            this.label_abizena = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.mota = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_kontaktua = new System.Windows.Forms.RadioButton();
            this.radioButton_bezeroa = new System.Windows.Forms.RadioButton();
            this.radioButton_langilea = new System.Windows.Forms.RadioButton();
            this.label_bezeroa = new System.Windows.Forms.Label();
            this.langilea = new System.Windows.Forms.Label();
            this.label_soldata = new System.Windows.Forms.Label();
            this.textBox_soldata = new System.Windows.Forms.TextBox();
            this.textBox_segurtasun_soziala = new System.Windows.Forms.TextBox();
            this.label_segurtasun_soziala = new System.Windows.Forms.Label();
            this.label_kategoria = new System.Windows.Forms.Label();
            this.comboBox_kategoria = new System.Windows.Forms.ComboBox();
            this.button_gorde = new System.Windows.Forms.Button();
            this.button_irten = new System.Windows.Forms.Button();
            this.mota.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_nan
            // 
            this.textBox_nan.Location = new System.Drawing.Point(141, 6);
            this.textBox_nan.Name = "textBox_nan";
            this.textBox_nan.Size = new System.Drawing.Size(100, 23);
            this.textBox_nan.TabIndex = 0;
            this.textBox_nan.TextChanged += new System.EventHandler(this.textBox_nan_TextChanged);
            // 
            // textBox_izena
            // 
            this.textBox_izena.Location = new System.Drawing.Point(141, 34);
            this.textBox_izena.Name = "textBox_izena";
            this.textBox_izena.Size = new System.Drawing.Size(100, 23);
            this.textBox_izena.TabIndex = 1;
            this.textBox_izena.TextChanged += new System.EventHandler(this.textBox_izena_TextChanged);
            // 
            // textBox_abizena
            // 
            this.textBox_abizena.Location = new System.Drawing.Point(141, 60);
            this.textBox_abizena.Name = "textBox_abizena";
            this.textBox_abizena.Size = new System.Drawing.Size(100, 23);
            this.textBox_abizena.TabIndex = 2;
            this.textBox_abizena.TextChanged += new System.EventHandler(this.textBox_abizena_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(141, 87);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 23);
            this.textBox_email.TabIndex = 3;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // label_nan
            // 
            this.label_nan.AutoSize = true;
            this.label_nan.Location = new System.Drawing.Point(31, 14);
            this.label_nan.Name = "label_nan";
            this.label_nan.Size = new System.Drawing.Size(32, 15);
            this.label_nan.TabIndex = 4;
            this.label_nan.Text = "Nan:";
            this.label_nan.Click += new System.EventHandler(this.label_nan_Click);
            // 
            // label_izena
            // 
            this.label_izena.AutoSize = true;
            this.label_izena.Location = new System.Drawing.Point(31, 42);
            this.label_izena.Name = "label_izena";
            this.label_izena.Size = new System.Drawing.Size(37, 15);
            this.label_izena.TabIndex = 5;
            this.label_izena.Text = "Izena:";
            this.label_izena.Click += new System.EventHandler(this.label_izena_Click);
            // 
            // label_abizena
            // 
            this.label_abizena.AutoSize = true;
            this.label_abizena.Location = new System.Drawing.Point(31, 68);
            this.label_abizena.Name = "label_abizena";
            this.label_abizena.Size = new System.Drawing.Size(52, 15);
            this.label_abizena.TabIndex = 6;
            this.label_abizena.Text = "Abizena:";
            this.label_abizena.Click += new System.EventHandler(this.label_abizena_Click);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(31, 95);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(39, 15);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "Email:";
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // mota
            // 
            this.mota.Controls.Add(this.radioButton_langilea);
            this.mota.Controls.Add(this.radioButton_bezeroa);
            this.mota.Controls.Add(this.radioButton_kontaktua);
            this.mota.Location = new System.Drawing.Point(410, 12);
            this.mota.Name = "mota";
            this.mota.Size = new System.Drawing.Size(200, 100);
            this.mota.TabIndex = 8;
            this.mota.TabStop = false;
            this.mota.Text = "Mota:";
            this.mota.Enter += new System.EventHandler(this.mota_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_kategoria);
            this.panel1.Controls.Add(this.label_kategoria);
            this.panel1.Location = new System.Drawing.Point(31, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_segurtasun_soziala);
            this.panel2.Controls.Add(this.label_segurtasun_soziala);
            this.panel2.Controls.Add(this.textBox_soldata);
            this.panel2.Controls.Add(this.label_soldata);
            this.panel2.Location = new System.Drawing.Point(410, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 10;
            // 
            // radioButton_kontaktua
            // 
            this.radioButton_kontaktua.AutoSize = true;
            this.radioButton_kontaktua.Location = new System.Drawing.Point(10, 21);
            this.radioButton_kontaktua.Name = "radioButton_kontaktua";
            this.radioButton_kontaktua.Size = new System.Drawing.Size(79, 19);
            this.radioButton_kontaktua.TabIndex = 0;
            this.radioButton_kontaktua.TabStop = true;
            this.radioButton_kontaktua.Text = "Kontaktua";
            this.radioButton_kontaktua.UseVisualStyleBackColor = true;
            this.radioButton_kontaktua.CheckedChanged += new System.EventHandler(this.radioButton_kontaktua_CheckedChanged);
            // 
            // radioButton_bezeroa
            // 
            this.radioButton_bezeroa.AutoSize = true;
            this.radioButton_bezeroa.Location = new System.Drawing.Point(10, 41);
            this.radioButton_bezeroa.Name = "radioButton_bezeroa";
            this.radioButton_bezeroa.Size = new System.Drawing.Size(66, 19);
            this.radioButton_bezeroa.TabIndex = 1;
            this.radioButton_bezeroa.TabStop = true;
            this.radioButton_bezeroa.Text = "Bezeroa";
            this.radioButton_bezeroa.UseVisualStyleBackColor = true;
            this.radioButton_bezeroa.CheckedChanged += new System.EventHandler(this.radioButton_bezeroa_CheckedChanged);
            // 
            // radioButton_langilea
            // 
            this.radioButton_langilea.AutoSize = true;
            this.radioButton_langilea.Location = new System.Drawing.Point(10, 66);
            this.radioButton_langilea.Name = "radioButton_langilea";
            this.radioButton_langilea.Size = new System.Drawing.Size(69, 19);
            this.radioButton_langilea.TabIndex = 2;
            this.radioButton_langilea.TabStop = true;
            this.radioButton_langilea.Text = "Langilea";
            this.radioButton_langilea.UseVisualStyleBackColor = true;
            this.radioButton_langilea.CheckedChanged += new System.EventHandler(this.radioButton_langilea_CheckedChanged);
            // 
            // label_bezeroa
            // 
            this.label_bezeroa.AutoSize = true;
            this.label_bezeroa.Location = new System.Drawing.Point(31, 224);
            this.label_bezeroa.Name = "label_bezeroa";
            this.label_bezeroa.Size = new System.Drawing.Size(48, 15);
            this.label_bezeroa.TabIndex = 11;
            this.label_bezeroa.Text = "Bezeroa";
            this.label_bezeroa.Click += new System.EventHandler(this.label_bezeroa_Click);
            // 
            // langilea
            // 
            this.langilea.AutoSize = true;
            this.langilea.Location = new System.Drawing.Point(420, 224);
            this.langilea.Name = "langilea";
            this.langilea.Size = new System.Drawing.Size(51, 15);
            this.langilea.TabIndex = 12;
            this.langilea.Text = "Langilea";
            this.langilea.Click += new System.EventHandler(this.langilea_Click);
            // 
            // label_soldata
            // 
            this.label_soldata.AutoSize = true;
            this.label_soldata.Location = new System.Drawing.Point(10, 13);
            this.label_soldata.Name = "label_soldata";
            this.label_soldata.Size = new System.Drawing.Size(49, 15);
            this.label_soldata.TabIndex = 5;
            this.label_soldata.Text = "Soldata:";
            this.label_soldata.Click += new System.EventHandler(this.label_soldata_Click);
            // 
            // textBox_soldata
            // 
            this.textBox_soldata.Location = new System.Drawing.Point(76, 10);
            this.textBox_soldata.Name = "textBox_soldata";
            this.textBox_soldata.Size = new System.Drawing.Size(100, 23);
            this.textBox_soldata.TabIndex = 6;
            this.textBox_soldata.TextChanged += new System.EventHandler(this.textBox_soldata_TextChanged);
            // 
            // textBox_segurtasun_soziala
            // 
            this.textBox_segurtasun_soziala.Location = new System.Drawing.Point(10, 63);
            this.textBox_segurtasun_soziala.Name = "textBox_segurtasun_soziala";
            this.textBox_segurtasun_soziala.Size = new System.Drawing.Size(166, 23);
            this.textBox_segurtasun_soziala.TabIndex = 8;
            this.textBox_segurtasun_soziala.TextChanged += new System.EventHandler(this.textBox_segurtasun_soziala_TextChanged);
            // 
            // label_segurtasun_soziala
            // 
            this.label_segurtasun_soziala.AutoSize = true;
            this.label_segurtasun_soziala.Location = new System.Drawing.Point(10, 45);
            this.label_segurtasun_soziala.Name = "label_segurtasun_soziala";
            this.label_segurtasun_soziala.Size = new System.Drawing.Size(108, 15);
            this.label_segurtasun_soziala.TabIndex = 7;
            this.label_segurtasun_soziala.Text = "Segurtasun Soziala:";
            this.label_segurtasun_soziala.Click += new System.EventHandler(this.label_segurtasun_soziala_Click);
            // 
            // label_kategoria
            // 
            this.label_kategoria.AutoSize = true;
            this.label_kategoria.Location = new System.Drawing.Point(17, 13);
            this.label_kategoria.Name = "label_kategoria";
            this.label_kategoria.Size = new System.Drawing.Size(60, 15);
            this.label_kategoria.TabIndex = 6;
            this.label_kategoria.Text = "Kategoria:";
            this.label_kategoria.Click += new System.EventHandler(this.label_kategoria_Click);
            // 
            // comboBox_kategoria
            // 
            this.comboBox_kategoria.FormattingEnabled = true;
            this.comboBox_kategoria.Location = new System.Drawing.Point(32, 46);
            this.comboBox_kategoria.Name = "comboBox_kategoria";
            this.comboBox_kategoria.Size = new System.Drawing.Size(121, 23);
            this.comboBox_kategoria.TabIndex = 7;
            this.comboBox_kategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_kategoria_SelectedIndexChanged);
            // 
            // button_gorde
            // 
            this.button_gorde.Location = new System.Drawing.Point(197, 400);
            this.button_gorde.Name = "button_gorde";
            this.button_gorde.Size = new System.Drawing.Size(117, 23);
            this.button_gorde.TabIndex = 13;
            this.button_gorde.Text = "Gorde";
            this.button_gorde.UseVisualStyleBackColor = true;
            this.button_gorde.Click += new System.EventHandler(this.button_gorde_Click);
            // 
            // button_irten
            // 
            this.button_irten.Location = new System.Drawing.Point(408, 400);
            this.button_irten.Name = "button_irten";
            this.button_irten.Size = new System.Drawing.Size(117, 23);
            this.button_irten.TabIndex = 14;
            this.button_irten.Text = "Irten";
            this.button_irten.UseVisualStyleBackColor = true;
            this.button_irten.Click += new System.EventHandler(this.button_irten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_irten);
            this.Controls.Add(this.button_gorde);
            this.Controls.Add(this.langilea);
            this.Controls.Add(this.label_bezeroa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mota);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_abizena);
            this.Controls.Add(this.label_izena);
            this.Controls.Add(this.label_nan);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_abizena);
            this.Controls.Add(this.textBox_izena);
            this.Controls.Add(this.textBox_nan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mota.ResumeLayout(false);
            this.mota.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_nan;
        private TextBox textBox_izena;
        private TextBox textBox_abizena;
        private TextBox textBox_email;
        private Label label_nan;
        private Label label_izena;
        private Label label_abizena;
        private Label label_email;
        private GroupBox mota;
        private RadioButton radioButton_langilea;
        private RadioButton radioButton_bezeroa;
        private RadioButton radioButton_kontaktua;
        private Panel panel1;
        private ComboBox comboBox_kategoria;
        private Label label_kategoria;
        private Panel panel2;
        private TextBox textBox_segurtasun_soziala;
        private Label label_segurtasun_soziala;
        private TextBox textBox_soldata;
        private Label label_soldata;
        private Label label_bezeroa;
        private Label langilea;
        private Button button_gorde;
        private Button button_irten;
    }
}