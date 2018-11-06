using System.Collections.Generic;
namespace DEV5
{
    /// <summary>
    /// Contains methods for retrieving information from the database.
    /// </summary>
    public class DatabaseInformation
    {
        private DEV5.DatabaseOfCars objDatabase = DatabaseOfCars.GetInstance();
        /// <summary>
        /// Reads database fields. Counts data.
        /// </summary>
        /// <returns>Car brand list.</returns>
        public List<string> GetAllBrands()
        {
            List<string> brands = new List<string>();
            foreach (string brand in objDatabase.Database.Keys)
            {
                brands.Add(brand);
            }
            return brands;
        }

        /// <summary>
        /// Reads database fields. Counts data.
        /// </summary>
        /// <returns>The the sum of car of the cost per unit.</returns>
        public int getTheSumOfTheCostPerUnit()
        {
            int countOfCostPerUnit = 0;
            foreach (var elementValues in objDatabase.Database.Values)
            {
                foreach (var element in elementValues.Values)
                {
                    countOfCostPerUnit += element[1];
                }
            }
            return countOfCostPerUnit;
        }

        /// <summary>
        /// Reads database fields. Counts data.
        /// </summary>
        /// <returns>The amount of the cost of a particular car brand  per  unit.</returns>
        /// <param name="brand">Brand of car.</param>
        public int getTheSumOfTheCostPerUnit(string brand)
        {
            int countOfCostPerUnit = 0;
            foreach (KeyValuePair<string, Dictionary<string, List<int>>> pair in objDatabase.Database)
            {
                if (pair.Key == brand)
                {
                    foreach (var elementValues in pair.Value)                        
                    {
                        countOfCostPerUnit += elementValues.Value[1];
                    }
                }
            }
            return countOfCostPerUnit;
        }

        /// <summary>
        /// Rads database fields. Add data to list.
        /// </summary>
        /// <returns>List of cars of each brand.</returns>
        public List<int> GetOfQuantityAllCars()
        {
            List<int> listOfCars = new List<int>();
            foreach (var elementValues in objDatabase.Database.Values)
            {
                foreach (var element in elementValues.Values)
                {
                    listOfCars.Add(element[0]);
                }
            }
            return listOfCars;
        }

        /// <summary>
        /// Rads database fields. Add data to list.
        /// </summary>
        /// <returns>List of cars of a particular brand.</returns>
        /// <param name="brand">Brand of car.</param>
        public List<int> GetOfQuantityAllCars(string brand)
        {
            List<int> listOfCars = new List<int>();
            foreach (KeyValuePair<string, Dictionary<string, List<int>>> pair in objDatabase.Database)
            {
                if (pair.Key == brand)
                {
                    foreach (var elementValues in pair.Value)
                    {
                        listOfCars.Add(elementValues.Value[0]);
                    }
                }
            }
            return listOfCars;
        }
    }
}