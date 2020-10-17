using System;
using System.Collections.Generic;
using System.Text;

//Setting up a menu to display all the menu items, also date/time of last update

namespace ResturantMenu
{
    class Menu
    {
        List<MenuItem> displayMenu = new List<MenuItem>(); 
        DateTime lastUpdated;

        //constructor?
        public Menu( )
        {

        }

        //method to add menu item to menu list
        public void AddMenuItem(MenuItem newItem)
        {
            displayMenu.Add(newItem);
            lastUpdated = DateTime.Now;
        }

        //method to remove menu item from menu list
        public void RemoveMenuItem(MenuItem badItem)
        {
            displayMenu.Remove(badItem);
            lastUpdated = DateTime.Now;
        }

        //method of displaying what happens if menuitem is new
        public string NewMenuItem(bool isItemNew)
        {
            if (isItemNew)
            {
                return ". This is a new menu item.";
            }
            else
            {
                return ".";
            }
        }

        //method to display all the menu items
        public void DisplayMenuItems()
        {
            Console.WriteLine("Menu last updated: {0}", lastUpdated);
            foreach(MenuItem item in displayMenu)
            {
                Console.WriteLine("Name: {0}, Price ${1}, Description: {2}, Category: {3}{4}", item.Name, item.Price, item.Description, item.Category, NewMenuItem(item.IsNew));
            }
            
        }

    }
}
