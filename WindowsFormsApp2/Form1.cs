﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsN1VeX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать))");
        }





        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.citilink.ru/catalog/computers_and_notebooks/parts/motherboards/?gclid=EAIaIQobChMIw9zRi4GP7gIVAt-yCh0d3QwHEAAYASAAEgI_4fD_BwE");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Корпуса");
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Видеократы");
            f.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Блок питания");
            f.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Процессоры");
            f.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            CategoryForm f = new CategoryForm("Охлаждение");
            f.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Оперативная память");
            f.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Охлаждение");
            f.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Охлаждение");
            f.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Охлаждение");
            f.Show();
        }



    }
}
