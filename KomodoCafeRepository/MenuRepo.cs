using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    public class MenuRepo
    {
        //FakeDatabase
        protected readonly Menu _menu;
        public MenuRepo()
        {
            _menu = new Menu();
        }
        //READ
        public List<MenuItem> GetMenuItems()
        {
            return _menu.MenuItems;
        }
        public Menu GetMenu()
        {
            return _menu;
        }
        //CRUD
        //CREATE
        public bool CreateMenuItem(MenuItem menuItem)
        {
            int startingCount = _menu.MenuItems.Count;
            int uniqueId = GetUniqueId();
            menuItem.Id = uniqueId;
            _menu.MenuItems.Add(menuItem);
            bool wasAdded = (_menu.MenuItems.Count > startingCount);
            return wasAdded;
        }
        //REMOVE
        public bool RemoveMenuItemByMealNumber(int mealNumber)
        {
            if (mealNumber <= 0)
                return false;
            var menuItem = _menu.MenuItems.FirstOrDefault(x => x.MealNumber == mealNumber);
            if (menuItem == null)
                return false;
            return _menu.MenuItems.Remove(menuItem);
        }
        private int GetUniqueId()
        {
            var count = _menu.MenuItems.Count;
            return count += 1;
        }
    }
}
