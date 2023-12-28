using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class ListDataAccess : Product, IDataAccess
    {
        public ListDataAccess() 
        {
            Name = "List database";
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
