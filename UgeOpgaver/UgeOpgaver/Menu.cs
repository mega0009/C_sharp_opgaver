using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UgeOpgaver
{
    class Menu : MenuItemBase
    {
        private const ConsoleColor HeadlineColor = ConsoleColor.Cyan;
        private const ConsoleColor ItemColor = ConsoleColor.Black;
        private const ConsoleColor SelectedItemColor = ConsoleColor.DarkCyan;
        private List<MenuItemBase> _menuItems = new List<MenuItemBase>();
        public int SelelectedIndex { get; protected set; } = 0; // lavet om til en property og setter er nu protected
        public int Count => _menuItems.Count; // vi skal bruge itemcount til at sætte selected item, når antallet kan variere

        public void AddMenuItem(params MenuItemBase[] items)
        {
            foreach (MenuItemBase menuItem in items)
            {
                _menuItems.Add(menuItem);
            }
        }

        protected void ClearMenuItems()
        {
            _menuItems.Clear();
        }

        private string MenuHeadline => $"[[[ {Title} ]]]"; 
        public Menu(string title, params MenuItemBase[] menuItems) : base(title)
        {
            foreach (MenuItemBase item in menuItems)
            {
                this._menuItems.Add(item);
            }
        }

        private void DrawMenu()
        {
            Console.Clear();
            Console.Title = Title;
            PrintStringCentered(MenuHeadline, HeadlineColor);
            for (int index = 0; index < _menuItems.Count; index++)
            {
                ConsoleColor color = SelelectedIndex == index ? SelectedItemColor:ItemColor;
                PrintStringCentered(_menuItems[index].Title, color);
            }
        }

        private void PrintStringCentered(string v, ConsoleColor color)
        {
            Console.CursorLeft = Padding(v);
            ConsoleColor oldColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
            Console.WriteLine(v);
            Console.BackgroundColor = oldColor;
        }

        private int Padding(string str)
        {
            int middle = Console.WindowWidth / 2;
            return middle - (str.Length / 2); 
        }

        private bool _running;
        public void Start()
        {
            _running = true;
            do
            {
                DrawMenu();
                HandleInput();
            } while (_running);
        }

        private void HandleInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.Backspace:
                case ConsoleKey.Escape:
                    _running = false;
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                case ConsoleKey.Enter:
                    CurrentMenuItem.Select();
                    break;
                default:
                    break;
            }
        }

        public MenuItemBase CurrentMenuItem => _menuItems[SelelectedIndex];

        private void MoveDown()
        {
            if(_menuItems.Count>0)
                SelelectedIndex = (SelelectedIndex + 1) % _menuItems.Count;
        }

        private void MoveUp()
        {
            if(_menuItems.Count>0)
                SelelectedIndex = (SelelectedIndex -1 + _menuItems.Count) % _menuItems.Count;
        }

        public override void Select()
        {
            Start();
        }
    }
}
