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
    public partial class lcs : Form
    {
        static int longcs(char[] X, char[] Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1];
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }
            return L[m, n];
        }

       
        
        public lcs()
        {
            InitializeComponent();
        }

        private void scs_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"lcs.txt";
            char[] letters = "ahmedkashish".ToCharArray();
            Random r = new Random();
            string randomString = "";
            System.IO.File.WriteAllText(path, string.Empty);
            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 30; i++)
                {
                    randomString += letters[r.Next(0, 12)].ToString();
                }
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(randomString);
                }
            }

            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
                counter++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s1 = listBox1.Text;
            string s2 = listBox2.Text;
            char[] X = s1.ToCharArray();
            char[] Y = s2.ToCharArray();
            int m = X.Length;
            int n = Y.Length;


            label5.Text = "Length of LCS is" + " " + longcs(X, Y, m, n);
            label5.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
