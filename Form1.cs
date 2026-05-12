using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiard_club
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnligthtable1.FillColor = Color.Red;
            decimal price1 = (NUpD1.Value / 60) * F2.price;
            labprice1.Text = Convert.ToString(price1) + " $";
            label6.Text = Convert.ToString(NUpD1.Value);
            timer1.Enabled = true;
            guna2CircleProgressBar1.Maximum = Convert.ToInt32(NUpD1.Value);
            btnT1.Enabled= true;
            btnW1.Enabled= true;
            label7.Text = "00";
            guna2CircleProgressBar1.Value = 0;

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form f2 = new F2();
            f2.ShowDialog();
        }



        private void guna2CircleButton2_Click_1(object sender, EventArgs e)
        {
            labpricehour.Text = Convert.ToString(F2.price) + " $";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Secound1();
        }
        void Secound1()
        {
            if (label7.Text == "00")
            {
                Minutes1();
                label7.Text = "59";
            }
            else
            {
                int s = Convert.ToInt32(label7.Text) - 1;
                if (s < 10)
                    label7.Text = "0" + Convert.ToString(s);
                else
                    label7.Text = Convert.ToString(s);
            }
        }

        void Minutes1()
        {
            if (label6.Text == "00")
            {
                guna2CircleProgressBar1.Value += 1;
                timer1.Enabled = false;
                guna2TextBox1.Text = "";
                btnligthtable1.FillColor = Color.Green;
                label6.Text = "00";
                label7.Text = "00";
                labprice1.Text = "0 $";
                guna2CircleProgressBar1.Value = 0;
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                int m = Convert.ToInt32(label6.Text) - 1;
                if (m < 10)
                    label6.Text = "0" + Convert.ToString(m);
                else
                    label6.Text = Convert.ToString(m);

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnligthtable1.FillColor = Color.Yellow;

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnligthtable1.FillColor = Color.Red;
        }
        //===============================Table2======================================
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            btnligthtable2.FillColor = Color.Red;
            decimal price1 = (NUpD2.Value / 60) * F2.price;
            labprice2.Text = Convert.ToString(price1) + " $";
            label9.Text = Convert.ToString(NUpD2.Value);
            timer2.Enabled = true;
            guna2CircleProgressBar2.Maximum = Convert.ToInt32(NUpD2.Value);
            btnT2.Enabled = true;
            btnW2.Enabled = true;
            label11.Text = "00";
            guna2CircleProgressBar2.Value = 0;


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Secound2();
        }
        void Secound2()
        {
            if (label11.Text == "00")
            {
                Minutes2();
                label11.Text = "59";
            }
            else
            {
                int s = Convert.ToInt32(label11.Text) - 1;
                if (s < 10)
                    label11.Text = "0" + Convert.ToString(s);
                else
                    label11.Text = Convert.ToString(s);

            }
        }
        void Minutes2()
        {
            if (label9.Text == "00")
            {
                guna2CircleProgressBar2.Value += 1;
                timer2.Enabled = false;
                guna2TextBox2.Text = "";
                btnligthtable2.FillColor = Color.Green;
                label9.Text = "00";
                label11.Text = "00";
                labprice2.Text = "0 $";
                guna2CircleProgressBar2.Value = 0;
            }
            else
            {
                guna2CircleProgressBar2.Value += 1;
                int m = Convert.ToInt32(label9.Text) - 1;
                if (m < 10)
                    label9.Text = "0" + Convert.ToString(m);
                else
                    label9.Text = Convert.ToString(m);

            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            btnligthtable2.FillColor = Color.Yellow;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            btnligthtable2.FillColor = Color.Red;
        }
        //===============================Table3======================================

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            btnligthtable3.FillColor = Color.Red;
            decimal price1 = (NUpD3.Value / 60) * F2.price;
            labprice3.Text = Convert.ToString(price1) + " $";
            label16.Text = Convert.ToString(NUpD3.Value);
            timer3.Enabled = true;
            guna2CircleProgressBar3.Maximum = Convert.ToInt32(NUpD3.Value);
            btnT3.Enabled = true;
            btnW3.Enabled = true;
            label18.Text = "00";
            guna2CircleProgressBar3.Value = 0;


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Secound3();
        }
        void Secound3()
        {
            if (label18.Text == "00")
            {
                Minutes3();
                label18.Text = "59";
            }
            else
            {
                int s = Convert.ToInt32(label18.Text) - 1;
                if (s < 10)
                    label18.Text = "0" + Convert.ToString(s);
                else
                    label18.Text = Convert.ToString(s);

            }
        }
        void Minutes3()
        {
            if (label16.Text == "00")
            {
                guna2CircleProgressBar3.Value += 1;
                timer3.Enabled = false;
                guna2TextBox3.Text = "";
                btnligthtable3.FillColor = Color.Green;
                label16.Text = "00";
                label18.Text = "00";
                labprice3.Text = "0 $";
                guna2CircleProgressBar3.Value = 0;
            }
            else
            {
                guna2CircleProgressBar3.Value += 1;
                int m = Convert.ToInt32(label16.Text) - 1;
                if (m < 10)
                    label16.Text = "0" + Convert.ToString(m);
                else
                    label16.Text = Convert.ToString(m);

            }
        }

        private void btnW3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            btnligthtable3.FillColor = Color.Yellow;
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            btnligthtable3.FillColor = Color.Red;
        }

        //===============================Table4======================================

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            btnligthtable4.FillColor = Color.Red;
            decimal price1 = (NUpD4.Value / 60) * F2.price;
            labprice4.Text = Convert.ToString(price1) + " $";
            label23.Text = Convert.ToString(NUpD4.Value);
            timer4.Enabled = true;
            guna2CircleProgressBar4.Maximum = Convert.ToInt32(NUpD4.Value);
            btnT4.Enabled = true;
            btnW4.Enabled = true;
            label25.Text = "00";
            guna2CircleProgressBar4.Value = 0;

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Secound4();
        }
        void Secound4()
        {
            if (label25.Text == "00")
            {
                Minutes4();
                label25.Text = "59";
            }
            else
            {
                int s = Convert.ToInt32(label25.Text) - 1;
                if (s < 10)
                    label25.Text = "0" + Convert.ToString(s);
                else
                    label25.Text = Convert.ToString(s);

            }
        }
        void Minutes4()
        {
            if (label23.Text == "00")
            {
                guna2CircleProgressBar4.Value += 1;
                timer4.Enabled = false;
                guna2TextBox4.Text = "";
                btnligthtable4.FillColor = Color.Green;
                label23.Text = "00";
                label25.Text = "00";
                labprice4.Text = "0 $";
                guna2CircleProgressBar4.Value = 0;
            }
            else
            {
                guna2CircleProgressBar4.Value += 1;
                int m = Convert.ToInt32(label23.Text) - 1;
                if (m < 10)
                    label23.Text = "0" + Convert.ToString(m);
                else
                    label23.Text = Convert.ToString(m);
            }
        }

        private void btnW4_Click(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            btnligthtable4.FillColor = Color.Yellow;
        }

        private void btnT4_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            btnligthtable4.FillColor = Color.Red;
        }
    }
}
