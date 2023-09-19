using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCustomizeApp
{
    class Customize
    {
        public void CarCustomize(string[] car)
        {
            Cars carSpecs = new Cars();

            Console.WriteLine("Please enter the informations below:\n" +
                "  Car Brand\n  Car Model\n  Car Color\n  Car Engine\n  Turbo\n  Horse Power\n" +
                "(Example: CarBrand CarModel CarColor CarEngine CarTurbo CarHorsePower");
            string
                carBrand = Console.ReadLine(),
                carModel = Console.ReadLine(),
                carColor = Console.ReadLine(),
                carEngine = Console.ReadLine(),
                carTurbo = Console.ReadLine(),
                carHorsePower = Console.ReadLine();

            string[] customCar =
            {
                carBrand,
                carModel,
                carColor,
                carEngine,
                carTurbo,
                carHorsePower
            };

            for(int i = 0; i < car.Length; i++)
            {
                car[i] = customCar[i];
            }

            Console.Clear();

            Console.WriteLine("Your car is customized. The details are below.");
            for(int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(carSpecs.Header[i] + " " + car[i]);
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
