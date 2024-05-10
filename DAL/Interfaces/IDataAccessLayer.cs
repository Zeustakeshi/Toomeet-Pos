using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.DAL.Interfaces
{
    public interface IDataAccessLayer
    {
        AppDBContext GetContext();
        bool TestConnect();
    }
}
