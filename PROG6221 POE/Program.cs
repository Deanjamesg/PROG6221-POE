﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE
{
    class Program
    {
        public static void Main(string[] args)
        {

            string option;

            Boolean application;

            Recipe recipe = new Recipe
            {
            name = "Bacon Pasta",
            scaleFactor = 1,
            ingredients = new string[,]
            {
                { "Basil", "1", "cup" },
                { "Bacon", "200", "grams" },
                { "Whole peeled tomatoes", "400", "grams" },
                { "Penne", "250", "grams" }
            },
            steps = new string[]
            {
                "Cook the bacon, in a deep seated pan, until crispy (to your preference).",
                "Add the whole peeled tomatoes to the pan. Add the cup of basil to the tomato sauce.",
                "Bring to a boil and then let it simmer for 20 - 30 minutes.",
                "Cook the pasta whilst the dish is simmering.",
                "Once the sauce has finished cooking, as well as the pasta, put the sauce in the pasta pot and mix it.",
                "Food is ready to eat, can be served with fresh basil on top."
            }
            };

            application = true;

            Console.Title = "RECIPE APPLICATION";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Welcome to the Recipe Application!\n");

            while (application)
            {
                Console.WriteLine("Please select one of the following options: \n\n1) Create a new recipe \n2) Scale a recipe \n3) Reset scale to original \n4) Display recipe \n5) Delete recipe \n6) Exit");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1": //Create a New Recipe

                        recipe = new Recipe();
                        recipe.CreateNewRecipe();
                        break;

                    case "2": //Scale a Recipe

                        recipe.ScaleRecipe();
                        break;

                    case "3": //Reset recipe scale factor to original

                        recipe.ResetScale();
                        break;

                    case "4": //Display Recipe

                        recipe.DisplayRecipe();
                        break;

                    case "5": //Delete Recipe

                        recipe.DeleteRecipe();
                        break;

                    case "6": //Exit Application

                        application = false;
                        break;

                    default:
                        Console.WriteLine("Incorrect value was entered.");
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

        }
    }
}
