using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CComLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace TabHeaderDemo.hardcontrol
{
    [Serializable]
    
     public class CFileStruct  :FileStruct 

    {
        public CFileStruct()
        {

        }

        public void SerializeNow(string filename)
        {

            FileStream fileStream =
            new FileStream(filename, FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(fileStream, this);
            fileStream.Close();
        }

    }
}
