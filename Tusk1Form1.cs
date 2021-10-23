using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(Triangle.checkSides(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)))
            {
                Triangle triangle = new Triangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                label4.Text = "Трикутник створено!";
            }
            else
            {
                label4.Text = "Трикутник не створено!";
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (Triangle.checkSides(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)))
            {
                Triangle triangle = new Triangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                label5.Text = "Кути визначено:";
                List<double> angles = triangle.determineAngles();
                label6.Text = angles[1].ToString();
                label7.Text = angles[0].ToString();
                label8.Text = angles[2].ToString();
            }
            else
            {
                label5.Text = "Трикутник не створено!";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Triangle.checkSides(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)))
            {
                Triangle triangle = new Triangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                label13.Text = "Периметр визначено:";
                label14.Text = triangle.determinePerimeter().ToString();
            }
            else
            {
                label13.Text = "Трикутник не створено!";
                label14.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Triangle.checkSides(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)))
            {
                if(Convert.ToDouble(textBox1.Text) == Convert.ToDouble(textBox2.Text) && Convert.ToDouble(textBox2.Text) == Convert.ToDouble(textBox3.Text))
                {
                    label15.Text = "Трикутник рівносторонній!";
                    EquilateralTriangle eTriangle = new EquilateralTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                    label17.Text = eTriangle.determineArea().ToString();
                }
                else
                {
                    label15.Text = "Трикутник не є рівностороннім!";
                    label17.Text = "";
                }
            }
            else
            {
                label15.Text = "Трикутник не створено!";
                label17.Text = "";
            }
        }
    }
}
