using System;
//Стратегия (Strategy)

namespace DP_HW_4
{    
    interface IShuting
    {
        void Shut();
    }
    //ракета дальнего радиуса действия
    class LongRangeRocket : IShuting
    {
        public void Shut()
        {
            Console.WriteLine("Запуск ракет дальнего радиуса действия");
        }
    }
    //межконтинентальная балистическая
    class intercontinentalBallistic : IShuting
    {
        public void Shut()
        {
            Console.WriteLine("Запуск межконтинентальных балистических ракет");
        }
    }
    class Submarine
    {
        protected int displacement; // водоизмещение
        protected string name; // имя 

        public Submarine(int displ, string name, IShuting mov)
        {
            this.displacement = displ;
            this.name = name;
            Shuting = mov;
        }
        public IShuting Shuting { private get; set; }
        public void shut()
        {
            Shuting.Shut();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Submarine bot = new Submarine(2500, "U-738", new LongRangeRocket());
            bot.shut();
            bot.Shuting = new intercontinentalBallistic();
            bot.shut();

            Console.ReadLine();
        }
    }
}
