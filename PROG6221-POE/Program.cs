namespace PROG6221_POE
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredients, steps;

            Console.Title = "RECIPE APPLICATION";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Welcome to the Recipe Application! \nPlease will you enter the following requirements:");

            Console.WriteLine("\nThe number of ingredients used in this recipe: ");
            ingredients = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe number of steps required: ");
            steps = int.Parse(Console.ReadLine());

            Recipe recipe = new Recipe(ingredients, steps);

            recipe.IngredientPrompt();
            recipe.StepsPrompt();
            recipe.Display();


        }

    }

}