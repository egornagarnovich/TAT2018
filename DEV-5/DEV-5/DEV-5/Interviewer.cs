using System;
namespace DEV5
{
    /// <summary>
    /// Class containing user interaction methods
    /// </summary>
    public class Interviewer
    {
        private InputCommands listInputCommands = new InputCommands(); 
        private static Interviewer objIntereviewer = new Interviewer();

        /// <summary>
        /// Ensures that only one object is created for the class.
        /// </summary>
        /// <returns>The object of interviewer.</returns>
        public static Interviewer GetObjInterviewer()
        {
            if (objIntereviewer == null)
                objIntereviewer = new Interviewer();
            return objIntereviewer;
        }

        /// <summary>
        /// Asks the user for the brand of car.
        /// Checks whether the brand is entered correctly.
        /// </summary>
        /// <returns>The brand of cars.</returns>
        public string AskBrandOfCars()
        {
            Console.WriteLine("Enter brand of cars: ");
            string brand = Console.ReadLine();
            if (brand.Length < 1)
            {
                Console.WriteLine("Cars brand of incorrect.");
                AskBrandOfCars();
            }
            return brand;
        }

        /// <summary>
        /// Asks the user for the model of car.
        /// Checks whether the brand is entered correctly.
        /// </summary>
        /// <returns>The model of cars.</returns>
        public string AskModelOfCars()
        {
            Console.WriteLine("Enter model of cars: ");
            string model = Console.ReadLine();
            if (model.Length < 1)
            {
                Console.WriteLine("Cars model of incorrect.");
                AskModelOfCars();
            }
            return model;
        }

        /// <summary>
        /// Asks the user for the quantity of car.
        /// Checks whether the brand is entered correctly.
        /// </summary>
        /// <returns>The quantity of cars.</returns>
        public int AskQuantityOfCars()
        {
            try
            {
                Console.WriteLine("Enter quantity of cars: ");
                int quantity = Int32.Parse(Console.ReadLine());
                if (quantity < 0)
                {
                    Console.WriteLine("Cars quantity of incorrect.");
                    AskQuantityOfCars();
                }
                return quantity;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
                return AskQuantityOfCars();
            }
        }

        /// <summary>
        /// Asks the user for The cost per unit of car.
        /// Checks whether the brand is entered correctly.
        /// </summary>
        /// <returns>The cost per unit of car.</returns>
        public int AskCostPerUnitOfCar()
        {
            try
            {
                Console.WriteLine("Enter the cost of one car: ");
                int costPerUnitOfCar = Int32.Parse(Console.ReadLine());
                if (costPerUnitOfCar < 0)
                {
                    Console.WriteLine("The cost of one car of incorrect.");
                    AskCostPerUnitOfCar();
                }
                return costPerUnitOfCar;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
                return AskCostPerUnitOfCar();
            }
        }

        /// <summary>
        /// Asks the user command.
        /// Checks whether the brand is entered correctly.
        /// </summary>
        /// <returns>The user command.</returns>
        public string AskCommand()
        {
            Console.WriteLine("Enter command: ");
            string inputCommand = Console.ReadLine();
            if (!listInputCommands.CheckCommand(inputCommand))
            {
                Console.WriteLine("Sorry, Wrong command. Try again.");
                AskCommand();
            }
            return inputCommand;
        }
    }
}