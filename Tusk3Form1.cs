using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Прямокутний")
            {
                label2.Text = "Введіть дані для створення прямокутного трикутника:";
                label3.Text = "Перший катет:";
                label4.Text = "Другий катет:";
            }
            else if(textBox1.Text == "Рівнобедренний" )
            {
                label2.Text = "Введіть дані для створення рівнобедренного трикутника:";
                label3.Text = "Сторона:";
                label4.Text = "Кут у градусах:";
            } 
            else
            {
                label2.Text = "Вид трикутника вказаний не правильно!";
                label3.Text = "";
                label4.Text = "";
            }
        }

        private void area_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Прямокутний")
            {
                RightTriangle triangle = new RightTriangle(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                label6.Text = triangle.area().ToString();
                label5.Text = "Площа:";
            }
            else if(textBox1.Text == "Рівнобедренний")
            {
                EquilateralTriangle triangle = new EquilateralTriangle(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                label6.Text = triangle.area().ToString();
                label5.Text = "Площа:";
            } else
            {
                label6.Text = "Не правильно вказано вид трикутника!";
                label5.Text = "";
            }
        }

        private void perimeter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Прямокутний")
            {
                RightTriangle triangle = new RightTriangle(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                label8.Text = triangle.perimeter().ToString();
                label7.Text = "Периметр:";
            }
            else if (textBox1.Text == "Рівнобедренний")
            {
                EquilateralTriangle triangle = new EquilateralTriangle(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                label8.Text = triangle.perimeter().ToString();
                label7.Text = "Периметр:";
            }
            else
            {
                label8.Text = "Не правильно вказано вид трикутника!";
                label7.Text = "";
            }
        }
    }
}
