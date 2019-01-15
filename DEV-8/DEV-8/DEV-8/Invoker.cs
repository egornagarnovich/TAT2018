namespace DEV8
{
    /// <summary>
    /// Invoker.
    /// </summary>
    class Invoker
    {
        ICommand carCommand;
        ICommand truckCommand;

        /// <summary>
        /// Gets the car information.
        /// </summary>
        /// <param name="cmd">Cmd.</param>
        public void GetCarInformation(ICommand cmd)
        {
            carCommand = cmd;
        }

        /// <summary>
        /// Gets the truck information.
        /// </summary>
        /// <param name="cmd">Cmd.</param>
        public void GetTruckInformation(ICommand cmd)
        {
            truckCommand = cmd;
        }

        /// <summary>
        /// Gets the information for cars and trucks.
        /// </summary>
        public void GetInformation()
        {
            if (carCommand is ICommand)
                carCommand.Execute();

            if (truckCommand is ICommand)
                truckCommand.Execute();
        }
    }
}