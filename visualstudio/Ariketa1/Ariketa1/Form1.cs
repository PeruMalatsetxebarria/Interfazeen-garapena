namespace Ariketa1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
            Esaldi2.Enabled = false;
            Esaldi3.Enabled = false;
            Esaldi4.Enabled = false;
            Esaldi5.Enabled = false;
            Lotu.Enabled = false;
        }

        String esaldia = "";
        int balioa;

        private void Gorde_esaldia()
        {
            esaldia = richTextBox1.Text;
        }

        String esaldi1;
        String esaldi2;
        String esaldi3;
        String esaldi4;
        String esaldi5;

        public void Gorde(String esaldi, int balio)
		{
			switch (balio)
			{
				case 1: esaldi1 = esaldi;
					break;

				case 2: esaldi2 = esaldi;
					break;

                case 3: esaldi3 = esaldi;
                    break;

                case 4: esaldi4 = esaldi;
                    break;

                case 5: esaldi5 = esaldi;
                    break;

                case 6: MessageBox.Show(esaldi1+esaldi2);
                    break;
            }
		}

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Esaldi1_Click(object sender, EventArgs e)
		{
            Esaldi1.Enabled = false;
            Esaldi2.Enabled = true;

            Garbitu_Click();

            Gorde_esaldia();
			balioa = 1;

			Gorde(esaldia, balioa);
		}

		private void Esaldi2_Click(object sender, EventArgs e)
		{
            Esaldi2.Enabled = false;
            Esaldi3.Enabled = true;

            Garbitu_Click();

            Gorde_esaldia();
            balioa = 2;

            Gorde(esaldia, balioa);
        }

		private void Esaldi3_Click(object sender, EventArgs e)
		{
            Esaldi3.Enabled = false;
            Esaldi4.Enabled = true;

            Garbitu_Click();

            Gorde_esaldia();
            balioa = 3;

            Gorde(esaldia, balioa);
        }

		private void Esaldi4_Click(object sender, EventArgs e)
		{
            Esaldi4.Enabled = false;
            Esaldi5.Enabled = true;

            Garbitu_Click();

            Gorde_esaldia();
            balioa = 4;

            Gorde(esaldia, balioa);
        }

		private void Esaldi5_Click(object sender, EventArgs e)
		{
            Esaldi5.Enabled = false;
            Lotu.Enabled = true;

            Garbitu_Click();

            Gorde_esaldia();
            balioa = 5;

            Gorde(esaldia, balioa);
        }

		private void Lotu_Click(object sender, EventArgs e)
		{
            Lotu.Enabled = false;

            Garbitu_Click();

            //Gorde_esaldia();
            balioa = 6;

            Gorde("", balioa);
        }

		private void Garbitu_Click()
		{
            richTextBox1.Text = "aaaaaaaaaaaaa";
            richTextBox1.Focus();
        }

		private void Itxi_Click(object sender, EventArgs e)
		{
            Application.Exit();
        }
	}
}