using System.Reflection.Metadata.Ecma335;

namespace CarCustomizeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars();
            string[] Header = car.Header, Sedan = car.Sedan, SUV = car.SUV;

            while (true)
            {
                Console.Write("Please select the car type that you want to customize:\n" +
                "[0] Exit\n[1] Sedan\n[2] SUV\nOption: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        car.CarCustomize(Sedan);
                        break;
                    case 2:
                        car.CarCustomize(SUV);
                        break;
                    default:
                        Console.WriteLine("You have entered an invlid option!");
                        continue;
                }
                    
            }

            car.CarCustomize(Sedan);
            
        }
    }
}