using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH0202_NF
{
    public partial class Form2 : Form
    {
        bool[] katabetul = new bool[5];
        char[] woword = new char[5];
        public Form2(string[] word)
        {
            InitializeComponent();
            Random random = new Random();
            int angks = random.Next(0, 5);
            string theWord = word[angks];
            label1.Text = theWord;
            int huhu = 0;
            foreach (char c in theWord)
            {
                woword[huhu] = c;
                huhu++;
            }
        }

        private void didweWIN()
        {
            int hoahao = 0;
            foreach (bool b in katabetul)
            {
                if (b)
                {
                    hoahao++;
                }
            }
            if (hoahao == 5)
            {
                MessageBox.Show("You Won.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'A')
                {
                    Controls[$"lbl_{i}"].Text = "A";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_A.BackColor = Color.Green;
                btn_A.Enabled = false;
            }
            else
            {
                btn_A.BackColor = Color.Red;
                btn_A.Enabled = false;
            }
            didweWIN();
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'B')
                {
                    Controls[$"lbl_{i}"].Text = "B";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_B.BackColor = Color.Green;
                btn_B.Enabled = false;
            }
            else
            {
                btn_B.BackColor = Color.Red;
                btn_B.Enabled = false;
            }
            didweWIN();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'C')
                {
                    Controls[$"lbl_{i}"].Text = "C";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_C.BackColor = Color.Green;
                btn_C.Enabled = false;
            }
            else
            {
                btn_C.BackColor = Color.Red;
                btn_C.Enabled = false;
            }
            didweWIN();
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'D')
                {
                    Controls[$"lbl_{i}"].Text = "D";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_D.BackColor = Color.Green;
                btn_D.Enabled = false;
            }
            else
            {
                btn_D.BackColor = Color.Red;
                btn_D.Enabled = false;
            }
            didweWIN();
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'E')
                {
                    Controls[$"lbl_{i}"].Text = "E";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_E.BackColor = Color.Green;
                btn_E.Enabled = false;
            }
            else
            {
                btn_E.BackColor = Color.Red;
                btn_E.Enabled = false;
            }
            didweWIN();
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'F')
                {
                    Controls[$"lbl_{i}"].Text = "F";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_F.BackColor = Color.Green;
                btn_F.Enabled = false;
            }
            else
            {
                btn_F.BackColor = Color.Red;
                btn_F.Enabled = false;
            }
            didweWIN();
        }

        private void btn_G_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'G')
                {
                    Controls[$"lbl_{i}"].Text = "G";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_G.BackColor = Color.Green;
                btn_G.Enabled = false;
            }
            else
            {
                btn_G.BackColor = Color.Red;
                btn_G.Enabled = false;
            }
            didweWIN();
        }

        private void btn_H_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'H')
                {
                    Controls[$"lbl_{i}"].Text = "H";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_H.BackColor = Color.Green;
                btn_H.Enabled = false;
            }
            else
            {
                btn_H.BackColor = Color.Red;
                btn_H.Enabled = false;
            }
            didweWIN();
        }

        private void btn_I_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'I')
                {
                    Controls[$"lbl_{i}"].Text = "I";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_I.BackColor = Color.Green;
                btn_I.Enabled = false;
            }
            else
            {
                btn_I.BackColor = Color.Red;
                btn_I.Enabled = false;
            }
            didweWIN();
        }

        private void btn_J_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'J')
                {
                    Controls[$"lbl_{i}"].Text = "J";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_J.BackColor = Color.Green;
                btn_J.Enabled = false;
            }
            else
            {
                btn_J.BackColor = Color.Red;
                btn_J.Enabled = false;
            }
            didweWIN();
        }

        private void btn_K_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'K')
                {
                    Controls[$"lbl_{i}"].Text = "K";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_K.BackColor = Color.Green;
                btn_K.Enabled = false;
            }
            else
            {
                btn_K.BackColor = Color.Red;
                btn_K.Enabled = false;
            }
            didweWIN();
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'L')
                {
                    Controls[$"lbl_{i}"].Text = "L";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_L.BackColor = Color.Green;
                btn_L.Enabled = false;
            }
            else
            {
                btn_L.BackColor = Color.Red;
                btn_L.Enabled = false;
            }
            didweWIN();
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'M')
                {
                    Controls[$"lbl_{i}"].Text = "M";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_M.BackColor = Color.Green;
                btn_M.Enabled = false;
            }
            else
            {
                btn_M.BackColor = Color.Red;
                btn_M.Enabled = false;
            }
            didweWIN();
        }

        private void btn_N_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'N')
                {
                    Controls[$"lbl_{i}"].Text = "N";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_N.BackColor = Color.Green;
                btn_N.Enabled = false;
            }
            else
            {
                btn_N.BackColor = Color.Red;
                btn_N.Enabled = false;
            }
            didweWIN();
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'O')
                {
                    Controls[$"lbl_{i}"].Text = "O";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_O.BackColor = Color.Green;
                btn_O.Enabled = false;
            }
            else
            {
                btn_O.BackColor = Color.Red;
                btn_O.Enabled = false;
            }
            didweWIN();
        }

        private void btn_P_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'P')
                {
                    Controls[$"lbl_{i}"].Text = "P";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_P.BackColor = Color.Green;
                btn_P.Enabled = false;
            }
            else
            {
                btn_P.BackColor = Color.Red;
                btn_P.Enabled = false;
            }
            didweWIN();
        }

        private void btn_Q_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'Q')
                {
                    Controls[$"lbl_{i}"].Text = "Q";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_Q.BackColor = Color.Green;
                btn_Q.Enabled = false;
            }
            else
            {
                btn_Q.BackColor = Color.Red;
                btn_Q.Enabled = false;
            }
            didweWIN();
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'R')
                {
                    Controls[$"lbl_{i}"].Text = "R";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_R.BackColor = Color.Green;
                btn_R.Enabled = false;
            }
            else
            {
                btn_R.BackColor = Color.Red;
                btn_R.Enabled = false;
            }
            didweWIN();
        }

        private void btn_S_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'S')
                {
                    Controls[$"lbl_{i}"].Text = "S";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_S.BackColor = Color.Green;
                btn_S.Enabled = false;
            }
            else
            {
                btn_S.BackColor = Color.Red;
                btn_S.Enabled = false;
            }
            didweWIN();
        }

        private void btn_T_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'T')
                {
                    Controls[$"lbl_{i}"].Text = "T";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_T.BackColor = Color.Green;
                btn_T.Enabled = false;
            }
            else
            {
                btn_T.BackColor = Color.Red;
                btn_T.Enabled = false;
            }
            didweWIN();
        }

        private void btn_U_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'U')
                {
                    Controls[$"lbl_{i}"].Text = "U";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_U.BackColor = Color.Green;
                btn_U.Enabled = false;
            }
            else
            {
                btn_U.BackColor = Color.Red;
                btn_U.Enabled = false;
            }
            didweWIN();
        }

        private void btn_V_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'V')
                {
                    Controls[$"lbl_{i}"].Text = "V";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_V.BackColor = Color.Green;
                btn_V.Enabled = false;
            }
            else
            {
                btn_V.BackColor = Color.Red;
                btn_V.Enabled = false;
            }
            didweWIN();
        }

        private void btn_W_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'W')
                {
                    Controls[$"lbl_{i}"].Text = "W";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_W.BackColor = Color.Green;
                btn_W.Enabled = false;
            }
            else
            {
                btn_W.BackColor = Color.Red;
                btn_W.Enabled = false;
            }
            didweWIN();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'X')
                {
                    Controls[$"lbl_{i}"].Text = "X";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_X.BackColor = Color.Green;
                btn_X.Enabled = false;
            }
            else
            {
                btn_X.BackColor = Color.Red;
                btn_X.Enabled = false;
            }
            didweWIN();
        }

        private void btn_Y_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'Y')
                {
                    Controls[$"lbl_{i}"].Text = "Y";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_Y.BackColor = Color.Green;
                btn_Y.Enabled = false;
            }
            else
            {
                btn_Y.BackColor = Color.Red;
                btn_Y.Enabled = false;
            }
            didweWIN();
        }

        private void btn_Z_Click(object sender, EventArgs e)
        {
            bool hohoho = false;
            for (int i = 0; i < 5; i++)
            {
                if (woword[i] == 'Z')
                {
                    Controls[$"lbl_{i}"].Text = "Z";
                    katabetul[i] = true;
                    hohoho = true;
                }
            }
            if (hohoho)
            {
                btn_Z.BackColor = Color.Green;
                btn_Z.Enabled = false;
            }
            else
            {
                btn_Z.BackColor = Color.Red;
                btn_Z.Enabled = false;
            }
            didweWIN();
        }
    }
}
