namespace DEV5
{
    /// <summary>
    /// Class Car.
    /// Information about cars, brand and their number.
    /// </summary>
    public class Car
    {
        string brandOfCar;
        string modelOfCar;
        int quantityOfCar;
        int costPerUnitOfCar;
        private static Car objCar = new Car();

        /// <summary>
        /// Ensures that only one object is created for the class.
        /// </summary>
        /// <returns>The object of car.</returns>
        public static Car GetObjCar()
        {
            if (objCar == null)
                objCar = new Car();
            return objCar;
        }

        /// <summary>
        /// Gets or sets the brand of car.
        /// </summary>
        /// <value>The brand of car.</value>
        public string Brand
        {
            get { return brandOfCar; }
            set { brandOfCar = value; }
        }

        /// <summary>
        /// Gets or sets the model of car.
        /// </summary>
        /// <value>The model of car.</value>
        public string Model
        {
            get { return modelOfCar; }
            set { modelOfCar = value; }
        }

        /// <summary>
        /// Gets or sets the quantity of car.
        /// </summary>
        /// <value>The quantity of car.</value>
        public int Quantity
        {
            get { return quantityOfCar; }
            set { quantityOfCar = value; }
        }

        /// <summary>
        /// Gets or sets the cost per unit of car.
        /// </summary>
        /// <value>The cost per unit of car.</value>
        public int CostPerUnit
        {
            get { return costPerUnitOfCar; }
            set { costPerUnitOfCar = value; }
        }
    }
}