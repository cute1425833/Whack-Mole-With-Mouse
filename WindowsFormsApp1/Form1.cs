using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
          public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
            label5.Text = "20";
            label6.Text = "0";
            a = 0;
            pictureBox1.Enabled = true;

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
          
          label5.Text =Convert.ToString(Convert.ToInt32(label5.Text)-1);
            if (label5.Text == "0")
            {
                timer1.Enabled = false;
                MessageBox.Show("時間到!!");
                pictureBox1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }
        int a = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            label6.Text = Convert.ToString(a++);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           pictureBox1.Enabled = false;
            
        }
    }
}
