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

    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            lblTitle.Text = "Longest Common Subsequence";
            this.panel4.Controls.Clear();
            lcs Scs_v = new lcs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Scs_v.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(Scs_v);
            Scs_v.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

 

        public void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Longest Common Subsequence";
            this.panel4.Controls.Clear();
            lcs Lcs_v = new lcs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Lcs_v.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(Lcs_v);
            Lcs_v.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Shortest Common Subsequence";
            this.panel4.Controls.Clear();
            scs scs_v = new scs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            scs_v.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(scs_v);
            scs_v.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Levenshtein Distance";
            this.panel4.Controls.Clear();
            ld ld_v = new ld() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ld_v.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(ld_v);
            ld_v.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Longest Increasing Subsequence";
            this.panel4.Controls.Clear();
            lcd lcd_v = new lcd() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lcd_v.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(lcd_v);
            lcd_v.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Matrix Chain Multiplication";
            this.panel4.Controls.Clear();
            matrix mat_v = new matrix() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            mat_v.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(mat_v);
            mat_v.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Partition Problem";
            this.panel4.Controls.Clear();
            part part_v = new part() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            part_v.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(part_v);
            part_v.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Coin-Change Problem";
            this.panel4.Controls.Clear();
            coin coin_v = new coin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            coin_v.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(coin_v);
            coin_v.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "0-1 KnapSack Problem";
            this.panel4.Controls.Clear();
            knap knap_v = new knap() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            knap_v.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(knap_v);
            knap_v.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Rod Cutting Problem";
            this.panel4.Controls.Clear();
            rod rod_v = new rod() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            rod_v.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(rod_v);
            rod_v.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Word Break Problem";
            this.panel4.Controls.Clear();
            word word_v = new word() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            word_v.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(word_v);
            word_v.Show();
        }
    }
}
