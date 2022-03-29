using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Entities;
using WebApplication3.Models;

namespace WebApplication3.Controls
{
    public class HomeController : Controller
    {
        List<Drink> drink = new List<Drink>
            {
                new Drink {Id=1, PhotoShortPath="lemon_juice.jpg", Name="Lemon Juice", Price= 23.1},
                new Drink {Id=2, PhotoShortPath="pineapple_juice.jpg",  Name="Pineapple Juice", Price= 23.1},
                new Drink {Id=3, PhotoShortPath="amaretto_sour.jpg",  Name="Amaretto Sour", Price= 23.1},
                new Drink {Id=4, PhotoShortPath="lemon_juice.jpg",  Name="Coca-Cola", Price= 23.1},
                new Drink {Id=5, PhotoShortPath="Mojito.jpg",  Name="Mojito", Price= 23.1},
                new Drink {Id=6, PhotoShortPath="water.jpg",  Name="Water", Price= 23.1},
            };
        List<HotMeal> meal = new List<HotMeal>
            {
                new HotMeal {Id=1, PhotoShortPath="roasted_beef.jpg", Name="Roast Beef", Price= 23.1},
                new HotMeal {Id=2, PhotoShortPath="sweet_sour_pork.jpg",  Name="Sweet and Sour Pork", Price= 23.1},
                new HotMeal {Id=3, PhotoShortPath="vegetable_soup.jpg",  Name="Vegetable Soup", Price= 23.1},
                new HotMeal {Id=4, PhotoShortPath="garlicky_shrimp_zucchini_boats.jpg",  Name="Garlicky Shrimp Zucchini Boats", Price= 23.1},
                new HotMeal {Id=5, PhotoShortPath="spicy_chicken_taquitos.jpg",  Name="Spicy Chicken Taquitos", Price= 23.1},
                new HotMeal {Id=6, PhotoShortPath="maple_glazed_ham.jpg",  Name="Maple Glazed Ham Steak", Price= 23.1},
            };
        List<FastFood> fasts = new List<FastFood>
            {
                new FastFood {Id=1, PhotoShortPath="fish_and_chips.jpg", Name="Fish and Chips", Price= 23.1},
                new FastFood {Id=2, PhotoShortPath="hamburger.jpg",  Name="Pineapple Juice", Price= 23.1},
                new FastFood {Id=3, PhotoShortPath="pizza.jpg",  Name="Pizza", Price= 23.1},
                new FastFood {Id=4, PhotoShortPath="taco.jpg",  Name="Tacos", Price= 23.1},
                new FastFood {Id=5, PhotoShortPath="french_fries.jpg",  Name="French Fries", Price= 23.1},
                new FastFood {Id=6, PhotoShortPath="onion_rings.jpg",  Name="Onion Rings", Price= 23.1},
            };
        public IActionResult Index()
        {

            MealListViewModel model = new MealListViewModel { Drinks = drink, FastFoods = fasts, HotMeals = meal };

            return View(model);
        }
        public IActionResult Drinks()
        {
            return View(drink);
        }
        public IActionResult Hotmeals()
        {
            return View(meal);
        }
        public IActionResult Fastfoods()
        {
            return View(fasts);
        }

    }
}
