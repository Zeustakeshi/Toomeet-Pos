using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.BLL.Interfaces;

namespace Toomeet_Pos.BLL
{
    public class ImageService : IImageService
    {
     

        public byte[] ImageToByteArray(string path)
        {
            byte[] byteArray = null;
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    byteArray = reader.ReadBytes((int)stream.Length);
                }
            }
            return byteArray;
        }

        public Image ByteArrayToImage(byte[] bytes)
        {
            return StaticByteArrayToImage(bytes);
        }

        public static Image StaticByteArrayToImage(byte[] bytes)
        {
            Image image;

            using (MemoryStream stream = new MemoryStream(bytes))
            {
                image = Image.FromStream(stream);
            }

            return image;
        }
    }
}
