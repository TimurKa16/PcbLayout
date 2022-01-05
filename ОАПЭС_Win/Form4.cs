using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОАПЭС_Win
{
    public partial class Form4 : Form
    {
        public static string s { get; set; }

        public Form4()
        {
            this.FormClosed += new FormClosedEventHandler(Form4_FormClosed);
            InitializeComponent();
            s = Quantity.s;
            richTextBox1.AppendText(s);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
