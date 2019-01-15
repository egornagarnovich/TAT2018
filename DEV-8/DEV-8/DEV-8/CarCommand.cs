using System;
using System.Xml;
namespace DEV8
{
    /// <summary>
    /// Car command.
    /// </summary>
    class CarCommand : ICommand
    {
        Receiver receiver;
        XmlDocument dataCar;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DEV8.CarCommand"/> class.
        /// </summary>
        /// <param name="r">The receiver component.</param>
        /// <param name="data">Data.</param>
        public CarCommand(Receiver r, XmlDocument data)
        {
            receiver = r;
            dataCar = data;
        }

        /// <summary>
        /// Execute this instance.
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(receiver.GetNumberOfBrands(dataCar));
            Console.WriteLine(receiver.GetAveragePriceAuto(dataCar));
            Console.WriteLine(receiver.GetPriceAllAuto(dataCar));
        }
    }
}