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
    public partial class word : Form
    {
        public static bool word_break(string dict, String str)
        {

            if (str.Length == 0)
            {
                return true;
            }

            for (int i = 1; i <= str.Length; i++)
            {

                string count = str.Substring(0, i);



                if (dict.Contains(count) && word_break(dict, str.Substring(i)))
                {
                    return true;
                }
            }


            return false;
        }

        
       
        public word()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"word.txt";
            char[] letters = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();
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

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void word_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s1 = listBox1.Text;
            string s2 = listBox2.Text;

            if(word_break(s1, s2) == true)
            {
                label5.Text = "True";
                
            }
            else
            {
                label5.Text = "False";
                label5.Visible = true;
            }
        }
    }
}
