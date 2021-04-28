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
    public partial class knap : Form
    {
        static int knapSack(int W, int[] wt, int[] val, int n)
        {

            if (n == 0 || W == 0)
                return 0;

            if (wt[n - 1] > W)
                return knapSack(W, wt, val, n - 1);

            else
                return Math.Max(val[n - 1]+ knapSack(W - wt[n - 1], wt,val, n - 1), knapSack(W, wt, val, n - 1));
        }
        public knap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"knap1.txt";
            string line;
            int randomNumber = 0;
            Random rand = new Random();
            System.IO.File.WriteAllText(path, string.Empty);

            int randomNumber1 = 0;
            Random rand1 = new Random();
            randomNumber1 = rand1.Next(30, 101);

            for (int j = 1; j <= 15; j++)
            {
                for (int i = 1; i <= randomNumber1; i++)
                {
                    randomNumber = rand.Next(0, 101);
                }
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(randomNumber.ToString());
                }
            }
            int count = 0;
            List<int> arr = new List<int>();
            
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

            string path1 = @"knap2.txt";
            string line1;

            int randomNumber2 = 0;
            Random rand2 = new Random();
            System.IO.File.WriteAllText(path1, string.Empty);

            int randomNumber3 = 0;
            Random rand3 = new Random();
            randomNumber3 = rand3.Next(30, 101);

            for (int j = 1; j <= 15; j++)
            {
                for (int i = 1; i <= randomNumber3; i++)
                {
                    randomNumber2 = rand2.Next(0, 101);
                }
                using (StreamWriter writer = new StreamWriter(path1, true))
                {
                    writer.WriteLine(randomNumber2.ToString());
                }
            }


            int count1 = 0;
            List<int> arr1 = new List<int>();
            
            line1 = File.ReadAllText(path1);
            label2.Text = line1;
            label2.Visible = true;


            System.IO.StreamReader sr1 = new System.IO.StreamReader(path1);
            string data1 = sr1.ReadLine();
            while (data1 != null)
            {
                arr1.Add(int.Parse(data1));
                data1 = sr1.ReadLine();
                count1++;
            }

            int W = 50;

            int res= (knapSack(W, arr1.ToArray(), arr.ToArray(), count));
            label5.Text = res.ToString();
            label5.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
