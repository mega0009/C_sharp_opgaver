using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgeOpgaver
{
    class FileMenuItem : MenuItemBase
    {
        FileInfo _file;
        public FileMenuItem(FileInfo file) : base(file.Name)
        {
            _file = file;
        }

        public override void Select()
        {
            Console.Clear();
            Console.WriteLine($"File: {_file.FullName}" );
            Console.WriteLine($"size: {_file.Length}");
            Console.ReadKey();
        }
    }
}
