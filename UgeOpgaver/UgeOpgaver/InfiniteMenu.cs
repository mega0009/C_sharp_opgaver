using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgeOpgaver
{
    class InfiniteMenu : Menu
    {
        public InfiniteMenu(string title) : base(title)
        {
        }

        bool _firstTime = true;

        public override void Select()
        {
            if (_firstTime)
            {
                for (int i = 0; i < 6; i++)
                {
                    this.AddMenuItem(new InfiniteMenu(this.Title + " - " + i));
                }
                _firstTime = false;
            }
            base.Select();
        }
    }
}
