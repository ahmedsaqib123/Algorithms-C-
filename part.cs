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
    public partial class part : Form
    {
        static bool find_partition(int[] arr, int n)
        {

            int sum = 0;
            int i, j;


            for (i = 0; i < n; i++)
                sum += arr[i];

            if (sum % 2 != 0)
                return false;

            bool[,] part = new bool[sum / 2 + 1, n + 1];

    
            for (i = 0; i <= n; i++)
                part[0, i] = true;

         
            for (i = 1; i <= sum / 2; i++)
                part[i, 0] = false;

          
            for (i = 1; i <= sum / 2; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    part[i, j] = part[i, j - 1];
                    if (i >= arr[j - 1])
                        part[i, j]= part[i, j - 1] || part[i - arr[j - 1], j - 1];
                }
            }

     

            return part[sum / 2, n];
        }
        public part()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            List<int> arr = new List<int>();
            string path = @"part.txt";
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

            if (find_partition(arr.ToArray(), count) == true)
                label5.Text = "Can be divided into two subsets of equal sum";
            else
                label5.Text = "Can not be divided into two subsets of equal sum";
                label5.Visible = true;
        }
    }
}
