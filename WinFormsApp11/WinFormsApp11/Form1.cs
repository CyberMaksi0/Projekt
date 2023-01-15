using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public class Dane
        {
            public string[] Tablica = File.ReadAllLines("C:\\Users\\Admin\\source\\repos\\WinFormsApp11\\WinFormsApp11\\TextFile1.txt").ToArray();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dane y = new Dane();
            MyMessageBox x = new MyMessageBox();
            x.label1.Text = y.Tablica[0];
            x.label2.Text = y.Tablica[1];
            x.label3.Text = y.Tablica[2];
            x.label4.Text = y.Tablica[3];
            x.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Dane y = new Dane();
            MyMessageBox x = new MyMessageBox();
            x.label1.Text = y.Tablica[4];
            x.label2.Text = y.Tablica[5];
            x.label3.Text = y.Tablica[6];
            x.label4.Text = y.Tablica[7];
            x.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Dane y = new Dane();
            MyMessageBox x = new MyMessageBox();
            x.label1.Text = y.Tablica[8];
            x.label2.Text = y.Tablica[9];
            x.label3.Text = y.Tablica[10];
            x.label4.Text = y.Tablica[11];
            x.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Dane y = new Dane();
            MyMessageBox x = new MyMessageBox();
            x.label1.Text = y.Tablica[12];
            x.label2.Text = y.Tablica[13];
            x.label3.Text = y.Tablica[14];
            x.label4.Text = y.Tablica[15];
            x.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Dane y = new Dane();
            MyMessageBox x = new MyMessageBox();
            x.label1.Text = y.Tablica[16];
            x.label2.Text = y.Tablica[17];
            x.label3.Text = y.Tablica[18];
            x.label4.Text = y.Tablica[19];
            x.Show();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}