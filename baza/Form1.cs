using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace baza
{
    public partial class Form1 : Form
    {
        public int i = 0;
        public string[] imietab = new string[10];
        public string[] naztab = new string[10];
        public string[] pestab = new string[10];
        public Form1()
        {
            InitializeComponent();
            label8.Visible = false;
            progressBar1.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(index.Text);
            if (pesel.Text.Length != 11) MessageBox.Show("Niepoprawny pesel! (Pesel ma 11 cyfr)");
            if (n == 11) MessageBox.Show("Baza pełna!");
            else
            {
                string s1 = imie.Text;
                imietab[i] = s1;
                string s2 = nazwisko.Text;
                naztab[i] = s2;
                string s3 = pesel.Text;
                pestab[i] = s3;
                string text;
                switch (n)
                {
                    case 1:
                        progressBar1.Visible = true;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 0;
                        text = " ";
                        text = text + index.Text;
                        //
                        progressBar1.Value = 33;
                        for (int j = 0; j < 8 - index.Text.Length; j++) text = text + " ";
                        text = text + imietab[i];
                        //

                        progressBar1.Value = 66;
                        for (int j = 0; j < 25 - imietab[i].Length; j++) text = text + " ";
                        text = text + naztab[i];
                        //
                        for (int j = 0; j < 29 - naztab[i].Length; j++) text = text + " ";
                        text = text + pestab[i];
                        textBox4.Text = text;
                        progressBar1.Value = 100;
                        label8.Visible = true;
                        break;

                    case 2:

                        label8.Visible = false;
                        progressBar1.Visible = true;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 0;
                        text = " ";
                        text = text + index.Text;
                        //
                        progressBar1.Value = 33;
                        for (int j = 0; j < 8 - index.Text.Length; j++) text = text + " ";
                        text = text + imietab[i];
                        
                        //

                        progressBar1.Value = 66;
                        for (int j = 0; j < 25 - imietab[i].Length; j++) text = text + " ";
                        text = text + naztab[i];
                        
                        //
                        for (int j = 0; j < 29 - naztab[i].Length; j++) text = text + " ";
                        text = text + pestab[i];
                        
                        textBox5.Text = text;
                        progressBar1.Value = 100;
                        label8.Visible = true;
                        break;
                    case 3:

                        label8.Visible = false;
                        progressBar1.Visible = true;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 0;
                        text = " ";
                        text = text + index.Text;
                        //
                        progressBar1.Value = 33;
                        for (int j = 0; j < 8 - index.Text.Length; j++) text = text + " ";
                        text = text + imietab[i];
                        
                        //

                        progressBar1.Value = 66;
                        for (int j = 0; j < 25 - imietab[i].Length; j++) text = text + " ";
                        text = text + naztab[i];
                        
                        //
                        for (int j = 0; j < 29 - naztab[i].Length; j++) text = text + " ";
                        text = text + pestab[i];
                        
                        textBox6.Text = text;
                        progressBar1.Value = 100;
                        label8.Visible = true;
                        break;
                    case 4:

                        label8.Visible = false;
                        progressBar1.Visible = true;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 0;
                        text = " ";
                        text = text + index.Text;
                        //
                        progressBar1.Value = 33;
                        for (int j = 0; j < 8 - index.Text.Length; j++) text = text + " ";
                        text = text + imietab[i];
                        
                        //

                        progressBar1.Value = 66;
                        for (int j = 0; j < 25 - imietab[i].Length; j++) text = text + " ";
                        text = text + naztab[i];
                        
                        //
                        for (int j = 0; j < 29 - naztab[i].Length; j++) text = text + " ";
                        text = text + pestab[i];
                        
                        textBox7.Text = text;
                        progressBar1.Value = 100;
                        label8.Visible = true;
                        break;
                    case 5:

                        label8.Visible = false;
                        progressBar1.Visible = true;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 0;
                        text = " ";
                        text = text + index.Text;
                        //
                        progressBar1.Value = 33;
                        for (int j = 0; j < 8 - index.Text.Length; j++) text = text + " ";
                        text = text + imietab[i];
                        
                        //

                        progressBar1.Value = 66;
                        for (int j = 0; j < 25 - imietab[i].Length; j++) text = text + " ";
                        text = text + naztab[i];
                        
                        //
                        for (int j = 0; j < 29 - naztab[i].Length; j++) text = text + " ";
                        text = text + pestab[i];
                        
                        textBox8.Text = text;
                        progressBar1.Value = 100;
                        label8.Visible = true;
                        break;
                    case 6:

                        label8.Visible = false;
                        progressBar1.Visible = true;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 0;
                        text = " ";
                        text = text + index.Text;
                        //
                        progressBar1.Value = 33;
                        for (int j = 0; j < 8 - index.Text.Length; j++) text = text + " ";
                        text = text + imietab[i];
                        
                        //

                        progressBar1.Value = 66;
                        for (int j = 0; j < 25 - imietab[i].Length; j++) text = text + " ";
                        text = text + naztab[i];
                        
                        //
                        for (int j = 0; j < 29 - naztab[i].Length; j++) text = text + " ";
                        text = text + pestab[i];
                        
                        textBox9.Text = text;
                        progressBar1.Value = 100;
                        label8.Visible = true;
                        break;
                    case 7:

                        label8.Visible = false;
                        progressBar1.Visible = true;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 0;
                        text = " ";
                        text = text + index.Text;
                        //
                        progressBar1.Value = 33;
                        for (int j = 0; j < 8 - index.Text.Length; j++) text = text + " ";
                        text = text + imietab[i];
                        
                        //

                        progressBar1.Value = 66;
                        for (int j = 0; j < 25 - imietab[i].Length; j++) text = text + " ";
                        text = text + naztab[i];
                        
                        //
                        for (int j = 0; j < 29 - naztab[i].Length; j++) text = text + " ";
                        text = text + pestab[i];
                        
                        textBox10.Text = text;
                        progressBar1.Value = 100;
                        label8.Visible = true;
                        break;
                    case 8:

                        label8.Visible = false;
                        progressBar1.Visible = true;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 0;
                        text = " ";
                        text = text + index.Text;
                        //
                        progressBar1.Value = 33;
                        for (int j = 0; j < 8 - index.Text.Length; j++) text = text + " ";
                        text = text + imietab[i];
                        
                        //

                        progressBar1.Value = 66;
                        for (int j = 0; j < 25 - imietab[i].Length; j++) text = text + " ";
                        text = text + naztab[i];
                        
                        //
                        for (int j = 0; j < 29 - naztab[i].Length; j++) text = text + " ";
                        text = text + pestab[i];
                        
                        textBox11.Text = text;
                        progressBar1.Value = 100;
                        label8.Visible = true;
                        break;
                    case 9:

                        label8.Visible = false;
                        progressBar1.Visible = true;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 0;
                        text = " ";
                        text = text + index.Text;
                        //
                        progressBar1.Value = 33;
                        for (int j = 0; j < 8 - index.Text.Length; j++) text = text + " ";
                        text = text + imietab[i];
                        
                        //

                        progressBar1.Value = 66;
                        for (int j = 0; j < 25 - imietab[i].Length; j++) text = text + " ";
                        text = text + naztab[i];
                        
                        //
                        for (int j = 0; j < 29 - naztab[i].Length; j++) text = text + " ";
                        text = text + pestab[i];
                        
                        textBox12.Text = text;
                        progressBar1.Value = 100;
                        label8.Visible = true;
                        break;
                    case 10:

                        label8.Visible = false;
                        progressBar1.Visible = true;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 0;
                        text = " ";
                        text = text + index.Text;
                        //
                        progressBar1.Value = 33;
                        for (int j = 0; j < 7 - index.Text.Length; j++) text = text + " ";
                        text = text + imietab[i];
                        
                        //

                        progressBar1.Value = 66;
                        for (int j = 0; j < 25 - imietab[i].Length; j++) text = text + " ";
                        text = text + naztab[i];
                        
                        //
                        for (int j = 0; j < 29 - naztab[i].Length; j++) text = text + " ";
                        text = text + pestab[i];
                        
                        textBox13.Text = text;
                        progressBar1.Value = 100;
                        label8.Visible = true;
                        break;
                }

                i++;
                int z = i+1;
                index.Text = z.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void Export_Click(object sender, EventArgs e)
        {
            int i = 0;
            FileStream plik1 = new FileStream("baza.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter zapis = new StreamWriter(plik1);
            if (String.IsNullOrEmpty(imietab[i])) MessageBox.Show("Pusta baza!");
            else
            {
                while(true)
                {
                    zapis.WriteLine("{0} {1} {2} {3}", i+1, imietab[i], naztab[i], pestab[i]);
                    if (i + 1 == 10) break;
                    if (String.IsNullOrEmpty(imietab[i+1])) break;
                    i++;
                }
            }
            zapis.Close();
            plik1.Close();
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trybCiemnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray  ;
            this.index.BackColor = Color.LightGray;
            this.imie.BackColor = Color.LightGray;
            this.nazwisko.BackColor = Color.LightGray;
            this.pesel.BackColor = Color.LightGray;
            this.textBox1.BackColor = Color.LightGray;
            this.textBox2.BackColor = Color.LightGray;
            this.textBox3.BackColor = Color.LightGray;
            this.textBox4.BackColor = Color.LightGray;
            this.textBox5.BackColor = Color.LightGray;
            this.textBox6.BackColor = Color.LightGray;
            this.textBox7.BackColor = Color.LightGray;
            this.textBox8.BackColor = Color.LightGray;
            this.textBox9.BackColor = Color.LightGray;
            this.textBox10.BackColor = Color.LightGray;
            this.textBox11.BackColor = Color.LightGray;
            this.textBox12.BackColor = Color.LightGray;
            this.textBox13.BackColor = Color.LightGray;
            this.textBox14.BackColor = Color.LightGray;

        }

        private void trybJasnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.index.BackColor = Color.White;
            this.imie.BackColor = Color.White;
            this.nazwisko.BackColor = Color.White;
            this.pesel.BackColor = Color.White;
            this.textBox1.BackColor = Color.White;
            this.textBox2.BackColor = Color.White;
            this.textBox3.BackColor = Color.White;
            this.textBox4.BackColor = Color.White;
            this.textBox5.BackColor = Color.White;
            this.textBox6.BackColor = Color.White;
            this.textBox7.BackColor = Color.White;
            this.textBox8.BackColor = Color.White;
            this.textBox9.BackColor = Color.White;
            this.textBox10.BackColor = Color.White;
            this.textBox11.BackColor = Color.White;
            this.textBox12.BackColor = Color.White;
            this.textBox13.BackColor = Color.White;
            this.textBox14.BackColor = Color.White;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {

        }

        private void ankietaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
        }
    }
}
