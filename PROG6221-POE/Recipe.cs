namespace PROG6221_POE
{
    class Recipe
    {
        private string[] steps;
        private string[,] ingredients;
        private string[] Prompt = { "Ingredient: ", "Quantity: ", "Unit of measurement: " };

        public Recipe(int _noIngredients, int _noSteps)
        {
            ingredients = new string[_noIngredients, 3];
            steps = new string[_noSteps];
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------\nIngredients: \n");
            for (int i = 0; i < ingredients.GetLength(0); i++)
            {
                
                Console.WriteLine(ingredients[i, 1] + " " + ingredients[i, 2] + " of " + ingredients[i, 0]);

            }
            Console.WriteLine("-----------------------------------");

        }

        public void IngredientPrompt()
        {
            Console.WriteLine("\nPlease enter the ingredients used, the quantity and unit of measurement: ");
            for (int i = 0; i < ingredients.GetLength(0); i++)
            {
                Console.WriteLine("\nINGREDIENT NUMBER: " + (i + 1));

                for (int j = 0; j < ingredients.GetLength(1); j++)
                {
                    Console.Write(Prompt[j]);
                    ingredients[i, j] = Console.ReadLine();
                }
            }
        }

        public void StepsPrompt()
        {
            Console.WriteLine("\nPlease enter the a description for each step: ");

            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine("\nSTEP NUMBER: " + (i + 1));
                steps[i] = Console.ReadLine();
            }
        }
    }
}
