namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;
        private void btnSonraki_Click(object sender, EventArgs e)
        {

            btnA.Enabled = true;
            btnB.Enabled = true;

            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;
            lblSoru2.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "cumhuriyet ne zaman ilan edildi";

                btnA.Text = "1923";
                btnB.Text = "1922";
                btnC.Text = "1912";
                btnD.Text = "1944";
                label1.Text = "1923";


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "hangi il ege b�lgesinde bulunmaz";

                btnA.Text = "ayd�n";
                btnB.Text = "manisa";
                btnC.Text = "istanbul";
                btnD.Text = "izmir";
                label1.Text = "istanbul";


            }
            if (soruno == 3)
            {
                richTextBox1.Text = "son ku�lar hangi yazara aittir";

                btnA.Text = "Sait Faik";
                btnB.Text = "cemal s�reyya";
                btnC.Text = "Atilla ilhan";
                btnD.Text = "Re�at Nuri";
                label1.Text = "Sait Faik";
                btnSonraki.Text = "Sonuclar";



            }
            if (soruno == 4) {
                btnA.Enabled = false;
                btnB.Enabled = false;

                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("dogru:" + dogru + "\n" + "yanl��" + yanlis);
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;

            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;



            label2.Text = btnA.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();

                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;

            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label2.Text = btnB.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;

            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label2.Text = btnC.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;


            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

            }

        }

        private void btnD_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;

            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label2.Text = btnD.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

            }
        }

    }
}


