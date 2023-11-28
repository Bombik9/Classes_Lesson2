using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace task2
{
    internal class Converter
    {

        private double usd, eur, gbp, uah;

        public double Usd
        {
            get { return usd; }
            set { usd = value; }
        }

        public double Eur
        {
            get { return eur; }
            set { eur = value; }
        }

        public double Gbp
        {
            get { return gbp; }
            set { gbp = value; }
        }

        public double Uah
        {
            get { return uah; }
            set { uah = value; }
        }

         double result;

        public double Result
        {
            get { return result; }
            set { result = value; }
        }
        
        public Converter(double usd, double eur, double gbp)
        {
            this.usd = usd;
            this.eur = eur;
            this.gbp = gbp;
            Console.Write("Введіть суму грн: ");
            this.uah = Convert.ToDouble(Console.ReadLine());

        }


        public void  MethodUsd()
        {
            result = uah / usd;
            Console.WriteLine($"Ви отримуєте {result} USD");
        }
        public void MethodEur()
        {
            result = uah / eur;
            Console.WriteLine($"Ви отримуєте {result} EUR");
        }
        public void MethodGbp()
        {
            result = uah / gbp;
            Console.WriteLine($"Ви отримуєте {result} GBP");
        }


         
    }
}
