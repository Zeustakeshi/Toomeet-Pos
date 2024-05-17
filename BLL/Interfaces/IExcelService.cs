using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.UI.UC;

namespace Toomeet_Pos.BLL.Interfaces
{
    public interface IExcelService
    {
        void ImportExcelFile(string path, CustomDataGridView dataGridView);
        void ExportExcelFile(string path, string tile, CustomDataGridView dataGridView);
    }
}
