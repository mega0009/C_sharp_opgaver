using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgeOpgaver
{
    class FileSystemMenu : Menu
    {
        DirectoryInfo _root;

        public FileSystemMenu(DirectoryInfo dir, string title) : base(title)
        {
            _root = dir;
        }

        protected FileSystemMenu(DirectoryInfo dir) : this(dir, dir.Name)
        {}

        bool _firstTime = true;
        public override void Select()
        {
            if (_firstTime)
            {
                _firstTime = false;
                foreach (DirectoryInfo subdir in _root.GetDirectories())
                {
                    AddMenuItem(new FileSystemMenu(subdir));
                }

                foreach (FileInfo file in _root.GetFiles())
                {
                    AddMenuItem(new FileMenuItem(file));
                }
            }
            base.Select();
        }
    }
}
