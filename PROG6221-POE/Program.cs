using System.Diagnostics.Metrics;

namespace PROG6221_POE
{
    class Program
    {
        static void Main(string[] args)
        {
            int noIngredients, noSteps;
            string name;
            Boolean application = true;

            List<Recipe> recipes = new List<Recipe>();
            Recipe recipe = new Recipe();

            //Testing Samples
            name = "Bacon Pasta";

            string[,] ingredientTest = 
                { {"Basil", "1", "cup" }, {"Bacon", "200", "grams"}, {"Whole peeled Tomatoes", "400", "grams" }, {"Penne", "250", "grams"}};

            string[] stepTest = 
               {"Cook the bacon, in a deep seated pan, untill crispy (to your preference).", 
                "Add the whole peeled tomatoes to the pan. Add the cup of basil to the tomato sauce.", 
                "Bring to a boil and then let it simmer for 20 - 30 minutes.", 
                "Cook the pasta whilst the dish is simmering.", 
                "Once the sauce has finished cooking, as well as the pasta, put the sauce in the pasta pot and mix it.", 
                "Food is ready to eat, can be served with fresh basil on top."};

            recipe.RecipeName = name;
            recipe.Ingredients = ingredientTest;
            recipe.Steps = stepTest;

            Console.WriteLine(recipe.Display());
            recipes.Add(recipe);

            //Console.Title = "RECIPE APPLICATION";
            //Console.ForegroundColor = ConsoleColor.Cyan;

            //Console.WriteLine("Welcome to the Recipe Application!");

            //while (application)
            //{
            //    Console.WriteLine("\nWould you like to capture a recipe? Yes or No");
            //    String option = Console.ReadLine().ToUpper();

            //    if (option.Equals("NO")) { application = false; break; }

            //    Console.WriteLine("\nPlease answer the following requirements: ");

            //    recipe = new Recipe();

            //    Console.Write("\nName of the recipe: ");
            //    name = Console.ReadLine();

            //    Console.Write("\nNumber of ingredients required: ");
            //    noIngredients = int.Parse(Console.ReadLine());

            //    Console.Write("\nNumber of steps to be done: ");
            //    noSteps = int.Parse(Console.ReadLine());

            //    recipe.Ingredients = new string[noIngredients, 3];
            //    recipe.Steps = new string[noSteps];

            //    recipe.IngredientPrompt();
            //    Console.WriteLine(recipe.Display(recipe));

            //}

        }

    }

}