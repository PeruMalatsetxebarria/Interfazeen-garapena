namespace Ariketa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_nan_Click(object sender, EventArgs e)
        {

        }

        private void label_izena_Click(object sender, EventArgs e)
        {

        }

        private void label_abizena_Click(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void label_bezeroa_Click(object sender, EventArgs e)
        {

        }

        private void label_kategoria_Click(object sender, EventArgs e)
        {

        }

        private void label_soldata_Click(object sender, EventArgs e)
        {

        }

        private void label_segurtasun_soziala_Click(object sender, EventArgs e)
        {

        }

        private void textBox_nan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_izena_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_abizena_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_soldata_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox_segurtasun_soziala_TextChanged(object sender, EventArgs e)
        {

        }

        private void mota_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton_kontaktua_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_bezeroa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_langilea_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void comboBox_kategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void langilea_Click(object sender, EventArgs e)
        {

        }

        private void button_gorde_Click(object sender, EventArgs e)
        {
            if(radioButton_kontaktua.Checked)
                {
                    KontaktuaSortu();
                }
            else
                {
                    if(radioButton_bezeroa.Checked)
                    {
                        BezeroaSortu();
                    }
                    else
                        {
                            LangileaSortu();
                        }
                }
        }

        private void KontaktuaSortu()
        {
            try
            {
                Kontaktua kontaktua = new Kontaktua();
                kontaktua.Nan = textBox_nan.Text;
                kontaktua.Izena = textBox_izena.Text;
                kontaktua.Abizena = textBox_abizena.Text;
                kontaktua.Emaila = textBox_email.Text;
                kontaktua.Gorde();
            }
            catch
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BezeroaSortu()
        {
            Bezeroa bezeroa = new Bezeroa();
            bezeroa.Nan = textBox_nan.Text;
            bezeroa.Izena = textBox_izena.Text;
            bezeroa.Abizena = textBox_abizena.Text;
            bezeroa.Emaila = textBox_email.Text;
            bezeroa.Kategoria = comboBox_kategoria.Text
            bezeroa.Gorde();
        }

        private void LangileaSortu()
        {
            Langilea langilea = new Langilea();
            langilea.Nan = textBox_nan.Text;
            langilea.Izena = textBox_izena.Text;
            langilea.Abizena = textBox_abizena.Text;
            langilea.Emaila = textBox_email.Text;

            langilea.Gorde();
        }

        private void button_irten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}