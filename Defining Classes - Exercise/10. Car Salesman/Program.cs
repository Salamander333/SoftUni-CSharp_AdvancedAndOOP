using System;
using System.Collections.Generic;

namespace _10._Car_Salesman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var enginesCount = int.Parse(Console.ReadLine());

            var engines = new List<Engine>();
            var cars = new List<Car>();
            
            for (int i = 0; i < enginesCount; i++)
            {
                var engine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var engineModel = engine[0];
                var enginePower = int.Parse(engine[1]);
                Engine _engine;

                if (engine.Length == 2)
                {
                    _engine = new Engine(engineModel, enginePower);
                }
                else if (engine.Length == 4)
                {
                    int engineDisplacement = int.Parse(engine[2]);
                    string engineEfficiency = engine[3];

                    _engine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);
                }
                else
                {
                    int engineDisplacement = -1;
                    bool isDisplacement = int.TryParse(engine[2], out engineDisplacement);

                    if (isDisplacement)
                    {
                        engineDisplacement = int.Parse(engine[2]);
                        _engine = new Engine(engineModel, enginePower, engineDisplacement);
                    }
                    else
                    {
                        string engineEfficiency = engine[2];
                        _engine = new Engine(engineModel, enginePower, engineEfficiency);
                    }
                }

                engines.Add(_engine);
            }

            var carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                var car = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var model = car[0];
                Engine engine = engines.Find(e => e.Model == car[1]);
                Car _car;

                if (car.Length == 2)
                {
                    _car = new Car(model, engine);
                }

                else if (car.Length == 4)
                {
                    int weight = int.Parse(car[2]);
                    string color = car[3];
                    _car = new Car(model, engine, weight, color);
                }

                else
                {
                    int weight = -1;
                    bool isWeight = int.TryParse(car[2], out weight);

                    if (isWeight)
                    {
                        weight = int.Parse(car[2]);
                        _car = new Car(model, engine, weight);
                    }

                    else
                    {
                        string color = car[2];
                        _car = new Car(model, engine, color);
                    }
                }

                cars.Add(_car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
