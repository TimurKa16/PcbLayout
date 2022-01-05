using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ОАПЭС_Win
{
    public partial class Form3 : Form
    {
        private int[][] VL { get; set; }
        private int[][] External { get; set; }
        private List<int[][]> list { get; set; }

        private int[][] C0 { get; set; }
        private int[][] VL0 { get; set; }
        private int[][] External0 { get; set; }
        private List<int[][]> list0 { get; set; }
        Form4 form4;

        int[,] Rec_Coord = { {10, 10 }, {260, 10 }, {10, 260 }, {260, 260 } };

        void Draw1R(Pen pen_black, Graphics Graph, PictureBox pictureBox1)
        {
            Graph.DrawRectangle(pen_black, Rec_Coord[0,0], Rec_Coord[0, 1], 150, 150);

            Graph.DrawRectangle(pen_black, Rec_Coord[0, 0], Rec_Coord[0, 1], 20, 20);
            Label lb0 = new Label();
            lb0.Parent = pictureBox1;
            lb0.BackColor = Color.Transparent;
            lb0.Width = 30;
            lb0.Height = 30;
            lb0.Text = "1".ToString();
            lb0.Left = Rec_Coord[0, 0];
            lb0.Top = Rec_Coord[0, 1];
            lb0.Font = new Font(lb0.Font, FontStyle.Bold);
            lb0.Font = new Font("Brittanic", 14);
        }

        void Draw2R(Pen pen_black, Graphics Graph, PictureBox pictureBox1, int[][] External)
        {
            Graph.DrawRectangle(pen_black, Rec_Coord[1, 0], Rec_Coord[1, 1], 150, 150);

            Graph.DrawRectangle(pen_black, Rec_Coord[1, 0], Rec_Coord[1, 1], 20, 20);
            Label lb0 = new Label();
            lb0.Parent = pictureBox1;
            lb0.BackColor = Color.Transparent;
            lb0.Width = 30;
            lb0.Height = 30;
            lb0.Text = "2".ToString();
            lb0.Left = Rec_Coord[1, 0];
            lb0.Top = Rec_Coord[1, 1];
            lb0.Font = new Font(lb0.Font, FontStyle.Bold);
            lb0.Font = new Font("Brittanic", 14);

            Graph.DrawLine(pen_black, 160, 85, 260, 85);
            Label lb1 = new Label();
            lb1.Parent = pictureBox1;
            lb1.BackColor = Color.Transparent;
            lb1.Width = 30;
            lb1.Height = 30;
            lb1.Text = External[0][1].ToString();
            lb1.Left = 160;
            lb1.Top = 70;
            lb1.Font = new Font(lb1.Font, FontStyle.Bold);
        }

        void Draw3R(Pen pen_black, Graphics Graph, PictureBox pictureBox1, int[][] External)
        {
            Graph.DrawRectangle(pen_black, Rec_Coord[2, 0], Rec_Coord[2, 1], 150, 150);
            Graph.DrawRectangle(pen_black, Rec_Coord[2, 0], Rec_Coord[2, 1], 20, 20);

            Label lb0 = new Label();
            lb0.Parent = pictureBox1;
            lb0.BackColor = Color.Transparent;
            lb0.Width = 30;
            lb0.Height = 30;
            lb0.Text = "3".ToString();
            lb0.Left = Rec_Coord[2, 0];
            lb0.Top = Rec_Coord[2, 1];
            lb0.Font = new Font(lb0.Font, FontStyle.Bold);
            lb0.Font = new Font("Brittanic", 14);

            Graph.DrawLine(pen_black, 85, 160, 85, 260);
            Label lb2 = new Label();
            lb2.Parent = pictureBox1;
            lb2.BackColor = Color.Transparent;
            lb2.Width = 30;
            lb2.Height = 30;
            lb2.Text = External[0][2].ToString();
            lb2.Left = 85;
            lb2.Top = 245;
            lb2.Font = new Font(lb2.Font, FontStyle.Bold);

            Graph.DrawLine(pen_black, 160, 260, 260, 160);
            Label lb3 = new Label();
            lb3.Parent = pictureBox1;
            lb3.BackColor = Color.Transparent;
            lb3.Width = 30;
            lb3.Height = 30;
            lb3.Text = External[1][2].ToString();
            lb3.Left = 160;
            lb3.Top = 260;
            lb3.Font = new Font(lb3.Font, FontStyle.Bold);

        }

        void Draw4R(Pen pen_black, Graphics Graph, PictureBox pictureBox1, int[][] External)
        {
            Graph.DrawRectangle(pen_black, Rec_Coord[3, 0], Rec_Coord[3, 1], 150, 150);
            Graph.DrawRectangle(pen_black, Rec_Coord[3, 0], Rec_Coord[3, 1], 20, 20);

            Label lb0 = new Label();
            lb0.Parent = pictureBox1;
            lb0.BackColor = Color.Transparent;
            lb0.Width = 30;
            lb0.Height = 30;
            lb0.Text = "4".ToString();
            lb0.Left = Rec_Coord[3, 0];
            lb0.Top = Rec_Coord[3, 1];
            lb0.Font = new Font(lb0.Font, FontStyle.Bold);
            lb0.Font = new Font("Brittanic", 14);

            Graph.DrawLine(pen_black, 160, 160, 260, 260);
            Label lb1 = new Label();
            lb1.Parent = pictureBox1;
            lb1.BackColor = Color.Transparent;
            lb1.Width = 30;
            lb1.Height = 30;
            lb1.Text = External[0][3].ToString();
            lb1.Left = 160;
            lb1.Top = 145;
            lb1.Font = new Font(lb1.Font, FontStyle.Bold);

            Graph.DrawLine(pen_black, 335, 160, 335, 260);
            Label lb2 = new Label();
            lb2.Parent = pictureBox1;
            lb2.BackColor = Color.Transparent;
            lb2.Width = 30;
            lb2.Height = 30;
            lb2.Text = External[1][3].ToString();
            lb2.Left = 335;
            lb2.Top = 245;
            lb2.Font = new Font(lb2.Font, FontStyle.Bold);

            Graph.DrawLine(pen_black, 160, 335, 260, 335);
            Label lb3 = new Label();
            lb3.Parent = pictureBox1;
            lb3.BackColor = Color.Transparent;
            lb3.Width = 30;
            lb3.Height = 30;
            lb3.Text = External[2][3].ToString();
            lb3.Left = 160;
            lb3.Top = 320;
            lb3.Font = new Font(lb3.Font, FontStyle.Bold);
        }

        void Draw1C(Pen pen, SolidBrush brush,  Graphics Graph, int Rec_Number, int[][] MatrixC, int[] Vertexes, PictureBox pictureBox1)
        {
            int a = Rec_Coord[Rec_Number, 0] + 50;
            int b = Rec_Coord[Rec_Number, 1] + 50;            
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb1 = new Label();
            lb1.Parent = pictureBox1;
            lb1.BackColor = Color.Transparent;
            lb1.Text = "X" + +Vertexes[0];
            if (lb1.Text.Length == 3) a -= 4;
            lb1.Left = a + 6;
            lb1.Top = b + 8;
            lb1.ForeColor = Color.White;
            lb1.Font = new Font(lb1.Font, FontStyle.Bold);
            int x1 = a + 15;
            int y1 = b + 15;
        }

        void Draw2C(Pen pen, SolidBrush brush, Graphics Graph, int Rec_Number, int[][] MatrixC, int[] Vertexes, PictureBox pictureBox1)
        {
            int L = 2;
            int[][] Center = new int[L][];
            for (int i = 0; i < L; i++)
                Center[i] = new int[L];

            int a = Rec_Coord[Rec_Number, 0] + 20;
            int b = Rec_Coord[Rec_Number, 1] + 50;

            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb1 = new Label();
            lb1.Parent = pictureBox1;
            lb1.BackColor = Color.Transparent;
            lb1.Width = 30;
            lb1.Height = 30;
            lb1.Text = "X" + Vertexes[0];
            if (lb1.Text.Length == 3) a -= 4;
            lb1.Left = a + 6;
            lb1.Top = b + 8;
            lb1.ForeColor = Color.White;
            lb1.Font = new Font(lb1.Font, FontStyle.Bold);
            Center[0][0] = a + 15;
            Center[0][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 100;
            b = Rec_Coord[Rec_Number, 1] + 50;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb2 = new Label();
            lb2.Parent = pictureBox1;
            lb2.BackColor = Color.Transparent;
            lb2.Width = 30;
            lb2.Height = 30;
            lb2.Text = "X" + Vertexes[1];
            if (lb2.Text.Length == 3) a -= 4;
            lb2.Left = a + 6;
            lb2.Top = b + 8;
            lb2.ForeColor = Color.White;
            lb2.Font = new Font(lb2.Font, FontStyle.Bold);
            Center[1][0] = a + 15;
            Center[1][1] = b + 15;
            
            for(int i = 0; i < MatrixC.Length; i++)
                for(int j = i; j < MatrixC.Length; j++)
                    if (MatrixC[i][j] == 1)
                        Graph.DrawLine(pen, Center[i][0], Center[i][1], Center[j][0], Center[j][1]);

        }

        void Draw3C(Pen pen, SolidBrush brush, Graphics Graph, int Rec_Number, int[][] MatrixC, int[] Vertexes, PictureBox pictureBox1)
        {
            int L = 3;
            int[][] Center = new int[L][];
            for (int i = 0; i < L; i++)
                Center[i] = new int[L];

            int a = Rec_Coord[Rec_Number, 0] + 20;
            int b = Rec_Coord[Rec_Number, 1] + 20;

            Graph.FillEllipse(brush, a, b, 30, 30);//1
            Label lb1 = new Label();
            lb1.Parent = pictureBox1;
            lb1.BackColor = Color.Transparent;
            lb1.Width = 30;
            lb1.Height = 30;
            lb1.Text = "X" + Vertexes[0];
            if (lb1.Text.Length == 3) a -= 4;
            lb1.Left = a + 6;
            lb1.Top = b + 8;
            lb1.ForeColor = Color.White;
            lb1.Font = new Font(lb1.Font, FontStyle.Bold);
            Center[0][0] = a + 15;
            Center[0][1] = b + 15;


            a = Rec_Coord[Rec_Number, 0] + 100; //2
            b = Rec_Coord[Rec_Number, 1] + 20;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb2 = new Label();
            lb2.Parent = pictureBox1;
            lb2.BackColor = Color.Transparent;
            lb2.Width = 30;
            lb2.Height = 30;
            lb2.Text = "X" + Vertexes[1];
            if (lb2.Text.Length == 3) a -= 4;
            lb2.Left = a + 6;
            lb2.Top = b + 8;
            lb2.ForeColor = Color.White;
            lb2.Font = new Font(lb2.Font, FontStyle.Bold);
            Center[1][0] = a + 15;
            Center[1][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 60; //3
            b = Rec_Coord[Rec_Number, 1] + 100;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb3 = new Label();
            lb3.Parent = pictureBox1;
            lb3.BackColor = Color.Transparent;
            lb3.Width = 30;
            lb3.Height = 30;
            lb3.Text = "X" + Vertexes[2];
            if (lb3.Text.Length == 3) a -= 4;
            lb3.Left = a + 6;
            lb3.Top = b + 8;
            lb3.ForeColor = Color.White;
            lb3.Font = new Font(lb3.Font, FontStyle.Bold);
            Center[2][0] = a + 15;
            Center[2][1] = b + 15;

            for (int i = 0; i < MatrixC.Length; i++)
                for (int j = i; j < MatrixC.Length; j++)
                    if (MatrixC[i][j] == 1)
                        Graph.DrawLine(pen, Center[i][0], Center[i][1], Center[j][0], Center[j][1]);
        }

        void Draw4C(Pen pen, SolidBrush brush, Graphics Graph, int Rec_Number, int[][] MatrixC, int[] Vertexes, PictureBox pictureBox1)
        {
            int L = 4;
            int[][] Center = new int[L][];
            for (int i = 0; i < L; i++)
                Center[i] = new int[L];

            int a = Rec_Coord[Rec_Number, 0] + 20;
            int b = Rec_Coord[Rec_Number, 1] + 20;
            Graph.FillEllipse(brush, a, b, 30, 30);//1
            Label lb1 = new Label();
            lb1.Parent = pictureBox1;
            lb1.BackColor = Color.Transparent;
            lb1.Width = 30;
            lb1.Height = 30;
            lb1.Text = "X" + Vertexes[0];
            if (lb1.Text.Length == 3) a -= 4;
            lb1.Left = a + 6;
            lb1.Top = b + 8;
            lb1.ForeColor = Color.White;
            lb1.Font = new Font(lb1.Font, FontStyle.Bold);
            Center[0][0] = a + 15;
            Center[0][1] = b + 15;


            a = Rec_Coord[Rec_Number, 0] + 100; //2
            b = Rec_Coord[Rec_Number, 1] + 20;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb2 = new Label();
            lb2.Parent = pictureBox1;
            lb2.BackColor = Color.Transparent;
            lb2.Width = 30;
            lb2.Height = 30;
            lb2.Text = "X" + Vertexes[1];
            if (lb2.Text.Length == 3) a -= 4;
            lb2.Left = a + 6;
            lb2.Top = b + 8;
            lb2.ForeColor = Color.White;
            lb2.Font = new Font(lb2.Font, FontStyle.Bold);
            Center[1][0] = a + 15;
            Center[1][1] = b + 15;


            a = Rec_Coord[Rec_Number, 0] + 20; //3
            b = Rec_Coord[Rec_Number, 1] + 100;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb3 = new Label();
            lb3.Parent = pictureBox1;
            lb3.BackColor = Color.Transparent;
            lb3.Width = 30;
            lb3.Height = 30;
            lb3.Text = "X" + Vertexes[2];
            if (lb3.Text.Length == 3) a -= 4;
            lb3.Left = a + 6;
            lb3.Top = b + 8;
            lb3.ForeColor = Color.White;
            lb3.Font = new Font(lb3.Font, FontStyle.Bold);
            Center[2][0] = a + 15;
            Center[2][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 100; //4
            b = Rec_Coord[Rec_Number, 1] + 100;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb4 = new Label();
            lb4.Parent = pictureBox1;
            lb4.BackColor = Color.Transparent;
            lb4.Width = 30;
            lb4.Height = 30;
            lb4.Text = "X" + Vertexes[3];
            if (lb4.Text.Length == 3) a -= 4;
            lb4.Left = a + 6;
            lb4.Top = b + 8;
            lb4.ForeColor = Color.White;
            lb4.Font = new Font(lb4.Font, FontStyle.Bold);
            Center[3][0] = a + 15;
            Center[3][1] = b + 15;

            for (int i = 0; i < MatrixC.Length; i++)
                for (int j = i; j < MatrixC.Length; j++)
                    if (MatrixC[i][j] == 1)
                        Graph.DrawLine(pen, Center[i][0], Center[i][1], Center[j][0], Center[j][1]);

        }

        void Draw5C(Pen pen, SolidBrush brush, Graphics Graph, int Rec_Number, int[][] MatrixC, int[] Vertexes, PictureBox pictureBox1)
        {
            int L = 5;
            int[][] Center = new int[L][];
            for (int i = 0; i < L; i++)
                Center[i] = new int[L];

            int a = Rec_Coord[Rec_Number, 0] + 60;
            int b = Rec_Coord[Rec_Number, 1] + 20;
            Graph.FillEllipse(brush, a, b, 30, 30);//1
            Label lb1 = new Label();
            lb1.Parent = pictureBox1;
            lb1.BackColor = Color.Transparent;
            lb1.Width = 30;
            lb1.Height = 30;
            lb1.Text = "X" + Vertexes[0];
            if (lb1.Text.Length == 3) a -= 4;
            lb1.Left = a + 6;
            lb1.Top = b + 8;
            lb1.ForeColor = Color.White;
            lb1.Font = new Font(lb1.Font, FontStyle.Bold);
            Center[0][0] = a + 15;
            Center[0][1] = b + 15;


            a = Rec_Coord[Rec_Number, 0] + 20; //2
            b = Rec_Coord[Rec_Number, 1] + 55;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb2 = new Label();
            lb2.Parent = pictureBox1;
            lb2.BackColor = Color.Transparent;
            lb2.Width = 30;
            lb2.Height = 30;
            lb2.Text = "X" + Vertexes[1];
            if (lb2.Text.Length == 3) a -= 4;
            lb2.Left = a + 6;
            lb2.Top = b + 8;
            lb2.ForeColor = Color.White;
            lb2.Font = new Font(lb2.Font, FontStyle.Bold);
            Center[1][0] = a + 15;
            Center[1][1] = b + 15;


            a = Rec_Coord[Rec_Number, 0] + 100; //3
            b = Rec_Coord[Rec_Number, 1] + 55;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb3 = new Label();
            lb3.Parent = pictureBox1;
            lb3.BackColor = Color.Transparent;
            lb3.Width = 30;
            lb3.Height = 30;
            lb3.Text = "X" + Vertexes[2];
            if (lb3.Text.Length == 3) a -= 4;
            lb3.Left = a + 6;
            lb3.Top = b + 8;
            lb3.ForeColor = Color.White;
            lb3.Font = new Font(lb3.Font, FontStyle.Bold);
            Center[2][0] = a + 15;
            Center[2][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 40; //4
            b = Rec_Coord[Rec_Number, 1] + 100;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb4 = new Label();
            lb4.Parent = pictureBox1;
            lb4.BackColor = Color.Transparent;
            lb4.Width = 30;
            lb4.Height = 30;
            lb4.Text = "X" + Vertexes[3];
            if (lb4.Text.Length == 3) a -= 4;
            lb4.Left = a + 6;
            lb4.Top = b + 8;
            lb4.ForeColor = Color.White;
            lb4.Font = new Font(lb4.Font, FontStyle.Bold);
            Center[3][0] = a + 15;
            Center[3][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 80; //5
            b = Rec_Coord[Rec_Number, 1] + 100;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb5 = new Label();
            lb5.Parent = pictureBox1;
            lb5.BackColor = Color.Transparent;
            lb5.Width = 30;
            lb5.Height = 30;
            lb5.Text = "X" + Vertexes[4];
            if (lb5.Text.Length == 3) a -= 4;
            lb5.Left = a + 6;
            lb5.Top = b + 8;
            lb5.ForeColor = Color.White;
            lb5.Font = new Font(lb5.Font, FontStyle.Bold);
            Center[4][0] = a + 15;
            Center[4][1] = b + 15;

            for (int i = 0; i < MatrixC.Length; i++)
                for (int j = i; j < MatrixC.Length; j++)
                    if (MatrixC[i][j] == 1)
                        Graph.DrawLine(pen, Center[i][0], Center[i][1], Center[j][0], Center[j][1]);
        }

        void Draw6C(Pen pen, SolidBrush brush, Graphics Graph, int Rec_Number, int[][] MatrixC, int[] Vertexes, PictureBox pictureBox1)
        {
            int L = 6;
            int[][] Center = new int[L][];
            for (int i = 0; i < L; i++)
                Center[i] = new int[L];

            int a = Rec_Coord[Rec_Number, 0] + 35; //1
            int b = Rec_Coord[Rec_Number, 1] + 10;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb1 = new Label();
            lb1.Parent = pictureBox1;
            lb1.BackColor = Color.Transparent;
            lb1.Width = 30;
            lb1.Height = 30;
            lb1.Text = "X" + Vertexes[0];
            if (lb1.Text.Length == 3) a -= 4;
            lb1.Left = a + 6;
            lb1.Top = b + 8;
            lb1.ForeColor = Color.White;
            lb1.Font = new Font(lb1.Font, FontStyle.Bold);
            Center[0][0] = a + 15;
            Center[0][1] = b + 15;


            a = Rec_Coord[Rec_Number, 0] + 85; //2
            b = Rec_Coord[Rec_Number, 1] + 10;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb2 = new Label();
            lb2.Parent = pictureBox1;
            lb2.BackColor = Color.Transparent;
            lb2.Width = 30;
            lb2.Height = 30;
            lb2.Text = "X" + Vertexes[1];
            if (lb2.Text.Length == 3) a -= 4;
            lb2.Left = a + 6;
            lb2.Top = b + 8;
            lb2.ForeColor = Color.White;
            lb2.Font = new Font(lb2.Font, FontStyle.Bold);
            Center[1][0] = a + 15;
            Center[1][1] = b + 15;


            a = Rec_Coord[Rec_Number, 0] + 10; //3
            b = Rec_Coord[Rec_Number, 1] + 60;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb3 = new Label();
            lb3.Parent = pictureBox1;
            lb3.BackColor = Color.Transparent;
            lb3.Width = 30;
            lb3.Height = 30;
            lb3.Text = "X" + Vertexes[2];
            if (lb3.Text.Length == 3) a -= 4;
            lb3.Left = a + 6;
            lb3.Top = b + 8;
            lb3.ForeColor = Color.White;
            lb3.Font = new Font(lb3.Font, FontStyle.Bold);
            Center[2][0] = a + 15;
            Center[2][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 110; //4
            b = Rec_Coord[Rec_Number, 1] + 60;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb4 = new Label();
            lb4.Parent = pictureBox1;
            lb4.BackColor = Color.Transparent;
            lb4.Width = 30;
            lb4.Height = 30;
            lb4.Text = "X" + Vertexes[3];
            if (lb4.Text.Length == 3) a -= 4;
            lb4.Left = a + 6;
            lb4.Top = b + 8;
            lb4.ForeColor = Color.White;
            lb4.Font = new Font(lb4.Font, FontStyle.Bold);
            Center[3][0] = a + 15;
            Center[3][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 35; //5
            b = Rec_Coord[Rec_Number, 1] + 110;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb5 = new Label();
            lb5.Parent = pictureBox1;
            lb5.BackColor = Color.Transparent;
            lb5.Width = 30;
            lb5.Height = 30;
            lb5.Text = "X" + Vertexes[4];
            if (lb5.Text.Length == 3) a -= 4;
            lb5.Left = a + 6;
            lb5.Top = b + 8;
            lb5.ForeColor = Color.White;
            lb5.Font = new Font(lb5.Font, FontStyle.Bold);
            Center[4][0] = a + 15;
            Center[4][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 85; //6
            b = Rec_Coord[Rec_Number, 1] + 110;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb6 = new Label();
            lb6.Parent = pictureBox1;
            lb6.BackColor = Color.Transparent;
            lb6.Width = 30;
            lb6.Height = 30;
            lb6.Text = "X" + Vertexes[5];
            if (lb6.Text.Length == 3) a -= 4;
            lb6.Left = a + 6;
            lb6.Top = b + 8;
            lb6.ForeColor = Color.White;
            lb6.Font = new Font(lb6.Font, FontStyle.Bold);
            Center[5][0] = a + 15;
            Center[5][1] = b + 15;

            for (int i = 0; i < MatrixC.Length; i++)
                for (int j = i; j < MatrixC.Length; j++)
                    if (MatrixC[i][j] == 1)
                        Graph.DrawLine(pen, Center[i][0], Center[i][1], Center[j][0], Center[j][1]);
        }

        void Draw7C(Pen pen, SolidBrush brush, Graphics Graph, int Rec_Number, int[][] MatrixC, int[] Vertexes, PictureBox pictureBox1)
        {
            int L = 7;
            int[][] Center = new int[L][];
            for (int i = 0; i < L; i++)
                Center[i] = new int[L];

            int a = Rec_Coord[Rec_Number, 0] + 60; //1
            int b = Rec_Coord[Rec_Number, 1] + 5;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb1 = new Label();
            lb1.Parent = pictureBox1;
            lb1.BackColor = Color.Transparent;
            lb1.Width = 30;
            lb1.Height = 30;
            lb1.Text = "X" + Vertexes[0];
            if (lb1.Text.Length == 3) a -= 4;
            lb1.Left = a + 6;
            lb1.Top = b + 8;
            lb1.ForeColor = Color.White;
            lb1.Font = new Font(lb1.Font, FontStyle.Bold);
            Center[0][0] = a + 15;
            Center[0][1] = b + 15;


            a = Rec_Coord[Rec_Number, 0] + 5; //2
            b = Rec_Coord[Rec_Number, 1] + 35;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb2 = new Label();
            lb2.Parent = pictureBox1;
            lb2.BackColor = Color.Transparent;
            lb2.Width = 30;
            lb2.Height = 30;
            lb2.Text = "X" + Vertexes[1];
            if (lb2.Text.Length == 3) a -= 4;
            lb2.Left = a + 6;
            lb2.Top = b + 8;
            lb2.ForeColor = Color.White;
            lb2.Font = new Font(lb2.Font, FontStyle.Bold);
            Center[1][0] = a + 15;
            Center[1][1] = b + 15;


            a = Rec_Coord[Rec_Number, 0] + 110; //3
            b = Rec_Coord[Rec_Number, 1] + 35;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb3 = new Label();
            lb3.Parent = pictureBox1;
            lb3.BackColor = Color.Transparent;
            lb3.Width = 30;
            lb3.Height = 30;
            lb3.Text = "X" + Vertexes[2];
            if (lb3.Text.Length == 3) a -= 4;
            lb3.Left = a + 6;
            lb3.Top = b + 8;
            lb3.ForeColor = Color.White;
            lb3.Font = new Font(lb3.Font, FontStyle.Bold);
            Center[2][0] = a + 15;
            Center[2][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 5; //4
            b = Rec_Coord[Rec_Number, 1] + 75;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb4 = new Label();
            lb4.Parent = pictureBox1;
            lb4.BackColor = Color.Transparent;
            lb4.Width = 30;
            lb4.Height = 30;
            lb4.Text = "X" + Vertexes[3];
            if (lb4.Text.Length == 3) a -= 4;
            lb4.Left = a + 6;
            lb4.Top = b + 8;
            lb4.ForeColor = Color.White;
            lb4.Font = new Font(lb4.Font, FontStyle.Bold);
            Center[3][0] = a + 15;
            Center[3][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 110; //5
            b = Rec_Coord[Rec_Number, 1] + 75;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb5 = new Label();
            lb5.Parent = pictureBox1;
            lb5.BackColor = Color.Transparent;
            lb5.Width = 30;
            lb5.Height = 30;
            lb5.Text = "X" + Vertexes[4];
            if (lb5.Text.Length == 3) a -= 4;
            lb5.Left = a + 6;
            lb5.Top = b + 8;
            lb5.ForeColor = Color.White;
            lb5.Font = new Font(lb5.Font, FontStyle.Bold);
            Center[4][0] = a + 15;
            Center[4][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 40; //6
            b = Rec_Coord[Rec_Number, 1] + 110;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb6 = new Label();
            lb6.Parent = pictureBox1;
            lb6.BackColor = Color.Transparent;
            lb6.Width = 30;
            lb6.Height = 30;
            lb6.Text = "X" + Vertexes[5];
            if (lb6.Text.Length == 3) a -= 4;
            lb6.Left = a + 6;
            lb6.Top = b + 8;
            lb6.ForeColor = Color.White;
            lb6.Font = new Font(lb6.Font, FontStyle.Bold);
            Center[5][0] = a + 15;
            Center[5][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 80; //7
            b = Rec_Coord[Rec_Number, 1] + 110;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb7 = new Label();
            lb7.Parent = pictureBox1;
            lb7.BackColor = Color.Transparent;
            lb7.Width = 30;
            lb7.Height = 30;
            lb7.Text = "X" + Vertexes[6];
            if (lb7.Text.Length == 3) a -= 4;
            lb7.Left = a + 6;
            lb7.Top = b + 8;
            lb7.ForeColor = Color.White;
            lb7.Font = new Font(lb7.Font, FontStyle.Bold);
            Center[6][0] = a + 15;
            Center[6][1] = b + 15;

            for (int i = 0; i < MatrixC.Length; i++)
                for (int j = i; j < MatrixC.Length; j++)
                    if (MatrixC[i][j] == 1)
                        Graph.DrawLine(pen, Center[i][0], Center[i][1], Center[j][0], Center[j][1]);
        }

        void Draw8C(Pen pen, SolidBrush brush, Graphics Graph, int Rec_Number, int[][] MatrixC, int[] Vertexes, PictureBox pictureBox1)
        {
            int L = 8;
            int[][] Center = new int[L][];
            for (int i = 0; i < L; i++)
                Center[i] = new int[L];

            int a = Rec_Coord[Rec_Number, 0] + 40; //1
            int b = Rec_Coord[Rec_Number, 1] + 5;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb1 = new Label();
            lb1.Parent = pictureBox1;
            lb1.BackColor = Color.Transparent;
            lb1.Width = 30;
            lb1.Height = 30;
            lb1.Text = "X" + Vertexes[0];
            if (lb1.Text.Length == 3) a -= 4;
            lb1.Left = a + 6;
            lb1.Top = b + 8;
            lb1.ForeColor = Color.White;
            lb1.Font = new Font(lb1.Font, FontStyle.Bold);
            Center[0][0] = a + 15;
            Center[0][1] = b + 15;


            a = Rec_Coord[Rec_Number, 0] + 80; //2
            b = Rec_Coord[Rec_Number, 1] + 5;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb2 = new Label();
            lb2.Parent = pictureBox1;
            lb2.BackColor = Color.Transparent;
            lb2.Width = 30;
            lb2.Height = 30;
            lb2.Text = "X" + Vertexes[1];
            if (lb2.Text.Length == 3) a -= 4;
            lb2.Left = a + 6;
            lb2.Top = b + 8;
            lb2.ForeColor = Color.White;
            lb2.Font = new Font(lb2.Font, FontStyle.Bold);
            Center[1][0] = a + 15;
            Center[1][1] = b + 15;


            a = Rec_Coord[Rec_Number, 0] + 5; //3
            b = Rec_Coord[Rec_Number, 1] + 35;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb3 = new Label();
            lb3.Parent = pictureBox1;
            lb3.BackColor = Color.Transparent;
            lb3.Width = 30;
            lb3.Height = 30;
            lb3.Text = "X" + Vertexes[2];
            if (lb3.Text.Length == 3) a -= 4;
            lb3.Left = a + 6;
            lb3.Top = b + 8;
            lb3.ForeColor = Color.White;
            lb3.Font = new Font(lb3.Font, FontStyle.Bold);
            Center[2][0] = a + 15;
            Center[2][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 110; //4
            b = Rec_Coord[Rec_Number, 1] + 35;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb4 = new Label();
            lb4.Parent = pictureBox1;
            lb4.BackColor = Color.Transparent;
            lb4.Width = 30;
            lb4.Height = 30;
            lb4.Text = "X" + Vertexes[3];
            if (lb4.Text.Length == 3) a -= 4;
            lb4.Left = a + 6;
            lb4.Top = b + 8;
            lb4.ForeColor = Color.White;
            lb4.Font = new Font(lb4.Font, FontStyle.Bold);
            Center[3][0] = a + 15;
            Center[3][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 5; //5
            b = Rec_Coord[Rec_Number, 1] + 75;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb5 = new Label();
            lb5.Parent = pictureBox1;
            lb5.BackColor = Color.Transparent;
            lb5.Width = 30;
            lb5.Height = 30;
            lb5.Text = "X" + Vertexes[4];
            if (lb5.Text.Length == 3) a -= 4;
            lb5.Left = a + 6;
            lb5.Top = b + 8;
            lb5.ForeColor = Color.White;
            lb5.Font = new Font(lb5.Font, FontStyle.Bold);
            Center[4][0] = a + 15;
            Center[4][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 110; //6
            b = Rec_Coord[Rec_Number, 1] + 75;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb6 = new Label();
            lb6.Parent = pictureBox1;
            lb6.BackColor = Color.Transparent;
            lb6.Width = 30;
            lb6.Height = 30;
            lb6.Text = "X" + Vertexes[5];
            if (lb6.Text.Length == 3) a -= 4;
            lb6.Left = a + 6;
            lb6.Top = b + 8;
            lb6.ForeColor = Color.White;
            lb6.Font = new Font(lb6.Font, FontStyle.Bold);
            Center[5][0] = a + 15;
            Center[5][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 40; //7
            b = Rec_Coord[Rec_Number, 1] + 110;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb7 = new Label();
            lb7.Parent = pictureBox1;
            lb7.BackColor = Color.Transparent;
            lb7.Width = 30;
            lb7.Height = 30;
            lb7.Text = "X" + Vertexes[6];
            lb7.Left = a + 6;
            lb7.Top = b + 8;
            lb7.ForeColor = Color.White;
            lb7.Font = new Font(lb7.Font, FontStyle.Bold);
            Center[6][0] = a + 15;
            Center[6][1] = b + 15;

            a = Rec_Coord[Rec_Number, 0] + 80; //8
            b = Rec_Coord[Rec_Number, 1] + 110;
            Graph.FillEllipse(brush, a, b, 30, 30);
            Label lb8 = new Label();
            lb8.Parent = pictureBox1;
            lb8.BackColor = Color.Transparent;
            lb8.Width = 30;
            lb8.Height = 30;
            lb8.Text = "X" + Vertexes[7];
            if (lb8.Text.Length == 3) a -= 4;
            lb8.Left = a + 6;
            lb8.Top = b + 8;
            lb8.ForeColor = Color.White;
            lb8.Font = new Font(lb8.Font, FontStyle.Bold);
            Center[7][0] = a + 15;
            Center[7][1] = b + 15;

            for (int i = 0; i < MatrixC.Length; i++)
                for (int j = i; j < MatrixC.Length; j++)
                    if (MatrixC[i][j] == 1)
                        Graph.DrawLine(pen, Center[i][0], Center[i][1], Center[j][0], Center[j][1]);
        }
 

        public Form3(int[][] C0)
        {
            this.C0 = C0;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        void DrawR(Pen pen, Graphics Graph, PictureBox pictureBox, int[][] External)
        {
            switch (VL.Length)
            {
                case (1):
                    Draw1R(pen, Graph, pictureBox);
                    break;
                case (2):
                    Draw1R(pen, Graph, pictureBox);
                    Draw2R(pen, Graph, pictureBox, External);
                    break;
                case (3):
                    Draw1R(pen, Graph, pictureBox);
                    Draw2R(pen, Graph, pictureBox, External);
                    Draw3R(pen, Graph, pictureBox, External);
                    break;
                case (4):
                    Draw1R(pen, Graph, pictureBox);
                    Draw2R(pen, Graph, pictureBox, External);
                    Draw3R(pen, Graph, pictureBox, External);
                    Draw4R(pen, Graph, pictureBox, External);
                    break;
            }
        }

        void DrawC(Pen pen, SolidBrush brush, Graphics Graph, int i, int[][] MatrixC, int[] Vertexes, PictureBox pictureBox) //Передаётся i-ый Rectangle (от 0 до (n-1))
        {

            switch (VL[i].Length)
            {
                case (1):
                    Draw1C(pen, brush, Graph, i, MatrixC, Vertexes, pictureBox);
                    break;
                case (2):
                    Draw2C(pen, brush, Graph, i, MatrixC, Vertexes, pictureBox);
                    break;
                case (3):
                    Draw3C(pen, brush, Graph, i, MatrixC, Vertexes, pictureBox);
                    break;
                case (4):
                    Draw4C(pen, brush, Graph, i, MatrixC, Vertexes, pictureBox);
                    break;
                case (5):
                    Draw5C(pen, brush, Graph, i, MatrixC, Vertexes, pictureBox);
                    break;
                case (6):
                    Draw6C(pen, brush, Graph, i, MatrixC, Vertexes, pictureBox);
                    break;
                case (7):
                    Draw7C(pen, brush, Graph, i, MatrixC, Vertexes, pictureBox);
                    break;
                case (8):
                    Draw8C(pen, brush, Graph, i, MatrixC, Vertexes, pictureBox);
                    break;

            }
        }

        
        
        void Picture_Before()
        {
            Bitmap Field = new Bitmap(1000, 1000);
            Graphics Graph = Graphics.FromImage(Field);
            Graph.SmoothingMode = SmoothingMode.AntiAlias;
            pictureBox2.Image = Field;
            Pen pen_black = new Pen(Color.Black, 2);
            Pen pen_white = new Pen(Color.White, 2);
            SolidBrush brush = new SolidBrush(Color.Black);

            VL0 = new int[VL.Length][];
            for (int i = 0; i < VL.Length; i++)
                VL0[i] = new int[VL[i].Length];
            int sum = 1;
            for (int i = 0; i < VL0.Length; i++)
                for (int j = 0; j < VL0[i].Length; j++)
                {
                    VL0[i][j] = sum;
                    sum++;
                }

            External0 = new int[VL0.Length][];
            for (int i = 0; i < VL0.Length; i++)
                External0[i] = new int[VL0.Length];
            sum = 0;
            for (int i = 0; i < VL0.Length; i++)
                for (int j = 0; j < VL0.Length; j++)
                {
                    for (int i1 = 0; i1 < VL0[i].Length; i1++)
                        for (int j1 = 0; j1 < VL0[j].Length; j1++)
                            sum += C0[VL0[i][i1] - 1][VL0[j][j1] - 1];
                    External0[i][j] = sum;
                    sum = 0;
                }
            sum = 0;
            for (int i = 0; i < External0.Length; i++)
                for (int j = 0; j < i; j++)
                    sum += External0[i][j];
            textBox1.Text = sum.ToString();

            list0 = new List<int[][]>();
            for(int e = 0; e < VL0.Length; e++)
            {
                int[][] c = new int[VL0[e].Length][];
                for (int i = 0; i < VL0[e].Length; i++)
                    c[i] = new int[VL0[e].Length];

                for (int i = 0; i < VL0[e].Length; i++)
                    for (int j = 0; j < VL0[e].Length; j++)
                        c[i][j] = C0[i][j];
                list0.Add(c);

                int[][] T = new int[C0.Length - VL0[e].Length][];
                for (int i = 0; i < C0.Length - VL0[e].Length; i++)
                    T[i] = new int[C0.Length - VL0[e].Length];

                for (int i = 0; i < C0.Length - VL0[e].Length; i++)
                    for (int j = 0; j < C0.Length - VL0[e].Length; j++)
                        T[i][j] = C0[i + VL0[e].Length][j + VL0[e].Length];

                C0 = new int[T.Length][];
                for (int i = 0; i < T.Length; i++)
                    C0[i] = new int[T.Length];

                for (int i = 0; i < T.Length; i++)
                    for (int j = 0; j < T.Length; j++)
                        C0[i][j] = T[i][j];
            }

            DrawR(pen_black, Graph, pictureBox2, External0);

            for (int i = 0; i < VL.Length; i++)
                DrawC(pen_black, brush, Graph, i, list0[i], VL0[i], pictureBox2);
        }

        void Picture_After()
        {
            Bitmap Field = new Bitmap(1000, 1000);
            Graphics Graph = Graphics.FromImage(Field);
            Graph.SmoothingMode = SmoothingMode.AntiAlias;
            pictureBox1.Image = Field;
            Pen pen_black = new Pen(Color.Black, 2);
            Pen pen_white = new Pen(Color.White, 2);
            SolidBrush brush = new SolidBrush(Color.Black);

            VL = Quantity.VL;
            list = Quantity.list;

            
            External0 = new int[VL.Length][];
            for (int i = 0; i < VL.Length; i++)
                External0[i] = new int[VL.Length];

            int sum = 0;
            for (int i = 0; i < VL.Length; i++)
                for (int j = 0; j < VL.Length; j++)
                {
                    for (int i1 = 0; i1 < VL[i].Length; i1++)
                        for (int j1 = 0; j1 < VL[j].Length; j1++)
                            sum += C0[VL[i][i1] - 1][VL[j][j1] - 1];
                    External0[i][j] = sum;
                    sum = 0;
                }



            sum = 0;
            for (int i = 0; i < External0.Length; i++)
                for (int j = 0; j < i; j++)
                    sum += External0[i][j];
            textBox2.Text = sum.ToString();

            DrawR(pen_black, Graph, pictureBox1, External0);

            for (int i = 0; i < VL.Length; i++)
                DrawC(pen_black, brush, Graph, i, list[i], VL[i], pictureBox1);
        }




        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form3_FormClosed);
            Show();
            Picture_After();
            Picture_Before();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            form4 = new Form4();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form4.Show();
            button1.Enabled = false;
        }
    }
}
