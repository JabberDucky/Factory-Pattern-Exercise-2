using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch(databaseType.ToLower())
            {
                case "list":
                    return new ListDa();
                case "sql":
                    return new SQL();
                case "mongo":
                    return new Mongo();
                default:
                   return new SQL();
            }
        }
    }
}
