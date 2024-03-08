namespace PROG6221_POE
{
    class Recipe
    {
        private string recipeName;
        private string[] steps;
        private string[,] ingredients;

        public Recipe()
        {
        }

        public Recipe(string _recipeName, string[] _steps, string[,] _ingredients) { 

            recipeName = _recipeName;
            steps = _steps;
            ingredients = _ingredients;
        }

        public string RecipeName
        {
            get { return recipeName; }
            set { recipeName = value; }
        }

        public string[] Steps
        {
            get { return steps; }
            set { steps = value; }
        }

        public string[,] Ingredients
        { 
            get { return ingredients; }
            set { ingredients = value; }    
        }

        public void Scale(int val)
        {

            string[,] scaledIngredients = ingredients;

            for (int i = 0; i < scaledIngredients.GetLength(0); i++)
            {
                int temp = int.Parse(scaledIngredients[i, 1]);
                temp = temp * val;
                scaledIngredients[i, 1] = temp.ToString();
            }

            

            //Search for "teaspoon" or "tsp"

            //Search for "tablespoon" or "tbsp"

            //Search for "cup" or "c"

            //Search for "ounce" or "oz"

            //Search for "grams" or "g"

        }

        public string Display()
        {
            string display = "-----------------------------------\nIngredients: \n-----------------------------------\n";
            
            for (int i = 0; i < ingredients.GetLength(0); i++)
            {

                display = display + ingredients[i, 1] + " " + ingredients[i, 2] + " of " + ingredients[i, 0] + "\n";

            }
            display = display + "-----------------------------------\nSteps: \n-----------------------------------\n";

            for (int i = 0; i < steps.Length; i++)
            {

                display = display + (i+1) + ") " + steps[i] + "\n";

            }

            return display;
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
