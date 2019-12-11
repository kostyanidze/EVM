using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVM_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int convertedFromBinary = Convert.ToInt32(textBox1.Text);
                textBox2.Text = convertToOctal(convertedFromBinary, 2).ToString();
                textBox3.Text = convertToDecimal(convertedFromBinary, 2).ToString();
                textBox4.Text = convertToHexadecimal(convertedFromBinary, 2).ToString();

            }
            catch (FormatException)
            {
                label1.Text = "Wrong enter";
                label2.Text = "Wrong enter";
                label3.Text = "Wrong enter";
                label4.Text = "Wrong enter";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int convertedFromOctal = Convert.ToInt32(textBox2.Text);
                textBox1.Text = convertToBinary(convertedFromOctal, 8).ToString();
                textBox3.Text = convertToDecimal(convertedFromOctal, 8).ToString();
                textBox4.Text = convertToHexadecimal(convertedFromOctal, 8).ToString();

            }
            catch (FormatException)
            {
                label1.Text = "Wrong enter";
                label2.Text = "Wrong enter";
                label3.Text = "Wrong enter";
                label4.Text = "Wrong enter";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int convertedFromDecimal = Convert.ToInt32(textBox3.Text);
                textBox1.Text = convertToBinary(convertedFromDecimal, 10).ToString();
                textBox2.Text = convertToOctal(convertedFromDecimal, 10).ToString();
                textBox4.Text = convertToHexadecimal(convertedFromDecimal, 10).ToString();

            }
            catch (FormatException)
            {
                label1.Text = "Wrong enter";
                label2.Text = "Wrong enter";
                label3.Text = "Wrong enter";
                label4.Text = "Wrong enter";
            }

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string hexadecimalNumber = textBox4.Text;
                textBox1.Text = convertToBinary(convertFromHexaToDecimal(hexadecimalNumber), 10).ToString();
                textBox2.Text = convertToOctal(convertFromHexaToDecimal(hexadecimalNumber), 10).ToString();
                textBox3.Text = convertFromHexaToDecimal(hexadecimalNumber).ToString();

            }
            catch (FormatException)
            {
                label1.Text = "Wrong enter";
                label2.Text = "Wrong enter";
                label3.Text = "Wrong enter";
                label4.Text = "Wrong enter";
            }
        }

        private void textBoxSign_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sign = textBoxSign.Text;
                label1.Text = Operations(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox5.Text), sign).ToString();
            }
            catch (FormatException)
            {
                label1.Text = "Enter the numbers";

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int convertedFromBinary = Convert.ToInt32(textBox5.Text);
                textBox6.Text = convertToOctal(convertedFromBinary, 2).ToString();
                textBox7.Text = convertToDecimal(convertedFromBinary, 2).ToString();
                textBox8.Text = convertToHexadecimal(convertedFromBinary, 2).ToString();

            }
            catch (FormatException)
            {
                label1.Text = "Wrong enter";
                label2.Text = "Wrong enter";
                label3.Text = "Wrong enter";
                label4.Text = "Wrong enter";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int convertedFromOctal = Convert.ToInt32(textBox6.Text);
                textBox5.Text = convertToBinary(convertedFromOctal, 8).ToString();
                textBox7.Text = convertToDecimal(convertedFromOctal, 8).ToString();
                textBox8.Text = convertToHexadecimal(convertedFromOctal, 8).ToString();

            }
            catch (FormatException)
            {
                label1.Text = "Wrong enter";
                label2.Text = "Wrong enter";
                label3.Text = "Wrong enter";
                label4.Text = "Wrong enter";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int convertedFromDecimal = Convert.ToInt32(textBox7.Text);
                textBox5.Text = convertToBinary(convertedFromDecimal, 10).ToString();
                textBox6.Text = convertToOctal(convertedFromDecimal, 10).ToString();
                textBox8.Text = convertToHexadecimal(convertedFromDecimal, 10).ToString();

            }
            catch (FormatException)
            {
                label1.Text = "Wrong enter";
                label2.Text = "Wrong enter";
                label3.Text = "Wrong enter";
                label4.Text = "Wrong enter";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string hexadecimalNumber = textBox8.Text;
                textBox5.Text = convertToBinary(convertFromHexaToDecimal(hexadecimalNumber), 10).ToString();
                textBox6.Text = convertToOctal(convertFromHexaToDecimal(hexadecimalNumber), 10).ToString();
                textBox7.Text = convertFromHexaToDecimal(hexadecimalNumber).ToString();

            }
            catch (FormatException)
            {
                label1.Text = "Wrong enter";
                label2.Text = "Wrong enter";
                label3.Text = "Wrong enter";
                label4.Text = "Wrong enter";
            }
        }

        public int convertToBinary(int number, int numOfSys)
        {
            if (numOfSys == 10)
            {
                int numLength = number.ToString().Length;
                int[] arr = new int[numLength * 4];
                int convertedNumber = 0, i = 0;
                i = 0;
                while (number > 0)
                {
                    arr[i] = number % 2;
                    number /= 2;
                    i++;
                }
                for (int j = i - 1; j >= 0; j--)
                {
                    convertedNumber = convertedNumber * 10 + arr[j];
                }
                return convertedNumber;
            }
            else if (numOfSys == 8)
            {
                int convertedNumber = convertToBinary(convertToDecimal(number, 8), 10);
                return convertedNumber;
            }
            else if (numOfSys == 16)
            {
                int convertedNumber = convertToBinary(convertToDecimal(number, 16), 10);
                return convertedNumber;
            }
            else return number;
        }

        public int convertToOctal(int number, int numOfSys)
        {
            if (numOfSys == 10)
            {
                int numLength = number.ToString().Length;
                int[] arr = new int[numLength * 4];
                int convertedNumber = 0, i = 0;

                while (number > 0)
                {
                    arr[i] = number % 8;
                    number /= 8;
                    i++;
                }
                for (int j = i - 1; j >= 0; j--)
                {
                    convertedNumber = convertedNumber * 10 + arr[j];
                }
                return convertedNumber;
            }
            else if (numOfSys == 2)
            {
                number = convertToOctal(convertToDecimal(number, 2), 10);
                return number;
            }
            else if (numOfSys == 16)
            {
                number = convertToOctal(convertToDecimal(number, 16), 10);
                return number;
            }
            else return number;
        }

        public int convertToDecimal(int number, int numOfSys)
        {
            if (numOfSys == 2)
            {
                int binaryConvertion = 0, i = 0;
                while (number > 0)
                {
                    binaryConvertion += number % 10 * ((int)Math.Pow(2, i));
                    number /= 10;
                    i++;
                }
                return binaryConvertion;
            }
            else if (numOfSys == 8)
            {
                int octalConvertion = 0, i = 0;
                while (number > 0)
                {
                    octalConvertion += number % 10 * ((int)Math.Pow(8, i));
                    number /= 10;
                    i++;
                }
                return octalConvertion;
            }
            else return number;
        }

        public string convertToHexadecimal(int number, int numOfSys)
        {
            if (numOfSys == 10)
            {
                int numLength = number.ToString().Length;
                int[] arr = new int[numLength * 4];
                int i = 0;

                while (number > 0)
                {
                    arr[i] = number % 16;

                    number /= 16;
                    i++;
                }
                string convertedNumber = "";
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] < 10)
                    {
                        convertedNumber += arr[j];
                    }
                    else
                    {
                        switch (arr[j])
                        {
                            case 10: convertedNumber += "A"; break;
                            case 11: convertedNumber += "B"; break;
                            case 12: convertedNumber += "C"; break;
                            case 13: convertedNumber += "D"; break;
                            case 14: convertedNumber += "E"; break;
                            case 15: convertedNumber += "F"; break;
                        }
                    }
                }
                return convertedNumber;
            }
            else if (numOfSys == 2)
            {
                string convertedNumber = convertToHexadecimal(convertToDecimal(number, 2), 10);
                return convertedNumber;
            }
            else if (numOfSys == 8)
            {
                string convertedNumber = convertToHexadecimal(convertToDecimal(number, 8), 10);
                return convertedNumber;
            }
            else return number.ToString();
        }

        public string convertFromHexaToBinary(string number)
        {
            string convertedNumber = "";

            return convertedNumber;
        }

        public int convertFromHexaToDecimal(string number)
        {
            int convertedNumber = 0;
            int stLength = number.Length;
            for (int i = stLength - 1; i >= 0; i--)
            {
                char hexaChar = number[i];
                if (hexaChar >= '0' && hexaChar <= '9')
                {
                    convertedNumber += int.Parse(number[i].ToString()) * (int)Math.Pow(16, stLength - 1 - i);
                }
                else if (hexaChar >= 'A' && hexaChar <= 'F')
                {
                    switch (hexaChar)
                    {
                        case 'A': convertedNumber += 10 * (int)Math.Pow(16, stLength - 1 - i); break;
                        case 'B': convertedNumber += 11 * (int)Math.Pow(16, stLength - 1 - i); break;
                        case 'C': convertedNumber += 12 * (int)Math.Pow(16, stLength - 1 - i); break;
                        case 'D': convertedNumber += 13 * (int)Math.Pow(16, stLength - 1 - i); break;
                        case 'E': convertedNumber += 14 * (int)Math.Pow(16, stLength - 1 - i); break;
                        case 'F': convertedNumber += 15 * (int)Math.Pow(16, stLength - 1 - i); break;
                    }
                }
            }
            return convertedNumber;
        }

        public int Operations(int firstNumber, int secondNumber, string sign)
        {
            int number = 123;
            int a, b, bonus = 0;
            string sum = "";
            string subt = "";
            string temp1 = "";
            if (sign == "+")
            {
                bool fnumgreater;
                if (firstNumber > secondNumber)
                {
                    fnumgreater = true;
                }
                else
                {
                    fnumgreater = false;
                }
                if (fnumgreater == false)
                {
                    while (firstNumber > 0)
                    {
                        a = firstNumber % 10;
                        b = secondNumber % 10;
                        firstNumber /= 10;
                        secondNumber /= 10;
                        if (a + b == 2)
                        {
                            if (bonus == 0)
                            {
                                sum = 0 + sum;
                                bonus = 1;
                            }
                            else if (bonus == 1)
                            {
                                sum = bonus + sum;
                                bonus = 1;
                            }
                        }
                        else
                        {
                            if (bonus == 0)
                            {
                                sum = (a + b) + sum;
                            }
                            else if (bonus == 1)
                            {
                                if (a == 1 || b == 1)
                                {
                                    bonus = 1;
                                    sum = 0 + sum;
                                }
                                else if (a == 0 && b == 0)
                                {
                                    sum = 1 + sum;
                                    bonus = 0;
                                }
                            }
                        }
                    }
                    while (secondNumber > 0)
                    {
                        if (bonus == 1)
                        {
                            b = secondNumber % 10;
                            secondNumber /= 10;
                            if (b == 0)
                            {
                                sum = 1 + sum;
                                bonus = 0;
                            }
                            else if (b == 1)
                            {
                                sum = 0 + sum;
                                bonus = 1;
                            }

                        }
                        else
                        {
                            sum = secondNumber + sum;
                            bonus = 0;
                            break;
                        }
                    }
                    if (bonus == 1)
                    {
                        sum = 1 + sum;
                    }

                }
                else if (fnumgreater == true)
                {
                    while (secondNumber > 0)
                    {
                        a = firstNumber % 10;
                        b = secondNumber % 10;
                        firstNumber /= 10;
                        secondNumber /= 10;
                        if (a + b == 2)
                        {
                            if (bonus == 0)
                            {
                                sum = 0 + sum;
                                bonus = 1;
                            }
                            else if (bonus == 1)
                            {
                                sum = bonus + sum;
                                bonus = 1;
                            }
                        }
                        else
                        {
                            if (bonus == 0)
                            {
                                sum = (a + b) + sum;
                            }
                            else if (bonus == 1)
                            {
                                if (a == 1 || b == 1)
                                {
                                    bonus = 1;
                                    sum = 0 + sum;
                                }
                                else if (a == 0 && b == 0)
                                {
                                    sum = 1 + sum;
                                    bonus = 0;
                                }
                            }
                        }
                    }
                    while (firstNumber > 0)
                    {
                        if (bonus == 1)
                        {
                            b = firstNumber % 10;
                            firstNumber /= 10;
                            if (b == 0)
                            {
                                sum = 1 + sum;
                                bonus = 0;
                            }
                            else if (b == 1)
                            {
                                sum = 0 + sum;
                                bonus = 1;
                            }

                        }
                        else
                        {
                            sum = firstNumber + sum;
                            bonus = 0;
                            break;
                        }
                    }
                    if (bonus == 1)
                    {
                        sum = 1 + sum;
                    }
                }
                number = Convert.ToInt32(sum);
                bonus = 0;
            }

            if (sign == "-")
            {

                while (firstNumber > 0)
                {
                    a = firstNumber % 10;
                    b = secondNumber % 10;
                    firstNumber /= 10;
                    secondNumber /= 10;
                    if (a - b == 0)
                    {
                        subt = 0 + subt;
                    }
                    else if (a - b == 1)
                    {
                        subt = 1 + subt;
                    }
                    else if(a-b == -1)
                    {
                        int i = 0;
                        while(firstNumber % 10 != 1)
                        {
                            temp1 = (firstNumber / 10).ToString();
                            firstNumber /= 10;
                            int j = 1;
                            
                            while (j < i)
                            {
                                temp1 = firstNumber.ToString() + 1;
                                j++;
                            }
                            i = 0;
                            i++;
                        }
                        temp1 = (firstNumber/10).ToString() + 0 +temp1;
                        firstNumber = Convert.ToInt32(temp1);
                        subt = 1 + subt;
                    }
                }
                number = Convert.ToInt32(subt);
            }

            if (sign == "*")
            {
                int i = 0;
                int j = 0;
                int k = 1;
                int m = 0;
                int n = 0;
                string summ = "";
                int result = 0;
                int temp = firstNumber;
                Console.WriteLine(firstNumber.ToString().Length);
                for (i = 0; i < secondNumber.ToString().Length; i++)
                {
                   
                    firstNumber = temp;
                    m = secondNumber % 10;
                    secondNumber /= 10;
                    for (j = 0; j < firstNumber.ToString().Length; j++)
                    {
                        n = firstNumber % 10;
                        firstNumber /= 10;
                        int test = n * m;
                        Console.WriteLine("test=" + test + "n="+n+"m="+m);
                        summ = summ+(n * m).ToString();
                        Console.WriteLine(summ);
                        result = result + (Convert.ToInt32(summ) * k);
                    }
                    k*=10;
                }
                number = result;
            }

            return number;
        }
    }
}