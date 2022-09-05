using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class LikSubFile
    {
        public string FilePath { get; set; }

        public byte[] FileData { get; set; }

        public void LoadFileData()
        {
            Console.WriteLine("Load file data");
            //Load the file details from the path
        }        
    }

    public class WritableFile : LikSubFile
    {
        public void SaveFileData()
        {
            Console.WriteLine("Write file data");
        }
    }
}
