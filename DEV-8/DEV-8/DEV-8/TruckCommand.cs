using System;
using System.Xml;
namespace DEV8
{
    /// <summary>
    /// Truck command.
    /// </summary>
    class TruckCommand : ICommand
    {
        Receiver receiver;
        XmlDocument dataTruck;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DEV8.TruckCommand"/> class.
        /// </summary>
        /// <param name="r">The receiver component.</param>
        /// <param name="data">Data.</param>
        public TruckCommand(Receiver r, XmlDocument data)
        {
            receiver = r;
            dataTruck = data;
        }

        /// <summary>
        /// Execute this instance.
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(receiver.GetNumberOfBrands(dataTruck));
            Console.WriteLine(receiver.GetAveragePriceAuto(dataTruck));
            Console.WriteLine(receiver.GetPriceAllAuto(dataTruck));
        }
    }
}