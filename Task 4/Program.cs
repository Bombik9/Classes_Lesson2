﻿
using System.Text;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Используя Visual Studio, создайте проект по шаблону Console Application.
            //Требуется: 
            //Создать класс Invoice.
            //    В теле класса создать три поля int account, string customer, string provider,
            //    которые должны быть проинициализированы один раз(при создании экземпляра данного класса) без возможности их дальнейшего изменения.
            //    В теле класса создать два закрытых поля string article, int quantity
            //    Создать метод расчета стоимости заказа с НДС и без НДС.
            //    Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

            Console.OutputEncoding = Encoding.Unicode;

            Invoice invoice = new Invoice(1200, "Сургій", "Версаче");

            invoice.Quantity = 10;
            invoice.Article = "Кофт";

            invoice.Method();

            invoice.Show();







        }
    }
}