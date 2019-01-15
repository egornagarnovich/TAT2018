using System.Collections.Generic;
namespace DEV5
{
    /// <summary>
    /// Class containing database.
    /// </summary>
    public class DatabaseOfCars
    {
        Dictionary<string, Dictionary<string, List<int>>> database =
            new Dictionary<string, Dictionary<string, List<int>>>();
        private static DatabaseOfCars objDatabase = new DatabaseOfCars();
        private DatabaseOfCars()
        {}

        /// <summary>
        /// Ensures that only one object is created for the class.
        /// </summary>
        /// <returns>The object of database.</returns>
        public static DatabaseOfCars GetInstance()
        {
            if (objDatabase == null)
                objDatabase = new DatabaseOfCars();
            return objDatabase;
        }

        /// <summary>
        /// Gets or sets the database of car.
        /// </summary>
        /// <value>The database of car.</value>
        public Dictionary<string, Dictionary<string, List<int>>> Database
        {
            get { return database; }
            private set { database = value; }
        }
    }
}