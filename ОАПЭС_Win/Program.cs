using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ОАПЭС_Win
{
    public static class Quantity
    {
        public static int V { get; set; }               // Количество вершин
        public static int L { get; set; }               // Количество кусков
        public static int[][] VL { get; set; }          // Количество вершин в каждом куске
        public static int[][] C { get; set; }           // Матрица смежности
        public static List<int[][]> list { get; set; }  // Набор матриц смежности в кусках
        public static int[][] External { get; set; }    // Матрица внешних связей
        public static string s { get; set; }
    }

    static class Algorithm
    {
        static public int[] Alpha { get; set; }
        static public int[][] W { get; set; }
        static public int l { get; set; }
        static public int index_1 { get; set; }
        static public int index_2 { get; set; }
        static public int element { get; set; }
        static public int[] Rest_Vertexes { get; set; }
        static public int[][] VL { get; set; }
        static public int[][] C { get; set; }
        static public int V { get; set; }
        static public List<int[][]> list { get; set; }
        static public int[][] External { get; set; }

        public static int[][] C0 { get; set; }
        public static int[][] VL0 { get; set; }
        public static List<int[][]> list0 { get; set; }
        public static int[][] External0 { get; set; }
        public static string s { get; set; }
        static int[] a;
        static int[] b;


        static public void Create_Vertexes()
        {
            int sum = 1;
            Rest_Vertexes = new int[V];
            for (int i = 0; i < V; i++)
            {
                Rest_Vertexes[i] = sum;
                sum++;
            }
        }

        static public void New_Vertexes(int e)
        {
            for (int i = 0; i < VL[e].Length; i++)
                VL[e][i] = Rest_Vertexes[i];

            int[] T = new int[Rest_Vertexes.Length - VL[e].Length];

            for (int i = 0; i < Rest_Vertexes.Length - VL[e].Length; i++)
                T[i] = Rest_Vertexes[i + VL[e].Length];

            Rest_Vertexes = new int[T.Length];

            for (int i = 0; i < T.Length; i++)
                Rest_Vertexes[i] = T[i];
        }

        static public void Find_Alpha(int count)
        {
            a = new int[C.Length];
                b = new int[C.Length];
            Alpha = new int[C.Length];
            for (int i = 0; i < C.Length; i++)
            {                
                if (i < VL[count].Length)
                {
                    for (int j = 0; j < VL[count].Length; j++)
                        a[i] += C[i][j];
                    for (int j = VL[count].Length; j < C.Length; j++)
                        b[i] += C[i][j];
                }
                else
                {
                    for (int j = VL[count].Length; j < C.Length; j++)
                        a[i] += C[i][j];
                    for (int j = 0; j < VL[count].Length; j++)
                        b[i] += C[i][j];
                }
                Alpha[i] = b[i] - a[i];
            }
        }

        static public bool Find_W_Max(int count)
        {
            element = 0;
            index_1 = 0;
            index_2 = 0;
            for (int i = 0; i < W.Length; i++)
                for (int j = 0; j < W[0].Length; j++)
                    if (element < W[i][j])
                    {
                        element = W[i][j];
                        index_1 = i;
                        index_2 = j + VL[count].Length;
                    }
            if (element > 0) return true;
            else return false;
        }

        static public void Swap()
        {
            int t;
            int[] t1 = new int[C.Length];
            int[] t2 = new int[C.Length];

            for (int i = 0; i < C.Length; i++)
            {
                t1[i] = C[index_1][i];
                t2[i] = C[index_2][i];
            }

            for (int i = 0; i < C.Length; i++)
            {
                C[index_1][i] = t2[i];
                C[i][index_1] = t2[i];
                C[index_2][i] = t1[i];
                C[i][index_2] = t1[i];
            }
            t = Rest_Vertexes[index_1];
            Rest_Vertexes[index_1] = Rest_Vertexes[index_2];
            Rest_Vertexes[index_2] = t;
        }

        static public void Find_W(int count)
        {
            int d = VL[count].Length;
            int e = C.Length - VL[count].Length;
            W = new int[d][];
            for (int i = 0; i < d; i++)
                W[i] = new int[e];
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < e; j++)
                    W[i][j] = Alpha[i] + Alpha[d + j] - 2 * C[i][j + d];
            }
        }

        static public void New_MatrixC(int e)
        {
            int[][] c = new int[VL[e].Length][];
            for (int i = 0; i < VL[e].Length; i++)
                c[i] = new int[VL[e].Length];

            for (int i = 0; i < VL[e].Length; i++)
                for (int j = 0; j < VL[e].Length; j++)
                    c[i][j] = C[i][j];
            list.Add(c);


            int[][] T = new int[C.Length - VL[e].Length][];
            for (int i = 0; i < C.Length - VL[e].Length; i++)
                T[i] = new int[C.Length - VL[e].Length];

            for (int i = 0; i < C.Length - VL[e].Length; i++)
                for (int j = 0; j < C.Length - VL[e].Length; j++)
                    T[i][j] = C[i + VL[e].Length][j + VL[e].Length];

            C = new int[T.Length][];
            for (int i = 0; i < T.Length; i++)
                C[i] = new int[T.Length];

            for (int i = 0; i < T.Length; i++)
                for (int j = 0; j < T.Length; j++)
                    C[i][j] = T[i][j];
        }






        static public void algorithm()
        {
            C = Quantity.C;
            V = Quantity.V;
            VL = Quantity.VL;
            list = new List<int[][]>();
            bool f = true;
            int count;

            s += "Матрица смежности:\n";
            
            Create_Vertexes();
            
            l = VL.Length;
            for (count = 0; count < l - 1; count++)
            {
                while (f)
                {
                    Find_Alpha(count);
                    s += "\t";
                    for (int i = 0; i < Rest_Vertexes.Length; i++)
                    {
                        if (i == VL[count].Length - 1)
                            s += "X" + Rest_Vertexes[i] + "     |\t";
                        else
                            s += "X" + Rest_Vertexes[i] + "\t";
                    }

                    s += "a\tb\talpha\n";

                    for (int i = 0; i < C.Length; i++)
                    {
                        s += "X" + Rest_Vertexes[i] + "\t";
                        for (int j = 0; j < C.Length; j++)
                        {
                            if (j == VL[count].Length - 1)
                                s += C[i][j] + "       |\t";
                            else
                                s += C[i][j] + "\t";
                        }

                            s += a[i] + "\t" + b[i] + "\t" + Alpha[i] + "\n";
                        if (i == VL[count].Length - 1)
                        {
                            for (int i1 = 0; i1 < C.Length; i1++)
                                s += "-----------------";
                            s += "----------------------------------------------------\n";
                        }
                    }
                    Find_W(count);
                    s += "\nМатрица W:\n";
                    for (int i = 0; i < W.Length; i++)
                    {
                        for (int j = 0; j < W[i].Length; j++)
                            s += W[i][j] + "\t";
                        s += "\n";                                                    
                    }

                    if (!Find_W_Max(count))
                    {
                        f = false;
                        break;
                    }
                    s += "\nМаксимальный элемент матрицы W = " + element + "\nМеняем строки " + (index_1 + 1) + " и " + (index_2 + 1) + "\n\n";
                    int I1 = index_1;
                    int I2 = index_2;
                    Swap();
                }
                
                f = true;

                New_Vertexes(count);
                New_MatrixC(count);
                
                s += "\nНет положительных элементов в матрице W, поэтому кусок " + (count + 1) + " сформирован:\n\t";
                for (int i = 0; i < VL[count].Length; i++)
                    s += "X" + VL[count][i] + "\t";
                s += "\n";
                for (int i = 0; i < list[count].Length; i++)
                {
                    s += "X" + VL[count][i] + "\t";
                    for (int j = 0; j < list[count].Length; j++)
                        s += list[count][i][j] + "\t";
                    s += "\n";
                }
                if((count < l - 2))
                    s += "\nОставшийся кусок:\n";                
            }

            New_Vertexes(count);
            New_MatrixC(count);
            s += "Оставшийся " + (count + 1) + "-й кусок:\n\t";
            for (int i = 0; i < VL[count].Length; i++)
                s += "X" + VL[count][i] + "\t";
            s += "\n";
            for (int i = 0; i < list[count].Length; i++)
            {
                s += "X" + VL[count][i] + "\t";
                for (int j = 0; j < list[count].Length; j++)
                    s += list[count][i][j] + "\t";
                s += "\n";
            }
            Quantity.VL = VL;


            //External = new int[VL.Length][];
            //for (int i = 0; i < VL.Length; i++)
            //    External[i] = new int[VL.Length];

            //int sum = 0;
            //for (int i = 0; i < VL.Length; i++)
            //    for (int j = 0; j < VL.Length; j++)
            //    {
            //        for (int i1 = 0; i1 < VL[i].Length; i1++)
            //            for (int j1 = 0; j1 < VL[j].Length; j1++)
            //                sum += C[VL[i][i1] - 1][VL[j][j1] - 1];
            //        External[i][j] = sum;
            //        sum = 0;
            //    }
            //Quantity.External = External;
            Quantity.list = list;           

            Quantity.s = s;

        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
