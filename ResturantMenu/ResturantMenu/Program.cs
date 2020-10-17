using System;

namespace ResturantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem fries = new MenuItem("Fries", 4.99, "This is fries", "Appetizer", true);
            MenuItem steak = new MenuItem("Steak", 19.99, "This is Steak", "Main Course", true);
            MenuItem cookie = new MenuItem("Cookie", 1.99, "This is Cookie", "Dessert", false);

            Menu menu = new Menu();
            menu.AddMenuItem(fries);
            menu.AddMenuItem(steak);
            menu.AddMenuItem(cookie);

            menu.RemoveMenuItem(steak);

            menu.DisplayMenuItems();
            Console.Read();
        }
    }
}
