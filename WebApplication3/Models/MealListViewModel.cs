using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Entities;

namespace WebApplication3.Models
{
    public class MealListViewModel
    {
        public List<HotMeal> HotMeals { get; set; }
        public List<Drink> Drinks { get; set; }
        public List<FastFood> FastFoods { get; set; }
    }
}
