using Recipe;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class Recipe
    {
        private Ingredients[] ingredients;
        private string[] steps;
        private const int MaxSteps = 10;
        private const int MaxIngredients = 10;


        public Recipe()
        {
            ingredients = new Ingredients[MaxIngredients];
            steps = new string[MaxSteps];
        }
        public void InsertIngredients()
        {
            Console.WriteLine("Enter the amount of ingredients needed: ");
            int AmountIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < AmountIngredients; i++)
            {
                Console.WriteLine($"Enter the name of ingredients #{i + 1}:");
                string name = Console.ReadLine();
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine("unit of measurement:");
                string unit = Console.ReadLine();

                ingredients[i] = new Ingredients { name = name, quantity = quantity, unit = unit };
            }

        }
        public static void DisplayRecipe(Recipe recipe)
        {
            Console.WriteLine("Ingredients:");
            foreach (Ingredients ingredient in recipe.ingredients)
            {
                Console.WriteLine($"{ingredient.quantity} {ingredient.unit} {ingredient.name}");
            }
        }

        public static void ScaleRecipe(Recipe recipe, double factor)
        {
            foreach (Ingredients ingredient in recipe.ingredients)
            {
                ingredient.quantity *= factor;
            }
        }

        static void RestQuantities(Recipe recipe)
        { 
            foreach (Ingredients ingredient in recipe.ingredients)
            {
                ingredient.quantity = 0;
            }
        }

        internal void ClearRecipe()
        {
            throw new NotImplementedException();
        }

        internal void ScaleRecipe(double factor)
        {
            throw new NotImplementedException();
        }
    }
}