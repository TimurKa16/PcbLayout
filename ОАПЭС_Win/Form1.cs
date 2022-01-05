using System;
using System.Windows.Forms;

namespace ОАПЭС_Win
{
    

    public partial class Form1 : Form
    {
        int V;//
        int L;//
        int[][] VL;//
        Form3 form3;
        Form2 form2;
        int[][] C;

        public int[][] C0;
        public int[][] VL0;//


        public Form1()
        {
            InitializeComponent();
            
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private int Input(ref int x, string s, string Exception)
        {
            try
            {
                x = int.Parse(s);
            }
            catch (System.Exception)
            {
                MessageBox.Show(Exception);
                return 1;
            };
            return 0;
        }

        private int Input_arr(ref int[] x, string s, string Exception)
        {
            try
            {
                x = new int[Convert.ToInt32(s)];
            }
            catch (System.Exception)
            {
                MessageBox.Show(Exception);
                return 1;
            };
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f = 0;
            f += Input(ref V, comboBox1.Text, "Введите количество вершин!");
            f += Input(ref L, comboBox2.Text, "Введите количество кусков!");
            
            
            VL = new int[L][];

            if (L > 0 && comboBox3.Text != null)
                f += Input_arr(ref VL[0], comboBox3.Text, "Введите количество вершин в первом куске!");
            if (L > 1 && comboBox4.Text != null)
                f += Input_arr(ref VL[1], comboBox4.Text, "Введите количество вершин во втором куске!");
            if (L > 2 && comboBox5.Text != null)
                f += Input_arr(ref VL[2], comboBox5.Text, "Введите количество вершин в третьем куске!");
            if (L > 3 && comboBox6.Text != null)
                f += Input_arr(ref VL[3], comboBox6.Text, "Введите количество вершин в четвёртом куске!");

            int sum = 0;
            if (f == 0)
            {
                for (int i = 0; i < L; i++)
                    sum += VL[i].Length;
            }

            if (sum != V && f == 0)
            {
                MessageBox.Show("Пересчитайте количество вершин в кусках!");
                f++;
            }

            if (f == 0)
            {
                Quantity.V = V;
                Quantity.L = L;

                Quantity.VL = new int[L][];
                for (int i = 0; i < L; i++)
                    Quantity.VL[i] = new int[VL[i].Length];
                sum = 1;
                for (int i = 0; i < VL.Length; i++)
                    for (int j = 0; j < VL[i].Length; j++)
                    {
                        VL[i][j] = sum;
                        sum++;
                    }
                
                Quantity.VL = VL;


               

                try
                {
                    Algorithm.algorithm();
                    form3 = new Form3(C0);
                    form3.ShowDialog();
                }
                catch (Exception) { MessageBox.Show("Введите матрицу смежности!"); }
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int f = 0;
            f += Input(ref V, comboBox1.Text, "Неверно введено количество вершин!");
            if (f == 0)
            {
                Quantity.V = V;
                form2 = new Form2(C0);
                form2.Owner = this;
                form2.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (Convert.ToInt32(comboBox2.Text) >= 1)
                {
                    comboBox3.Visible = true;
                    label3.Visible = true;
                }
                else
                {
                    comboBox3.Visible = false;
                    label3.Visible = false;
                }
                if (Convert.ToInt32(comboBox2.Text) >= 2)
                {
                    comboBox4.Visible = true;
                    label4.Visible = true;
                }
                else
                {
                    comboBox4.Visible = false;
                    label4.Visible = false;
                }
                if (Convert.ToInt32(comboBox2.Text) >= 3)
                {
                    comboBox5.Visible = true;
                    label5.Visible = true;
                }
                else
                {
                    comboBox5.Visible = false;
                    label5.Visible = false;
                }
                if (Convert.ToInt32(comboBox2.Text) >= 4)
                {
                    comboBox6.Visible = true;
                    label6.Visible = true;
                }
                else
                {
                    comboBox6.Visible = false;
                    label6.Visible = false;
                }
            }
            catch (System.FormatException)
            { MessageBox.Show("Введите количество кусков!"); }
        }

        private void button4_Click()
        {
            comboBox1.SelectedIndex = 8;
            comboBox2.SelectedIndex = 1;
            button3.PerformClick();
            C = new int[9][];
            for (int i = 0; i < 9; i++)
                C[i] = new int[9];
            C[0][1] = 1;
            C[0][7] = 1;
            C[1][2] = 1;
            C[1][3] = 1;
            C[1][4] = 1;
            C[1][7] = 1;
            C[2][5] = 1;
            C[2][8] = 1;
            C[3][6] = 1;
            C[4][5] = 1;
            C[4][8] = 1;
            C[6][7] = 1;
            C[7][8] = 1;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < i; j++)
                    C[i][j] = C[j][i];

            C0 = new int[9][];
            for (int i = 0; i < 9; i++)
                C0[i] = new int[9];
            C0[0][1] = 1;
            C0[0][7] = 1;
            C0[1][2] = 1;
            C0[1][3] = 1;
            C0[1][4] = 1;
            C0[1][7] = 1;
            C0[2][5] = 1;
            C0[2][8] = 1;
            C0[3][6] = 1;
            C0[4][5] = 1;
            C0[4][8] = 1;
            C0[6][7] = 1;
            C0[7][8] = 1;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < i; j++)
                    C0[i][j] = C0[j][i];


            Quantity.C = C;
            comboBox3.SelectedIndex = 2;
            comboBox4.SelectedIndex = 3;
            comboBox5.SelectedIndex = 1;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4_Click();
        }
    }
}
