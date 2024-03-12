using System.Diagnostics.Metrics;

namespace PROG6221_POE
{
    class Program
    {
        static void Main(string[] args)
        {
            int noIngredients, noSteps, index, scale;
            string option, confirm;
            Boolean application = true;

            List<Recipe> recipes = new List<Recipe>();
            Recipe recipe = new Recipe();

            //Recipe Sample 1
            recipe.RecipeName = "Bacon Pasta";

            recipe.Ingredients = new string[4, 3]
                { {"Basil", "1", "cup" }, {"Bacon", "200", "grams"}, {"Whole peeled tomatoes", "400", "grams" }, {"Penne", "250", "grams"}};

            recipe.Steps = new string[6] 
               {"Cook the bacon, in a deep seated pan, untill crispy (to your preference).", 
                "Add the whole peeled tomatoes to the pan. Add the cup of basil to the tomato sauce.", 
                "Bring to a boil and then let it simmer for 20 - 30 minutes.", 
                "Cook the pasta whilst the dish is simmering.", 
                "Once the sauce has finished cooking, as well as the pasta, put the sauce in the pasta pot and mix it.", 
                "Food is ready to eat, can be served with fresh basil on top."};

            recipes.Add(recipe);

            //Recipe Sample 2
            recipe = new Recipe();

            recipe.RecipeName = "Napolitana Sauce";

            recipe.Ingredients = new string[8,3]
                { {"Garlic", "2", "tsp" }, {"Italian Herbs", "3", "tsp"}, {"Sugar", "1", "tsp" }, {"Basil", "0,5", "cup" }, {"Whole peeled tomatoes", "400", "grams" },
                {"Tomato paste", "2", "tbsp"}, {"Onion", "1", "cup" }, {"Linguine", "350", "gram"}};

            recipe.Steps = new string[7]
               {"Bring a large saucepan of water to boil, salt well, then add your pasta. Cook to just al dente (check packet) and drain, reserving a little pasta water.",
                "In the meantime, in a deep saucepan, over medium heat, heat the oil.",
                "Saute onions, carrot and salt together until softened (3-4 minutes).",
                "Add the rest of the ingredients, blend if you’d like a smoother consistency.",
                "Bring to simmer then turn down to low heat (cover with a lid) and cook 8-10 minutes, stirring every so often.",
                "Add the cooked pasta and mix well to combine. Add a little of the pasta water if you need to loosen the sauce.",
                "Top generously with chopped fresh basil." };

            //Reference for Napolitana Sauce.
            //Roffey, M. (2022) Pasta napolitana, Sugar Salt Magic. Available at: https://www.sugarsaltmagic.com/pasta-napolitana/ (Accessed: 10 March 2024). 

            recipes.Add(recipe);

            Console.Title = "RECIPE APPLICATION";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Welcome to the Recipe Application!\n");

            while (application)
            {
                Console.WriteLine("Please select one of the following options: \n\n1) Add a new recipe \n2) Scale a recipe \n3) Display a recipe \n4) Show all saved recipes \n5) Delete a recipe \n6) Exit");
                option = Console.ReadLine();
                

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Please enter the following requirements: ");

                        recipe = new Recipe();

                        Console.Write("\nName of the recipe: ");
                        recipe.RecipeName = Console.ReadLine();

                        Console.Write("\nNumber of ingredients required: ");
                        noIngredients = int.Parse(Console.ReadLine());

                        Console.Write("\nNumber of steps to be done: ");
                        noSteps = int.Parse(Console.ReadLine());

                        recipe.Ingredients = new string[noIngredients, 3];
                        recipe.Steps = new string[noSteps];

                        recipe.IngredientPrompt();
                        recipe.StepsPrompt();
                        Console.WriteLine(recipe.Display(recipe.Ingredients));
                        recipes.Add(recipe);

                        Console.WriteLine("Enter any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Which recipe would you like to scale?\n");

                        for (int i = 0; i < recipes.Count(); i++) {
                            Console.WriteLine((i+1) + ") " + recipes[i].RecipeName);
                        }

                        index = int.Parse(Console.ReadLine()); index--;
                        recipe = recipes[index];
                        Console.WriteLine("Please enter how much you would like to scale the recipe by: (Eg: 0.5 / 2 / 3)");
                        scale = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine(recipe.RecipeName + " scaled by: " + scale + "\n"+ recipe.Scale(scale));
                        Console.WriteLine("Enter any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Which recipe would you like to display?\n");

                        for (int i = 0; i < recipes.Count(); i++)
                        {
                            Console.WriteLine((i + 1) + ") " + recipes[i].RecipeName);
                        }

                        index = int.Parse(Console.ReadLine()); index--;
                        recipe = recipes[index];

                        Console.Clear();
                        Console.WriteLine(recipe.RecipeName + "\n" + recipe.Display(recipe.Ingredients));
                        Console.WriteLine("Enter any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Saved Recipes: \n-----------------------------------");
                        for (int i = 0; i < recipes.Count(); i++)
                        {
                            Console.WriteLine((i + 1) + ") " + recipes[i].RecipeName);
                        }
                        Console.WriteLine("\nEnter any key to continue.");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Which recipe would you like to delete?\n");

                        for (int i = 0; i < recipes.Count(); i++)
                        {
                            Console.WriteLine((i + 1) + ") " + recipes[i].RecipeName);
                        }

                        index = int.Parse(Console.ReadLine()); index--;
                        

                        Console.WriteLine("\nAre you sure you want to DELETE this recipe? Yes or No");
                        confirm = Console.ReadLine().ToUpper();
                        if (confirm.Equals("YES")) { recipes.RemoveAt(index); Console.WriteLine("Recipe successfully deleted!"); }
                        else { Console.WriteLine("Deletion of this recipe was canceled!"); }

                        Console.WriteLine("\nEnter any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "6":
                        application = false;
                        break;

                    default:
                        Console.WriteLine("Incorrect value was entered.");
                        Console.WriteLine("\nEnter any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }



            }

        }

    }

}