using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drink_Menu.Models
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; }
        IEnumerable<Drink> PreferredDrinks { get; }
        Drink GetDrinkById(int drinkId);
    }
}
