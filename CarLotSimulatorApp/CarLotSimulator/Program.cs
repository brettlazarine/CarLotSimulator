using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carlot  = new Carlot()
            {
                Cars = new List<Car>()
            };
            //TODO

            //Create a seperate class file called Car -- DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable -- DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() -- DONE
            //The methods should take one string parameter: the respective noise property -- DONE


            //Now that the Car class is created we can instanciate 3 new cars -- DONE
            //Set the properties for each of the cars -- DONE
            var power = new Car()
            {
                Year = 1949,
                Make = "Dodge",
                Model = "Power Wagon",
                EngineNoise = "LugLugLugLugLugLug",
                HonkNoise = "Beep",
                IsDriveable = true
            };
            carlot.Cars.Add(power);
            var cuda = new Car()
            {
                Year = 1973,
                Make = "Plymouth",
                Model = "Barracuda",
                EngineNoise = ".....",
                HonkNoise = "Honk",
                IsDriveable = false
            };
            carlot.Cars.Add(cuda);
            var telly = new Car()
            {
                Year = 2023,
                Make = "Kia",
                Model = "Telluride",
                EngineNoise = "VroomVroom",
                HonkNoise = "MeepMeep",
                IsDriveable = true
            };
            carlot.Cars.Add(telly);
            carlot.PrintCarlot(carlot.Cars);
            //Call each of the methods for each car -- DONE
            Console.WriteLine("----------\n" +
                "Power Wagon");
            power.MakeEngineNoise();
            power.MakeHonkNoise(power.HonkNoise);
            Console.WriteLine("----------\n" +
                "Barracuda");
            cuda.MakeEngineNoise();
            cuda.MakeHonkNoise(cuda.HonkNoise);
            Console.WriteLine("----------\n" +
                "Telluride");
            telly.MakeEngineNoise();
            telly.MakeHonkNoise(telly.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car -- DONE 

            //cuda.EngineNoise = "BangBoomPop";                 //1
            //var power = new Car() {Year = 1949};              //2
            //var telly = new Car(2023);                        //3

            //*************BONUS X 2*************//

            //Create a CarLot class -- DONE
            //It should have at least one property: a List of cars -- DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. -- DONE
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console -- DONE
        }
    }
}
