using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createFigure_Click(object sender, EventArgs e)
        {
            if(nameFigure.Text == "Коло")
            {
                label2.Text = "Введіть данні для створення кола";
                label3.Text = "Радіус:";
                label4.Text = "";
                label5.Text = "";
            }
            else if(nameFigure.Text == "Квадрат")
            {
                label2.Text = "Введіть данні для створення квадрату";
                label3.Text = "Сторона:";
                label4.Text = "";
                label5.Text = "";
            }
            else if (nameFigure.Text == "Ромб")
            {
                label2.Text = "Введіть данні для створення ромба";
                label3.Text = "Сторона:";
                label4.Text = "Кут у градусах:";
                label5.Text = "";
            }
            else if (nameFigure.Text == "Трикутник")
            {
                label2.Text = "Введіть данні для створення трикутника";
                label3.Text = "Сторона 1:"; 
                label4.Text = "Сторона 2:";
                label5.Text = "Сторона 3:";
            }
            else if (nameFigure.Text == "Прямокутник")
            {
                label2.Text = "Введіть данні для створення прямокутника";
                label3.Text = "Сторона 1:";
                label4.Text = "Сторона 2:";
                label5.Text = "";
            }
            else 
            {
                label2.Text = "Неправильна назва фігури:";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
            }
        }

        private void area_Click(object sender, EventArgs e)
        {
            if (nameFigure.Text == "Коло")
            {
                Circle circle = new Circle(Convert.ToDouble(textBox2.Text));
                label8.Text = circle.determineArea().ToString();
            }
            else if (nameFigure.Text == "Квадрат")
            {
                Square square = new Square(Convert.ToDouble(textBox2.Text));
                label8.Text = square.determineArea().ToString();
            }
            else if (nameFigure.Text == "Трикутник")
            {
                if (Triangle.checkSides(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox3.Text)))
                {
                    Triangle triangle = new Triangle(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox3.Text));
                    label8.Text = triangle.determineArea().ToString();
                }
                else
                {
                    label8.Text = "Такого трикутника не існує!";
                }
            }
            else if (nameFigure.Text == "Ромб")
            {
                Diamond diamond = new Diamond(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text));
                label8.Text = diamond.determineArea().ToString();
            }
            else if (nameFigure.Text == "Прямокутник")
            {
                Rectangle rectangle = new Rectangle(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text));
                label8.Text = rectangle.determineArea().ToString();
            }
            else
            {
                label8.Text = "Введено неправильну назву фігури!";
            }
        }

        private void perimeter_Click(object sender, EventArgs e)
        {
            if (nameFigure.Text == "Коло")
            {
                Circle circle = new Circle(Convert.ToDouble(textBox2.Text));
                label9.Text = circle.determinePerimeter().ToString();
            }
            else if (nameFigure.Text == "Квадрат")
            {
                Square square = new Square(Convert.ToDouble(textBox2.Text));
                label9.Text = square.determinePerimeter().ToString();
            }
            else if (nameFigure.Text == "Трикутник")
            {
                if (Triangle.checkSides(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox3.Text)))
                {
                    Triangle triangle = new Triangle(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox3.Text));
                    label9.Text = triangle.determinePerimeter().ToString();
                }
                else
                {
                    label9.Text = "Трикутник не створено!";
                }
            }
            else if (nameFigure.Text == "Ромб")
            {
                Diamond diamond = new Diamond(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text));
                label9.Text = diamond.determinePerimeter().ToString();
            }
            else if (nameFigure.Text == "Прямокутник")
            {
                Rectangle rectangle = new Rectangle(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text));
                label9.Text = rectangle.determinePerimeter().ToString();
            }
            else
            {
                label9.Text = "Введено неправильну назву фігури!";
            }
        }
    }
}
