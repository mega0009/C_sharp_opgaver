using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgeOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("FancyMenu");
            menu.AddMenuItem(new MenuItem("Punkt1"));
            menu.AddMenuItem(new MenuItem("Punkt2"));
            MenuItem langtpunkt =
                new MenuItem(
                    "Et lidt længere menupunkt",
                    "Indhold af punkt 3... det er indtil videre også bare tekst"
                    );
            menu.AddMenuItem(langtpunkt);


            Menu subMenu = new Menu("Undermenu");
            subMenu.AddMenuItem(new MenuItem("undermenupunkt 1"), new MenuItem("undermenupunkt 2"));
            menu.AddMenuItem(subMenu);

            menu.AddMenuItem(new InfiniteMenu("InfMenu"));
            menu.AddMenuItem(new FileSystemMenu(new DirectoryInfo("c:\\Ugeopgaver"), "Browse filesystem"));

            menu.AddMenuItem(new RSSMenu("http://blog.dota2.com/feed/"));
            menu.AddMenuItem(new DRNyhederMenu());

            menu.Start();
        }
    }
}
