
using System;

namespace car
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string registrationnumber;
            string color;
            int odometer;
            int fueltank;

            public Car(string _mark, string _model, string _registrationnumber,string _color)
            {
                mark = _mark;
                model = _model;
                registrationnumber = _registrationnumber;
                color = _color;
                odometer = 0;
                fueltank = 60;


                Console.WriteLine($"your {color} {mark} {model} {registrationnumber} has been arrived!");
            }
            public string Model
            {
                get { return model; }
            }
            public string Mark
            {
                get { return mark; }
            }
            public string Color
            {
                get { return color; }
            }
            public string Registrationnumber
            {
                get { return registrationnumber; }
            }
            public int Odometer
            {
                get { return odometer; }
            }
            public int Fueltank
            {
                get { return fueltank; }
            }

            public void Drive()
            {
                fueltank -= 5;
                odometer += 100;
                Console.WriteLine("wrom-wrom");

            }

            public void showcarinfo()
            {
                Console.WriteLine($"mark name: {mark}.");
                Console.WriteLine($"model name: {model}.");
                Console.WriteLine($"registration number: {registrationnumber}.");
                Console.WriteLine($"color: {color}.");
                Console.WriteLine($"odometer: {odometer}.");
                Console.WriteLine($"fuel tank: {fueltank}.");
                GC.Collect();
            }
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("BMW", "30", "FGH456", "black");
            while(myCar.Fueltank > 0)
            {
                myCar.Drive();
            }
            myCar.showcarinfo();

        }
    }
}
