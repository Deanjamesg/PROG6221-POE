using System.Diagnostics.Metrics;

namespace PROG6221_POE
{
    class Program
    {
        static void Main(string[] args)
        {
            int noIngredients, noSteps;
            Boolean application = true;

            List<Recipe> recipes = new List<Recipe>();
            Recipe recipe = new Recipe();

            //Recipe Sample 1

            string[,] ingredientSample01 = 
                { {"Basil", "1", "cup" }, {"Bacon", "200", "grams"}, {"Whole peeled tomatoes", "400", "grams" }, {"Penne", "250", "grams"}};

            string[] stepSample01 = 
               {"Cook the bacon, in a deep seated pan, untill crispy (to your preference).", 
                "Add the whole peeled tomatoes to the pan. Add the cup of basil to the tomato sauce.", 
                "Bring to a boil and then let it simmer for 20 - 30 minutes.", 
                "Cook the pasta whilst the dish is simmering.", 
                "Once the sauce has finished cooking, as well as the pasta, put the sauce in the pasta pot and mix it.", 
                "Food is ready to eat, can be served with fresh basil on top."};

            recipe.RecipeName = "Bacon Pasta";
            recipe.Ingredients = ingredientSample01;
            recipe.Steps = stepSample01;

            recipes.Add(recipe);

            //Recipe Sample 2
            recipe = new Recipe();

            string[,] ingredientSample02 =
                { {"Garlic", "2", "tsp" }, {"Italian Herbs", "3", "tsp"}, {"Sugar", "1", "tsp" }, {"Basil", "0,5", "cup" }, {"Whole peeled tomatoes", "400", "grams" },
                {"Tomato paste", "2", "tbsp"}, {"Onion", "1", "cup" }, {"Linguine", "350", "gram"}};

            string[] stepSample02 =
               {"Bring a large saucepan of water to boil, salt well, then add your pasta. Cook to just al dente (check packet) and drain, reserving a little pasta water.",
                "In the meantime, in a deep saucepan, over medium heat, heat the oil.",
                "Saute onions, carrot and salt together until softened (3-4 minutes).",
                "Add the rest of the ingredients, blend if you’d like a smoother consistency.",
                "Bring to simmer then turn down to low heat (cover with a lid) and cook 8-10 minutes, stirring every so often.",
                "Add the cooked pasta and mix well to combine. Add a little of the pasta water if you need to loosen the sauce.",
                "Top generously with chopped fresh basil." };

            //Reference for Napolitana Sauce.
            //Roffey, M. (2022) Pasta napolitana, Sugar Salt Magic. Available at: https://www.sugarsaltmagic.com/pasta-napolitana/ (Accessed: 10 March 2024). 

            recipe.RecipeName = "Napolitana Sauce";
            recipe.Ingredients = ingredientSample02;
            recipe.Steps = stepSample02;

            recipes.Add(recipe);

            Console.WriteLine(recipes[1].Display(recipe.Ingredients));
            Console.WriteLine(recipes[1].Scale(2));




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