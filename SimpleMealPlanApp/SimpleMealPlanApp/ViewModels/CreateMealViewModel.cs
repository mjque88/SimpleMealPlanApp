using SimpleMealPlanApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMealPlanApp.ViewModels
{
    class CreateMealViewModel
    {
        public Meal Meal { get; set; }

        public CreateMealViewModel()
        {
            Meal = new Meal();
        }
    }
}
