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
    public partial class ld : Form
    {
        static int min(int x, int y, int z)
        {
            if (x <= y && x <= z)
                return x;
            if (y <= x && y <= z)
                return y;
            else
                return z;
        }

        static int editDistDP(String str1, String str2, int m,
                              int n)
        {
            int[,] dp = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0)
                        dp[i, j] = j;

                    else if (j == 0)

                        dp[i, j] = i;

                    else if (str1[i - 1] == str2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1];

                    else
                        dp[i, j] = 1+ min(dp[i, j - 1], dp[i - 1, j], dp[i - 1,j - 1]); 
                }
            }

            return dp[m, n];
        }
        public ld()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"editdistance.txt";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            string s1 = listBox1.Text;
            string s2 = listBox2.Text;
            int x = s1.Length;
            int y = s2.Length;

           // MessageBox.Show(x.ToString()); MessageBox.Show(y.ToString());

            label5.Text = "Edit Distance is" + " " + editDistDP(s1, s2,x ,y);
            label5.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
