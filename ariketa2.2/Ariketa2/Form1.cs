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








        List<Ariketa2> zenbakiak = new List<Ariketa2>();





        /*public static double eragiketa(List<ariketa2> objektuak)
        {

        }*/









    private void Garbitu_Click(object sender, EventArgs e)
        {
            this.textua.Text = "Zenbakia 1";
            this.txtZenb.Text = "";
            zenbakiak.Clear();
        }

        private void Hurrengoa_Click(object sender, EventArgs e)
        {
            switch (this.textua.Text.ToLower())
            {
                case "zenbakia 1":
                    try {
                        zenbakiak[0].Zenbakia = float.Parse(this.txtZenb.Text);
                        this.textua.Text = "Zenbakia 2";
                        this.txtZenb.Text = "";
                        this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("zenbaki bat sartu" + ex.Message); }

                    break;
                case "zenbakia 2":
                    try {
                        zenbakiak[1].Zenbakia = float.Parse(this.txtZenb.Text);
                    this.textua.Text = "Zenbakia 3";
                    this.txtZenb.Text = "";
                    this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message); }

                    break;
                case "zenbakia 3":
                    try {
                        zenbakiak[2].Zenbakia = float.Parse(this.txtZenb.Text);
                    this.textua.Text = "Zenbakia 4";
                    this.txtZenb.Text = "";
                    this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message); }

                    break;
                case "zenbakia 4":
                    try {
                        zenbakiak[3].Zenbakia = float.Parse(this.txtZenb.Text);
                    this.txtZenb.Text = "";
                    this.textua.Text = "Eragiketa";
                    this.txtZenb.Text = "(" + zenbakiak[0].Zenbakia + " + " + "(2 x " + zenbakiak[1].Zenbakia + ") +" + "(3 x " + zenbakiak[2].Zenbakia + ") + " + "(4 x " + zenbakiak[3].Zenbakia + ")) / 4 = " + "zenbakiak.eragiketa()";
                    }
                    catch (Exception ex)
                    { MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message); }

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