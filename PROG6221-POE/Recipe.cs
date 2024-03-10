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

        public Recipe(string _recipeName, string[] _steps, string[,] _ingredients) 
        { 

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

        public string Scale(double val)
        {

            string scaledRecipe = "";
            string[,] scaledIngredients = ingredients;

            for (int i = 0; i < scaledIngredients.GetLength(0); i++)
            {
                double temp = double.Parse(scaledIngredients[i, 1]);
                temp = temp * val;
                scaledIngredients[i, 1] = temp.ToString();

                switch (scaledIngredients[i, 2])
                {
                    case "tsp":
                        if (double.Parse(scaledIngredients[i, 1]) >= 3)
                        {
                            double quantity = double.Parse(scaledIngredients[i, 1]);
                            switch (quantity)
                            {
                                case 3:
                                    scaledIngredients[i, 1] = 1.ToString(); scaledIngredients[i, 2] = "tbsp"; break;
                                case 6:
                                    scaledIngredients[i, 1] = 2.ToString(); scaledIngredients[i, 2] = "tbsp"; break;
                                case 9:
                                    scaledIngredients[i, 1] = 3.ToString(); scaledIngredients[i, 2] = "tbsp"; break;
                                case 12:
                                    scaledIngredients[i, 1] = 0.25.ToString(); scaledIngredients[i, 2] = "cup"; break;
                            }
                            
                        }
                        break;

                    case "tbsp":
                        if (double.Parse(scaledIngredients[i, 1]) >= 4)
                        {
                            double quantity = double.Parse(scaledIngredients[i, 1]);
                            switch (quantity)
                            {
                                case 4:
                                    scaledIngredients[i, 1] = 0.25.ToString(); scaledIngredients[i, 2] = "cup"; break;
                                case 8:
                                    scaledIngredients[i, 1] = 0.5.ToString(); scaledIngredients[i, 2] = "cup"; break;
                                case 12:
                                    scaledIngredients[i, 1] = 0.75.ToString(); scaledIngredients[i, 2] = "cup"; break;
                                case 16:
                                    scaledIngredients[i, 1] = 1.ToString(); scaledIngredients[i, 2] = "cup"; break;
                            }
                            
                        }
                        break;

                }

            }

            scaledRecipe = Display(scaledIngredients);
            return scaledRecipe;
        }

        public string Display(string[,] _Ingredients)
        {
            string display = "-----------------------------------\nIngredients: \n-----------------------------------\n";
            
            for (int i = 0; i < _Ingredients.GetLength(0); i++)
            {

                display = display + _Ingredients[i, 1] + " " + _Ingredients[i, 2] + " of " + _Ingredients[i, 0] + "\n";

            }
            display = display + "-----------------------------------\nSteps: \n-----------------------------------\n";

            for (int i = 0; i < steps.Length; i++)
            {

                display = display + (i + 1) + ") " + steps[i] + "\n";

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
