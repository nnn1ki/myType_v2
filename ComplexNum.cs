using System;
using System.Collections.Generic;
using System.Text;

namespace MyType
{
    public class ComplexNum
    {
        private int real;
        private int imaginary;

        public ComplexNum()
        {
            real = 1;
            imaginary = 1;
        }

        public ComplexNum(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }


        //метод вывода
        public String showAnwer()
        {
            String ans = "Ответ: " + this.real + "+i" + this.imaginary;
            return String.Format(ans);
        }


        public static ComplexNum operator + (ComplexNum num1, ComplexNum num2)
        {
            return new ComplexNum(num1.real + num2.real, num1.imaginary + num2.imaginary); ;
        }
        
        public static ComplexNum operator - (ComplexNum num1, ComplexNum num2)
        {
            return new ComplexNum(num1.real - num2.real, num1.imaginary - num2.imaginary); ;
        }
        
        public static ComplexNum operator * (ComplexNum num1, ComplexNum num2)
        {
            return new ComplexNum((num1.real * num2.real) - (num1.imaginary * num2.imaginary), (num1.real * num2.imaginary) + (num1.imaginary * num2.real));
        }

        public static ComplexNum operator / (ComplexNum num1, ComplexNum num2)
        {
            return new ComplexNum((num1.real * num2.real + num1.imaginary * num2.imaginary) / (num2.real * num2.real + num2.imaginary * num2.imaginary), (num1.imaginary * num2.real - num1.real * num2.imaginary) / (num2.real * num2.real + num2.imaginary * num2.imaginary));
        }


        //public static ComplexNum (ComplexNum num1, ComplexNum num2)
        //{

        //}



    }
}
