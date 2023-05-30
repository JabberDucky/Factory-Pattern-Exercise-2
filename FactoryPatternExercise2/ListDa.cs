using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDa : IDataAccess
    {
     

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from ListDataAccess database");
             return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to ListDataAccess database");
        }
    }
}
