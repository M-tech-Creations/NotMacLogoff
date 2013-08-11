using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;  


namespace NotMacLogoff
{
    public partial class Form1 : Form
    {
        int time = 30;//time delay for loging out
        public Form1()
        {
            
            InitializeComponent();
            label1.Font = new Font("Tahoma", 12.0F);//changes defult size of text in the label
            label1.Text = "Are you sure that You want to Logout Now?";//sets labels test
            label2.Text = "You will be automatically loged out in";
            label3.Text = time.ToString();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)//logout button
        {
            System.Diagnostics.Process.Start("logoff");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//for quiting the app
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                time = time - 1;
                label3.Text = time.ToString() +" seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                label3.Text = "Time's up!";
                System.Diagnostics.Process.Start("logoff");
                this.Close();
            }

        }
    }
}
