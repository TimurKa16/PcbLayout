using System;
using System.Drawing;
using System.Windows.Forms;

namespace ОАПЭС_Win
{
    public partial class Form2 : Form
    {
        int V;
        int[][] C;
        TextBox[][] tb;
        int[][] C0;

        public Form2(int[][] C0)
        {
            InitializeComponent();
            
        }

        private void Matrix_C_Load(object sender, EventArgs e)
        {
            V = Quantity.V;
            Quantity.C = new int[V][];
            for (int i = 0; i < V; i++)
                Quantity.C[i] = new int[V];
            
            C = new int[V][];
            for (int i = 0; i < V; i++)
                C[i] = new int[V];
                        

            C0 = new int[V][];
            for (int i = 0; i < V; i++)
                C0[i] = new int[V];

            tb = new TextBox[V][];
            for (int i = 0; i < V; i++)
            {
                tb[i] = new TextBox[V];
                for (int j = 0; j < V; j++)
                {
                    tb[i][j] = new TextBox()
                    {
                        Name = "tb" + i.ToString(),
                        Size = new Size(20, 20),                    
                    };
                    tb[i][j].Location = new Point(15 + j * (tb[i][j].Width + 5) + 5, 70 + i * (tb[i][j].Height + 5) + 5);
                    Controls.Add(tb[i][j]);
                }
            }
            for (int i = 0; i < V; i++)
                for (int j = 0; j <= i; j++)
                    tb[i][j].Enabled = false;

        }


        private int Input(ref int x, string s)
        {
            try
            {               
                x = int.Parse(s);
            }
            catch (System.Exception)
            {
                return 1;
            };
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < V; i++)
                for (int j = 0; j < V; j++)
                    if (tb[i][j].Text == String.Empty)
                        tb[i][j].Text = "0".ToString();
            for (int i = 0; i < V; i++)
                for (int j = 0; j < i; j++)
                    tb[i][j].Text = tb[j][i].Text;
            for (int i = 0; i < V; i++)
                tb[i][i].Text = "0".ToString();

            int f = 0;
            for (int i = 0; i < V; i++)
                for (int j = 0; j < V; j++)
                {
                    f += Input(ref C[i][j], tb[i][j].Text);
                    f += Input(ref C0[i][j], tb[i][j].Text);
                }
            
            if (f == 0)
            {
                Quantity.C = C;
                Form1 main = this.Owner as Form1;
                main.C0 = C0;
                for (int i = 0; i < V; i++)
                    for (int j = 0; j < V; j++)
                        tb[i][j].Dispose();
                Close();
            }
            else
                MessageBox.Show("Неправильно введена матрица смежности!");
        }

        private void button1_Click_1(object sender, EventArgs e) // симметрия
        {
            for (int i = 0; i < V; i++)
                for (int j = 0; j < V; j++)
                    if (tb[i][j].Text == String.Empty)
                        tb[i][j].Text = "0".ToString();

            for (int i = 0; i < V; i++)
                for (int j = 0; j < i; j++)
                    tb[i][j].Text = tb[j][i].Text;
            for (int i = 0; i < V; i++)
                tb[i][i].Text = "0".ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
