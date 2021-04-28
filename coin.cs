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
    public partial class coin : Form
    {
        static int count(int[] S, int m, int n)
        {
           
            if (n == 0)
                return 1;

           
            if (n < 0)
                return 0;

            
            if (m <= 0 && n >= 1)
                return 0;

          
            return count(S, m - 1, n) +
                count(S, m, n - S[m - 1]);
        }
        public coin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counter = 0;
            List<int> arr = new List<int>();
            string path = @"coin.txt";
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
                counter++;
            }

            int n = 279; //last 3 digits of roll number

            label5.Text = count(arr.ToArray(), counter, n).ToString();

            label5.Visible = true;
        }
    }
}
