using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacesWindowsForm
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //label 2/3/4 -> textBox 1,4,5 -> 2,3 (area,perim)
        private void button1_Click(object sender, EventArgs e)
        {
            //Square   
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            textBox1.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = false;
            textBox1.Text = "";
            textBox4.Text = "";
            label2.Text = "Height";
            label3.Text = "Width";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Circle
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox1.Text = "";
            label2.Text = "Radius";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Triangle
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label2.Text = "Side 1";
            label3.Text = "Side 2";
            label4.Text = "Side 3";
            textBox1.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label2.Text.Equals("Height"))
            {
                Rectangle rec = new Rectangle();
                rec.height =  Double.Parse(textBox1.Text.ToString());
                rec.width = Double.Parse(textBox4.Text);
                textBox2.Text = rec.Area().ToString();
                textBox3.Text = rec.perimeter().ToString();
            }
            else if (label2.Text.Equals("Radius"))
            {
                Circle circle = new Circle();
                circle.radius = Double.Parse(textBox1.Text.ToString());
                textBox2.Text = circle.Area().ToString();
                textBox3.Text = circle.perimeter().ToString();
            }
            else if (label2.Text.Equals("Side 1"))
            {
                Triangle triangle = new Triangle();
                triangle.sideOne = Double.Parse(textBox1.Text.ToString());
                triangle.sideTwo = Double.Parse(textBox4.Text.ToString());
                triangle.sideThree = Double.Parse(textBox5.Text.ToString());
                textBox2.Text = triangle.Area().ToString();
                textBox3.Text = triangle.perimeter().ToString();
            }

        }
    }
}
