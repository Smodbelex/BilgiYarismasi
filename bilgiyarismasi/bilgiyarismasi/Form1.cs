namespace bilgiyarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno ;

        string Cevap = string.Empty;
        string cevapp;

        private void Kontrol(string pSoru)
        {

            if (cevapp == pSoru)
            {
                switch (soruno)
                {
                    case 1:
                        label1.Visible = true;
                        label1.BackColor = Color.Green;
                        break;
                    case 2:
                        label2.Visible = true;
                        label2.BackColor = Color.Green;
                        break;
                    case 3:
                        label3.Visible = true;
                        label3.BackColor = Color.Green;
                        break;
                    case 4:
                        label4.Visible = true;
                        label4.BackColor = Color.Green;
                        break;
                    case 5:
                        label5.Visible = true;
                        label5.BackColor = Color.Green;
                        break;
                }
            }
            else
            {
                switch (soruno)
                {
                    case 1:
                        label1.Visible = true;
                        label1.BackColor = Color.Red;
                        btnnext.Enabled = false;
                        break;
                    case 2:
                        label2.Visible = true;
                        label2.BackColor = Color.Red;
                        btnnext.Enabled = false;
                        break;
                    case 3:
                        label3.Visible = true;
                        label3.BackColor = Color.Red;
                        btnnext.Enabled = false;
                        break;
                    case 4:
                        label4.Visible = true;
                        label4.BackColor = Color.Red;
                        btnnext.Enabled = false;
                        break;
                    case 5:
                        label5.Visible = true;
                        label5.BackColor = Color.Red;
                        btnnext.Enabled = false;
                        break;
                }
            }
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            soruno++;
            lblno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "T�rkiyenin ba� kenti neresidir?";
                btnA.Text = "Ankara";
                btnB.Text = "�zmir";
                btnC.Text = "�stanbul";
                btnD.Text = "Adana";
                cevapp = "Ankara";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi oyunda top kullan�lmaz?";
                btnA.Text = "Futbol";
                btnB.Text = "Dama";
                btnC.Text = "Tenis";
                btnD.Text = "Basketbol";
                cevapp = "Dama";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Be�genin i� a��lar toplam� ka�t�r?";
                btnA.Text = "180";
                btnB.Text = "360";
                btnC.Text = "540";
                btnD.Text = "720";
                cevapp = "540";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Araba Sevdas� roman� kimin eseridir?";
                btnA.Text = "Ya�ar Kemal";
                btnB.Text = "Recaizade Mahmud Ekrem";
                btnC.Text = "O�uz Atay";
                btnD.Text = "Orhan Pamuk";
                cevapp = "Recaizade Mahmud Ekrem";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Satran�ta en k�sa mat ka� halede yap�l�r?";
                btnA.Text = "4";
                btnB.Text = "3";
                btnC.Text = "2";
                btnD.Text = "1";
                cevapp = "2";
            }
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            Cevap = btnA.Text;
            Kontrol(Cevap);
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            Cevap = btnB.Text;
            Kontrol(Cevap);
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            Cevap = btnC.Text;
            Kontrol(Cevap);
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            Cevap = btnD.Text;
            Kontrol(Cevap);
        }
    }
}