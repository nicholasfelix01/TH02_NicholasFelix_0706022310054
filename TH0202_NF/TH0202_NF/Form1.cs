namespace TH0202_NF
{
    public partial class Form1 : Form
    {

        string[] word = new string[5];

        bool salahKem = false;
        bool salahJum = false;
        bool salahAng = false;

        public Form1()
        {
            InitializeComponent();
            int askdnas = 0;
            foreach (var item in word)
            {
                word[askdnas++] = "";
            }
        }

        private void tb_01_TextChanged(object sender, EventArgs e)
        {
            word[0] = tb_01.Text;
        }

        private void tb_02_TextChanged(object sender, EventArgs e)
        {
            word[1] = tb_02.Text;
        }

        private void tb_03_TextChanged(object sender, EventArgs e)
        {
            word[2] = tb_03.Text;
        }

        private void tb_04_TextChanged(object sender, EventArgs e)
        {
            word[3] = tb_04.Text;
        }

        private void tb_05_TextChanged(object sender, EventArgs e)
        {
            word[4] = tb_05.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salahKem = false;
            salahJum = false;
            salahAng = false;
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = word[i].ToUpper();
            }
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if (word[i] == word[j])
                        {
                            salahKem = true;
                        }
                    }
                }
            }
            foreach (string kata in word)
            {
                if (kata.Length != 5)
                {
                    salahJum = true;
                }
            }
            string test = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0;i < 5;i++)
            {
                int check = 0;              
                foreach (char c in word[i])
                {
                    if (test.Contains(c))
                    {
                        check++;
                    }
                }
                if (check != 5)
                {
                    salahAng = true;
                }
            }

            if (salahKem)
            {
                MessageBox.Show("Kata Ada Yang Kembar.");
            }
            if (salahJum)
            {
                MessageBox.Show("Jumlah Kata Ada Yang Salah.");
            }
            if (salahAng)
            {
                MessageBox.Show("Kata memiliki Angka.");
            }
            if (salahKem == false && salahJum == false && salahAng == false)
            {
                Form2 formdua = new Form2(word);
                formdua.ShowDialog();
                this.Close();
            }
            salahJum = false;
            salahKem = false;
        }
    }
}
