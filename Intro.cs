using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator3000 : Form
    {
        private MainCalc maincalc;
        public Calculator3000()
        {
            InitializeComponent();
            maincalc = new MainCalc();
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
            maincalc.Show();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (DropPan.Height != 50)
            { 
                DropPan.Height = 50;      //menu drop pan
            }

            else
            {
                DropPan.Height = 27;  //if size is different
            }
        }

        private void SurpriseButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I didn't know einstein was a real person, I just thought he was a theoretical physicist..."); //joke when button is clicked in drop pan
        }

        private void Calculator3000_Load(object sender, EventArgs e)
        {

        }
    }
}
