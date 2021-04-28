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
    public partial class rod : Form
    {
        static int rod_cutting(int len, int[] lens, int[] price, int n)
        {

            if (n == 0 || len == 0)
                return 0;

            if (lens[n - 1] > len)
                return rod_cutting(len, lens, price, n - 1);


            else
                return Math.Max(price[n - 1] + rod_cutting(len - lens[n - 1], lens, price, n - 1),rod_cutting(len, lens, price, n - 1));
        }
        public rod()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"rod1.txt";
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


            string path1 = @"rod2.txt";
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

            int len = 50;

            int res = (rod_cutting(len, arr1.ToArray(), arr.ToArray(), count));
            label5.Text = res.ToString();
            label5.Visible = true;
        }
    }
}
