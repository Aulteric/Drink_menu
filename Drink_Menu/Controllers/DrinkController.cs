using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drink_Menu.Models;
using Drink_Menu.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Drink_Menu.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }

        public ViewResult List()
        {
            var vm = new DrinkListViewModel();
            vm.Drinks = _drinkRepository.Drinks;
            vm.CurrentCategory = "DrinkCategory";
            return View(vm);
        }
    }
}