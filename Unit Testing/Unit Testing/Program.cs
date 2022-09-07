using System;


namespace Unit_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fakfkakfaf");
            Console.ReadLine();
        }
    }
    internal class TemelIslemler
    {
        public double Topla(double num1, double num2)
        {
            return num1 + num2;
        }
         public double Cikart(double num1, double num2)
         {
        return num1 - num2;
         }
        public double Bol(double num1, double num2)
        {
            return num1 / num2; 
        }
        public double Carp(double num1, double num2)
        {
            //işlem yanlış verildi
            return num1 + num1;
        }



    } 


}
