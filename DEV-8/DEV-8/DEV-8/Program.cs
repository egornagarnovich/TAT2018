using System;

namespace DEV8
{
    /// <summary>
    /// Main class.
    /// Contains all methods for performing basic functions.
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">Path to xml with cars, and path to xml with trucks</param>
        public static void Main(string[] args)
        {
            try
            {
                string pathToXmlWithCars = args[0];
                string pathToXmlWithTrucks = args[1];
                XmlLoader loader = new XmlLoader();
                var dataCars = loader.LoadXml(ref pathToXmlWithCars);
                var dataTrucks = loader.LoadXml(ref pathToXmlWithTrucks);
                Invoker invoker = new Invoker();
                Receiver r = new Receiver();
                Interviewer interviewer = new Interviewer();
                string cmd = interviewer.AskCommand();
                if (cmd == "count types")
                {
                    Console.WriteLine(r.GetNumberOfBrands(dataCars));
                    Console.WriteLine(r.GetNumberOfBrands(dataTrucks));
                }
                if (cmd == "count all")
                {
                    Console.WriteLine(r.GetPriceAllAuto(dataCars));
                    Console.WriteLine(r.GetPriceAllAuto(dataTrucks));
                }
                if (cmd == "average price")
                {
                    Console.WriteLine(r.GetAveragePriceAuto(dataCars));
                    Console.WriteLine(r.GetAveragePriceAuto(dataTrucks));
                }
                if (cmd == "execute")
                {
                    invoker.GetCarInformation(new CarCommand(r, dataCars));
                    invoker.GetTruckInformation(new TruckCommand(r, dataTrucks));
                    invoker.GetInformation();
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("Error:" + error.Message);
            }
        }
    }
}
