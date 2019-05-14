using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArchivePlug
{
   public interface IArchive
    {
        string Name { get; }
    
        string Format { get; }

        void Compress(string inputFile, string outputFile);
        void Decompress(string inputFile, string outputFile);
    }
}
