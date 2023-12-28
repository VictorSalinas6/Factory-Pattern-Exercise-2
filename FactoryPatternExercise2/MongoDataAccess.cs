using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : Product, IDataAccess
    {

        public MongoDataAccess() 
        {
            Name = "Mongo database";
        }

        public void LoadData()
        {
            Console.WriteLine($"I am reading data from a {Name}");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a {Name}");
        }
    }
}
