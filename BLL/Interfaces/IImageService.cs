using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.BLL.Interfaces
{
    public interface IImageService
    {
        byte[] ImageToByteArray(string path);

        Image ByteArrayToImage(byte[] bytes);
    }
}
