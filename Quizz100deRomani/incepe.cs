using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz100deRomani
{
    public partial class pornire : Form
    {
        public pornire()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            QUIZZ f2 = new QUIZZ();
            f2.Show();
            this.Close();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pornire_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}