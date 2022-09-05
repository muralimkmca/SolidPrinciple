using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class ProjectFile
    {
        public string FilePath { get; set; }

        public byte[] FileData { get; set; }

        public void LoadFileData()
        {
            //Load the file details from the path
        }

        public virtual void SaveFileData()
        {
            //Add the datas to the file
        }
    }

    public class ReadOnlyFile :ProjectFile
    {
        public override void SaveFileData()
        {
            throw new InvalidOperationException();
        }
    }
}
