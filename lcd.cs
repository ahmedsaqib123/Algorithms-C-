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
    public partial class lcd : Form
    {
            static int max_ref; 

            static int _lis(int[] arr, int n)
            {
      
                if (n == 1)
                    return 1;

      
                int res, max_ending_here = 1;

           
                for (int i = 1; i < n; i++)
                {
                    res = _lis(arr, i);
                    if (arr[i - 1] < arr[n - 1] && res + 1 > max_ending_here)
                    {
                        max_ending_here = res + 1;
                    }
                        
                }

               
                if (max_ref < max_ending_here)
                    max_ref = max_ending_here;

      
                return max_ending_here;
            }


        static int lis(int[] arr, int n)
        {

            max_ref = 1;
         


                _lis(arr,n);

                return max_ref;
            }
            public lcd()
            {
            InitializeComponent();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"longinc.txt";
            string line;
            int randomNumber=0;
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
            //int[] arr= new int[] { };
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
            //label5.Text = arr[count].ToString();
            //label5.Text = arr.ToString();
            
            label5.Text=("Longest Increasing Subsequence= " + lis(arr.ToArray(), count).ToString());
            label5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void lcd_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
