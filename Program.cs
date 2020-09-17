using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Calculate calculate = new Calculate();

            for (; ; )
            {
                Calculate calc = new Calculate();
                double result = 0;

                double fNum = calc.InputFirstNum();

                Console.WriteLine("Enter Operation (+ , -, *, /, %): ");
                char oper;
                char.TryParse(Console.ReadLine(), out oper);

                double sNum = calc.InputSecondNum();
                

                
               


                switch (oper)
                {
                    case '+':
                        result = calc.Add(fNum, sNum);
                        break;
                    case '-':
                        result = calc.Substract(fNum, sNum);
                        break;
                    case '*':
                        result = calc.Multiply(fNum, sNum);
                        break;
                    case '/':
                        try 
                        { 
                            result = calc.Divide(fNum, sNum); 
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                        break;
                    case '^':
                        result = calc.Extent(fNum, sNum);
                        break;
                    case '%':
                        result = calc.RemainderOfDivision(fNum, sNum);
                        break;
                    default:
                        Console.WriteLine("Invalid a sign operation!");
                        break;
                }
                Console.WriteLine("Answer: " + result);
            }
        }
    }

    public class Calculate
    {
        public double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        public double Substract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        public double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public double Divide(double firstNum, double secondNum)
        {
            if (secondNum == 0)
            {
                throw new Exception("Divide by zero is impossible!");   
            }
            return firstNum / secondNum;
        }
        public double Extent(double firstNum, double secondNum)
        {
            double extent = firstNum;
            for (int i = 1; i < secondNum; i++)
            {
                extent *= firstNum;
            }
            return extent;
        }

        public double InputFirstNum()
        {
            double firstNum;
            do
            {
                Console.WriteLine("Enter First Number: ");
            } while (!double.TryParse(Console.ReadLine(), out firstNum));

            return firstNum;
        }

        public double InputSecondNum()
        {
            double secondNum;
            do
            {
                Console.WriteLine("Enter Second Number: ");
            } while (!double.TryParse(Console.ReadLine(), out secondNum));

            return secondNum;
        }
        
        public double RemainderOfDivision(double firstNum, double secondNum)
        {
            double result = firstNum % secondNum;
            return result;
        }
    }
}
