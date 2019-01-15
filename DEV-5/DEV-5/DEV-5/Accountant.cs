namespace DEV5
{
    /// <summary>
    /// This class handles user-entered commands.
    /// Calls data counting methods.
    /// </summary>
    public class Accountant
    {
        DatabaseInformation databaseInformation = new DatabaseInformation();
        /// <summary>
        /// Processes the commands and calls the appropriate counting methods.
        /// </summary>
        /// <returns>Counting results.</returns>
        /// <param name="inputCommand">User command.</param>
        public int GetResultOfQuery(string inputCommand)
        {
            switch (inputCommand)
            {
                case "count types":
                    return GetQuantityOfBrands();
                case "count all":
                    return GetTheNumberOfCars();
                case "average price":
                    return GetAverageCostOfAllCars();
                default:
                    return GetAverageCostOfCars(inputCommand);
            }
        }

        /// <summary>
        /// Calls the class method DatabaseInformation and counts the returned elements of the called method.
        /// </summary>
        /// <returns>Number of car brands.</returns>
        public int GetQuantityOfBrands()
        {
            return databaseInformation.GetAllBrands().Count;
        }

        /// <summary>
        /// Calls the class method DatabaseInformation and counts the returned elements of the called method.
        /// </summary>
        /// <returns>The number of cars.</returns>
        public int GetTheNumberOfCars()
        {
            int count = 0;
            foreach (var element in databaseInformation.GetOfQuantityAllCars())
            {
                count += element;
            }
            return count;
        }
        /// <summary>
        /// Calls the class method DatabaseInformation and counts the returned elements of the called method.
        /// </summary>
        /// <returns>Number of cars of a particular brand.</returns>
        /// <param name="brand">Brand of car.</param>
        public int GetTheNumberOfCars(string brand)
        {
            int count = 0;
            foreach (var element in databaseInformation.GetOfQuantityAllCars(brand))
            {
                count += element;
            }
            return count;
        }

        /// <summary>
        /// Calls the class method DatabaseInformation and counts the returned elements of the called method.
        /// </summary>
        /// <returns>The average cost of all cars.</returns>
        public int GetAverageCostOfAllCars()
        {
            int countOfCostPerUnit = databaseInformation.getTheSumOfTheCostPerUnit();
            int countTheNumberOfAllCars = GetTheNumberOfCars();
            return countTheNumberOfAllCars / countOfCostPerUnit;
        }

        /// <summary>
        /// Calls the class method DatabaseInformation and counts the returned elements of the called method.
        /// </summary>
        /// <returns>The average cost of a particular car.</returns>
        /// <param name="inputCommand">User command.</param>
        public int GetAverageCostOfCars(string inputCommand)
        {
            string brand = inputCommand.Substring("average price ".Length);
            int numberOfCars = GetTheNumberOfCars(brand);
            int sumOfCars = databaseInformation.getTheSumOfTheCostPerUnit(brand);
            return numberOfCars / sumOfCars;
        }
    }
}