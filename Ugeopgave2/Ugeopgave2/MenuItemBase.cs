using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugeopgave2
{
   abstract class MenuItemBase
    {
        public MenuItemBase(string title, string content)
        {
            this.Title = title;
            this.Content = content;

        }

        public virtual string Title { get; }
        public virtual string Content { get; }

        public abstract void Select();
    }
}
