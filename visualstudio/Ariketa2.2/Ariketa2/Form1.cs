namespace Ariketa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Zenbakiak zenbakiak = new Zenbakiak();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            this.lblZenbakia.Text = "Zenbakia 1";
            this.txtZenb.Text = "";
            zenbakiak.zenb = 0;
            zenbakiak.zenb2 = 0;
            zenbakiak.zenb3 = 0;
            zenbakiak.zenb4 = 0;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            switch (this.lblZenbakia.Text.ToLower())
            {
                case "zenbakia 1":
                    try {
                        zenbakiak.zenb = float.Parse(this.txtZenb.Text);
                        this.lblZenbakia.Text = "Zenbakia 2";
                        this.txtZenb.Text = "";
                        this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message); }

                    break;
                case "zenbakia 2":
                    try { 
                    zenbakiak.zenb2 = float.Parse(this.txtZenb.Text);
                    this.lblZenbakia.Text = "Zenbakia 3";
                    this.txtZenb.Text = "";
                    this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message); }

                    break;
                case "zenbakia 3":
                    try { 
                    zenbakiak.zenb3 = float.Parse(this.txtZenb.Text);
                    this.lblZenbakia.Text = "Zenbakia 4";
                    this.txtZenb.Text = "";
                    this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message); }

                    break;
                case "zenbakia 4":
                    try { 
                    zenbakiak.zenb4 = float.Parse(this.txtZenb.Text);
                    this.txtZenb.Text = "";
                    this.lblZenbakia.Text = "Eragiketa";
                    this.txtZenb.Text = "(" + zenbakiak.zenb + " + " + "(2 x " + zenbakiak.zenb2 + ") +" + "(3 x " + zenbakiak.zenb3 + ") + " + "(4 x " + zenbakiak.zenb4 + ")) / 4 = " + zenbakiak.eragiketa();
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