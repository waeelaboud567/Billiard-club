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
    public partial class F2 : Form
    {
        public static int price=1;
        public F2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            price=Convert.ToInt32(NUpDown1.Value);
            this.Close();
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
