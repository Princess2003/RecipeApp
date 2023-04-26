using Recipe;
using System;
using System.Diagnostics;

namespace RecipeApp;
public class Program
{
    public static void Main(string[] args)
    {
        Recipe Recipe = new Recipe();

        while (true)

        {

            Console.WriteLine("1. Enter 1 for Recipe details");
            Console.WriteLine("2. Enter 2 to Display recipe");
            Console.WriteLine("3. Enter 3 to Scale recipe");
            Console.WriteLine("4. Enter 4 to Rest quantities");
            Console.WriteLine("5. Enter 5 to Clear recipe");
            Console.WriteLine("6. Enter 6 to Exit");

            Console.WriteLine("Enter any option:");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Recipe.InsertIngredients();
                    break;

                case 2:
                    DisplayRecipe(Recipe);
                    break;

                case 3:
                    Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                    double factor = double.Parse(Console.ReadLine());
                    Recipe.ScaleRecipe(factor);
                    break;

                case 4:
                    ResetQuantities(Recipe);
                    break;


                case 5:
                    Recipe.ClearRecipe();
                    Recipe = new Recipe();
                    break;

                case 6:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;


            }
        }
    }

    private static void ResetQuantities(Recipe recipe)
    {
        throw new NotImplementedException();
    }

    private static void DisplayRecipe(Recipe recipe)
    {
        throw new NotImplementedException();
    }

    static int Readint(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            Console.WriteLine("invalid input.Please Enter an integer");
        }
    }
    static double Readdouble(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            Console.WriteLine("invalid input.Please Enter a number");
        }
    }
}
