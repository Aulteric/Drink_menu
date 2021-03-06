﻿using Drink_Menu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drink_Menu.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public DrinkRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Drink> Drinks => _applicationDbContext.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PreferredDrinks => _applicationDbContext.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Drink GetDrinkById(int drinkId)
        {
            return _applicationDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
        }
    }
}
