using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DAL.Interfaces;

namespace Toomeet_Pos.DAL
{
    public class DataAccessLayer : IDataAccessLayer
    {
        private AppDBContext _dbContext;

        public bool TestConnect ()
        {
            try
            {
                GetContext().Database.SqlQuery<int>("SELECT 1").FirstOrDefault();
                return true;
            }
            catch (Exception ex)
            {
                string errorMessage = "Error connecting to database: " + ex.Message;
                Console.WriteLine(errorMessage);
                return false;
            }
        }

        public AppDBContext GetContext()
        {
            if (_dbContext == null) _dbContext =  new AppDBContext();
            return _dbContext;
        }
    }
}
    