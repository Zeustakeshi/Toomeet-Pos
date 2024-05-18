using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.UI.UC;

namespace Toomeet_Pos.BLL.Interfaces
{
    public interface IExcelService
    {
        DataTable ImportExcelFile(string path);
        void ExportExcelFile(string path, string tile, CustomDataGridView dataGridView);
    }
}
