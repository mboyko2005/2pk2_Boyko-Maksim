using System;
namespace PZ_28
{
        class Program
        {
            static void Main(string[] args)
            {
                Car car = new Car();
                Police police = new Police();

                for (int i = 0; i <= 200; i += 10)
                {
                    car.Speed = i;
                    Console.WriteLine($"Скорость автомобиля: {car.Speed} км/ч");

                    if (car.Speed > 80 && car.Speed <= 120)
                    {
                        police.Warn();
                    }
                    else if (car.Speed > 120)
                    {
                        police.Arrest();
                        break;
                    }

                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        class Car
        {
            public int Speed { get; set; }
        }

        class Police
        {
            public void Warn()
            {
                Console.WriteLine("Патрульный: Внимание! Превышение скорости! Пожалуйста, снизьте скорость.");
            }

            public void Arrest()
            {
                Console.WriteLine("Патрульный: Превышение скорости более 120 км/ч! Активизирую режим задержания!");
            }
        }
}
