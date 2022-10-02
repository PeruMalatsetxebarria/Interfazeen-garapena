namespace Ariketa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Irten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }








        List<Zenbakiak> zenbakiak = new List<Zenbakiak>();





        /*public static double eragiketa(List<ariketa2> objektuak)
        {

        }*/









    private void Garbitu_Click(object sender, EventArgs e)
        {
            this.textua.Text = "Zenbakia 1";
            this.txtZenb.Text = "";
            zenbakiak.Clear();
            this.txtZenb.Focus();
        }

        private void Hurrengoa_Click(object sender, EventArgs e)
        {
            switch (this.textua.Text.ToLower())
            {
                case "zenbakia 1":
                    zenbakiak.Add(new Zenbakiak());
                    try {
                        zenbakiak[0].zenbakiak = float.Parse(this.txtZenb.Text);
                        this.textua.Text = "Zenbakia 2";
                        this.txtZenb.Text = "";
                        this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Sartu zenbaki bat. Errorea: " + ex.Message); 
                        this.txtZenb.Focus();
                    }

                    break;
                case "zenbakia 2":
                    zenbakiak.Add(new Zenbakiak());
                    try {
                        zenbakiak[1].zenbakiak = float.Parse(this.txtZenb.Text);
                    this.textua.Text = "Zenbakia 3";
                    this.txtZenb.Text = "";
                    this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Sartu zenbaki bat. Errorea: " + ex.Message);
                        this.txtZenb.Focus();
                    }

                    break;
                case "zenbakia 3":
                    zenbakiak.Add(new Zenbakiak());
                    try {
                        zenbakiak[2].zenbakiak = float.Parse(this.txtZenb.Text);
                    this.textua.Text = "Zenbakia 4";
                    this.txtZenb.Text = "";
                    this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Sartu zenbaki bat. Errorea: " + ex.Message);
                        this.txtZenb.Focus();
                    }

                    break;
                case "zenbakia 4":
                    zenbakiak.Add(new Zenbakiak());
                    try {
                        zenbakiak[3].zenbakiak = float.Parse(this.txtZenb.Text);
                    this.txtZenb.Text = "";
                    this.textua.Text = "Eragiketa";
                    this.txtZenb.Text = "(" + zenbakiak[0].zenbakiak + " + " + "(2 x " + zenbakiak[1].zenbakiak + ") +" + "(3 x " + zenbakiak[2].zenbakiak + ") + " + "(4 x " + zenbakiak[3].zenbakiak + ")) / 4 = " + Zenbakiak.eragiketa(zenbakiak);
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Sartu zenbaki bat. Errorea: " + ex.Message);
                        this.txtZenb.Focus();
                    }

                    break;
            }
        }

        private void txtZenb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)
                && e.KeyChar != Convert.ToChar(Keys.Back)
                && e.KeyChar != Convert.ToChar(Keys.Delete)
                && e.KeyChar != Convert.ToChar(","))
            {
                e.Handled = true;
                return;
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(","))
                {
                    if (txtZenb.Text.IndexOf(",") >= 0)
                    {
                        e.Handled = true;
                        return;
                    }
                    else
                    {
                        if (txtZenb.Text.Length == 0)
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