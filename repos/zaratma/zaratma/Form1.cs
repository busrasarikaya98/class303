﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaratma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = false;
        }
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int zar1, zar2;
            Random rnd = new Random();
            zar1 = rnd.Next(0, 6); //0 dahil 6 değil 6 indexten birini tutacak yani 6 fotodan birini
            zar2 = rnd.Next(0, 6);
            pictureBox1.Image = ımageList1.Images[zar1];
            pictureBox2.Image = ımageList1.Images[zar2];
            sayac++;
            if (sayac == 10)
            {
                timer1.Stop();
                sayac = 0;
                button2.Enabled = true;
            }
        }
    }
}
