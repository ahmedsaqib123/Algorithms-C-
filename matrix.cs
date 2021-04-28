using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AlgorithmProject
{
    public partial class matrix : Form
    {
        static int matrix_chain(int[] p, int i, int j)
        {
                if (i == j)
                return 0;

            int min = int.MaxValue;

            for (int k = i; k < j; k++)
            {
                int count = matrix_chain(p, i, k) + matrix_chain(p, k + 1, j) + p[i - 1] * p[k] * p[j];
                if (count < min)
                    min = count;
            }

            
            return min;
        }
        public matrix()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            List<int> arr = new List<int>();
            string path = @"matrix.txt";
            string line;
            line = File.ReadAllText(path);
            label1.Text = line;
            label1.Visible = true;


            System.IO.StreamReader sr = new System.IO.StreamReader(path);
            string data = sr.ReadLine();
            while (data != null)
            {
                arr.Add(int.Parse(data));
                data = sr.ReadLine();
                count++;
            }
            

            label5.Text = ("Minimum Number Of Multiplications= " + matrix_chain(arr.ToArray(),1, count-1).ToString());
            label5.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
