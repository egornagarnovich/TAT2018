using System.Collections.Generic;
namespace DEV5
{
    /// <summary>
    /// Database builds class.
    /// </summary>
    public class DatabaseBuilder
    {
        private DEV5.Car car = Car.GetInstance();
        private DEV5.DatabaseOfCars objDatabase = DatabaseOfCars.GetInstance();

        /// <summary>
        /// Reads car class fields.
        /// Writes data to the database.
        /// </summary>
        public void Build()
        {
            if (objDatabase.Database.Count == 0 ||
                !objDatabase.Database.ContainsKey(car.Brand))
            {
                Dictionary<string, List<int>> newDataBrand = new Dictionary<string, List<int>>();
                List<int> dataOfModel = new List<int>();
                dataOfModel.Add(car.Quantity);
                dataOfModel.Add(car.CostPerUnit);
                newDataBrand.Add(car.Model, dataOfModel);
                objDatabase.Database.Add(car.Brand, newDataBrand);
            }
            else
            {
                foreach (var elementValues in objDatabase.Database.Values)
                {
                    if (elementValues.ContainsKey(car.Model))
                    {
                        objDatabase.Database[car.Brand][car.Model][0] += car.Quantity;
                        objDatabase.Database[car.Brand][car.Model][1] += car.CostPerUnit;
                    }
                    else
                    {
                        Dictionary<string, List<int>> newDataModel = new Dictionary<string, List<int>>();
                        List<int> dataModel = new List<int>();
                        dataModel.Add(car.Quantity);
                        dataModel.Add(car.CostPerUnit);
                        objDatabase.Database[car.Brand].Add(car.Model, dataModel);
                    }
                }
            }
        }
    }
}