namespace Kalkulagailua
{
    public partial class Form1 : Form
    {
        Kalkulagailua kalkulagailua = new Kalkulagailua();
        public Form1()
        {
            InitializeComponent();
        }

        private bool Balioak() //private void ek ez du ezer itzuliko, bool-ek ordea booleano bat itzuliko digu
        {
            bool errorea = false;
            try
            {
                kalkulagailua.Zenbaki1 = float.Parse(txtZenbaki1.Text);
                kalkulagailua.Zenbaki2 = float.Parse(txtZenbaki2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea gertatu da: " + ex.Message);
                //Application.Exit();
                errorea = true;
            }
            return errorea;
        }

        private void txtZenbaki1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtZenbaki2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Hasieratu()
        {
            txtZenbaki1.Text = "";
            txtZenbaki2.Text = "";
            txtZenbaki1.Focus();
        }

        /*private void btnGehi_Click(object sender, EventArgs e)
        {
            MessageBox.Show((float.Parse(txtZenbaki1.Text) + float.Parse(txtZenbaki2.Text)).ToString());
        }

        private void btnBider_Click(object sender, EventArgs e)
        {
            MessageBox.Show((float.Parse(txtZenbaki1.Text) * float.Parse(txtZenbaki2.Text)).ToString());
        }

        private void btnZati_Click(object sender, EventArgs e)
        {
            MessageBox.Show((float.Parse(txtZenbaki1.Text) / float.Parse(txtZenbaki2.Text)).ToString());
        }

        private void btnKen_Click(object sender, EventArgs e)
        {
            MessageBox.Show((float.Parse(txtZenbaki1.Text) - float.Parse(txtZenbaki2.Text)).ToString());
        }*/

        private void btnGehi_Click(object sender, EventArgs e)
        {
            //Kalkulagailua kalkulagailua = new Kalkulagailua(float.Parse(txtZenbaki1.Text),float.Parse(txtZenbaki2.Text)); goian jarri dugunez iada ez da behar
            //Balioak();
            if (!Balioak())
            {
                MessageBox.Show(kalkulagailua.Gehiketa().ToString("0.00")); //"0.00" zenbakiaren formatua da, zenbaki osoa bi hamartarrekin
                Hasieratu();
            }
        }
        private void btnKen_Click(object sender, EventArgs e)
        {
            if (!Balioak())
            {
                MessageBox.Show(kalkulagailua.Kenketa().ToString("0.00"));
                Hasieratu();
            }
        }
        private void btnBider_Click(object sender, EventArgs e)
        {
            if (!Balioak())
            {
                MessageBox.Show(kalkulagailua.Biderketa().ToString("0.00"));
                Hasieratu();
            }
        }
        private void btnZati_Click(object sender, EventArgs e)
        {
            if (!Balioak())
            {
                MessageBox.Show(kalkulagailua.Zatiketa().ToString("0.00"));
                Hasieratu();
            }
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtZenbaki1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
            && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
            && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
            && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (txtZenbaki1.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (txtZenbaki1.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }

        private void txtZenbaki2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
            && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
            && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
            && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (txtZenbaki2.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (txtZenbaki2.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }
    }
}