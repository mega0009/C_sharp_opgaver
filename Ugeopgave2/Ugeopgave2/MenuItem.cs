using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugeopgave2
{
    class MenuItem
    {
        public string Title;
        public string Content;

        // Laver en constructer til MenuItem
        public MenuItem(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
