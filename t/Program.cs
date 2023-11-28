using System;
using System.Text;
using task2;

namespace t
{
    internal class Program
    {



        static void Main(string[] args)
        {
            //Используя Visual Studio, создайте проект по шаблону Console Application.
            //    Требуется: 
            //Создать класс Converter.
            //    В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и инициализирует
            //    поля соответствующие курсу 3 - х основных валют,
            //    по отношению к гривне – public Converter(double usd, double eur, double gbp).
            //Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также программа должна производить 
            //конвертацию из указанных валют в гривну.

            Converter converter = new Converter(38.2, 41.2, 45.5);


            Console.WriteLine( "Курси валют: ");
            Console.WriteLine($"USD: {converter.Usd} \nEUR: {converter.Eur} \nGBP: {converter.Gbp} \nВведена сума: {converter.Uah} UAH") ;
            converter.MethodUsd();
            converter.MethodEur();
            converter.MethodGbp();

            
            Console.ReadKey();









        }

    }
}