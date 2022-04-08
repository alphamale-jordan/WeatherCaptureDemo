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

namespace LogInDemo
{
    public partial class Capture : Form 
    {
        public Capture()
        {
            InitializeComponent();
        }
        
               
        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
       {

       }

        private void label2_Click(object sender, EventArgs e)
       {

        }

        private void label1_Click(object sender, EventArgs e)
        {

       }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       private void label3_Click(object sender, EventArgs e)
        {

       }
    
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

       }

      private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
      {

      
  }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
           
            // string path = @"C:\\Users\\Alex Moyo\\source\\repos\\demo Capture\\demo Capture\\DEMO FILE\\demo.txt";
           string path = @"C:\\Users\\Alex Moyo\\source\\repos\\WeatherCaptureDemo\\WeatherCaptureDemo\\Weather file\\weather.txt";
            //using System.IO; grant us permission to use this streamwriter.
            using (StreamWriter alex = new StreamWriter(path, true))
            {
               
                    alex.Write("\n" + "  " + cbCity.Text + ",");
                    alex.Write(" " + Date + ",");
                    alex.Write(" " + txtMin.Text + "°C" + ",");
                    alex.Write(" " + txtMax.Text + "°C" + ",");
                    alex.Write(" " + cbPrec.Text +"%" +",");
                    alex.Write(" " + txtHumi.Text + "%" + ",");
                    alex.Write(" " + txtSpeed.Text + " km/h"+ "\n");

                    MessageBox.Show("Details have been captured successfuly");
                
              
                 
            }
           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string pat = @"C:\\Users\\Alex Moyo\\source\\repos\\WeatherCaptureDemo\\WeatherCaptureDemo\\Weather file\\weather.txt";
            var str = File.ReadAllText(pat);
            richTextBox1.Text = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Find Search = new Find();
            Search.ShowDialog();
        }
    }
}
