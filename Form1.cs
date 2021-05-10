using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAJSTAR
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

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

           Employee employee = new Employee();
            employee.NewRequest();
            EggOrder egg = new EggOrder();
            egg.GetQuality();

            if (radioButton1.Checked)
            {
                MessageBox.Show("Ваш(а) яйцо принят на приготовление");

                label3.Text= egg.quality.ToString();
            }
           
            CkickenOrder order = new CkickenOrder();
            order.GetQuantity();
            if (Chicken.Checked)
            {
                MessageBox.Show("Ваш(а) куриный гриль принят на приготовление");
               
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            EggOrder egg = new EggOrder();
            CkickenOrder order = new CkickenOrder();
            order.Cook();
            Employee employee = new Employee();
            employee.NewRequest();
            egg.GetQuality();

            if (radioButton1.Checked)
            {
                MessageBox.Show("Ваш(а) заказ повторяется");

                label3.Text = egg.quality.ToString();

            }
            if (Chicken.Checked)
            {
                MessageBox.Show("Ваш(а) заказ повторяется");

            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            EggOrder egg = new EggOrder();
           
            if (radioButton1.Checked)
            {
                textBox2.Text = employee.quantity.ToString("Ваш(а) яйцо готов");
               
            }
            else
            {
                textBox2.Text = employee.quantity.ToString("Ваш яйца не тухлый");
            }

            if (Chicken.Checked)
            {
                textBox2.Text = egg.quality.ToString("Ваш(а) куриный гриль готов");
            }


        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Chicken_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
