using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgeOpgaver
{
    class MenuItem : MenuItemBase
    {
        public MenuItem(string title) : this(title, "")
        {
        }

        public MenuItem(string title, string content) : base(title)
        {
            this.Content = content;
        }

        public string Content { get; }

        public override void Select()
        {
            string oldTitle = Console.Title;
            Console.Title = Title;
            Console.Clear();
            Console.WriteLine(Title);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.ReadKey();
            Console.Title = oldTitle;
        }
    }
}
