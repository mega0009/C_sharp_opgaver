using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugeopgave2
{
    class MenuItem : MenuItemBase
    {


        // Denne værdi er flyttet til MenuItemBase. 
        //public string Content { get; }


        // Laver en constructer til MenuItem, der kalder base-class constructoren. 
        public MenuItem(string title, string content) : base(title,content)
        {
            //Content = content;
            
        }

        public override void Select()
        {
            // Implementation af metoden

           

        }
    }
}
