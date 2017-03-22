using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgeOpgaver
{
    abstract class MenuItemBase
    {
        public MenuItemBase(string title)
        {
            this.Title = title;
        }
        public virtual string Title { get; protected set; }
        public abstract void Select();
    }
}
