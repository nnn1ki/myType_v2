using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate() //функция пересчта 
        {
            try
            {
                var firstValue = ComplexNum.makeComplexFormat(textBox1.Text);
                var secondValue = ComplexNum.makeComplexFormat(textBox2.Text);

                ComplexNum answer = new ComplexNum(0, 0); //была ошибка отсутвия значения 


                switch (comboBox1.Text)
                {
                    case "+":
                        answer = firstValue + secondValue;
                        break;
                    
                    case "-":
                        answer = firstValue - secondValue;
                        break;

                    case "*":
                        answer = firstValue * secondValue;
                        break;

                    case "/":
                        answer = firstValue / secondValue;
                        break;
                }

                labelAnswer.Text = answer.showAnwer(); //была ошибка отсутвия значения 

            }
            catch (FormatException)
            {
                labelAnswer.Text = "Неправильный формат!"; 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
