/*
Programmer: Cody Griffin
Date: 4/1/2016
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //Variables
            double radius = Convert.ToInt32(radiusTextBox.Text);
            const double pi = 3.14;
            double area = pi * (radius * radius);
            double circumference = 2 * pi * radius;

            //Prints area and circumference to their respective text boxes
            areaTextBox.Text = Convert.ToString(area);
            circTextBox.Text = Convert.ToString(circumference);
        }//end enterButton_Click
    }
}//end GraphicalCircle
