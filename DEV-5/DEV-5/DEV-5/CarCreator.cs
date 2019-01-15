namespace DEV5
{
    /// <summary>
    /// Car creator class.
    /// </summary>
    public class CarCreator
    {
        DEV5.Car car = Car.GetInstance();
        DEV5.Interviewer interviewer = Interviewer.GetObjInterviewer();

        /// <summary>
        /// Creats new car.
        /// </summary>
        public void Create()
        {
            car.Brand = interviewer.AskBrandOfCars();
            car.Model = interviewer.AskModelOfCars();
            car.Quantity = interviewer.AskQuantityOfCars();
            car.CostPerUnit = interviewer.AskCostPerUnitOfCar();
        }
    }
}