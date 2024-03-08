namespace PROG6221_POE
{
    class Recipe
    {
        private string[] steps;
        private string[,] ingredients;

        public Recipe(int _noIngredients, int _noSteps)
        {
            ingredients = new string[_noIngredients, 3];
            steps = new string[_noSteps];
        }

        public void Scale(int val)
        {

            string[,] scaledIngredients = ingredients;

            //Console.Clear();
            Console.WriteLine("-----------------------------------\nIngredients Scaled by: " + val + "\n");

            for (int i = 0; i < scaledIngredients.GetLength(0); i++)
            {
                int temp = int.Parse(scaledIngredients[i, 1]);
                temp = temp * val;
                scaledIngredients[i, 1] = temp.ToString();

                Console.WriteLine(scaledIngredients[i, 1] + " " + scaledIngredients[i, 2] + " of " + scaledIngredients[i, 0]);

            }

            Console.WriteLine("-----------------------------------");

            //Search for "teaspoon" or "tsp"

            //Search for "tablespoon" or "tbsp"

            //Search for "cup" or "c"

            //Search for "ounce" or "oz"

            //Search for "grams" or "g"

        }

        public void Display()
        {
            //Console.Clear();
            Console.WriteLine("-----------------------------------\nIngredients: \n");
            for (int i = 0; i < ingredients.GetLength(0); i++)
            {
                
                Console.WriteLine(ingredients[i, 1] + " " + ingredients[i, 2] + " of " + ingredients[i, 0]);

            }
            Console.WriteLine("-----------------------------------");

        }

        public void IngredientPrompt()
        {
            string[] Prompt = { "Ingredient: ", "Quantity: ", "Unit of measurement: " };

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
            Console.WriteLine("\nPlease enter a description for each step: ");

            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine("\nSTEP NUMBER: " + (i + 1));
                steps[i] = Console.ReadLine();
            }
        }
    }
}
