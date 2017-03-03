using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugeopgave2
{
   abstract class MenuItemBase
    {
        public MenuItemBase(string title)
        {
            this.Title = title;
        }

        public virtual string Title { get; }
        public abstract void Select();
    }
}
