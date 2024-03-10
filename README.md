# PROG6221-POE
 Programming Project for Varsity College, 2nd Year - Dean James Greeff

These are my notes of how I am going to go about the project, roughly. These are subject to change.
2024/03/06

Notes:
- Make use of GitHub (Make regular commits).
- Data must only be stored in memory while software is running.
- When ready to submit, create a "tag" called "Part1" in GitHub repository.

Steps:
- Enter the number of ingredients.
- Enter ingredient name, quantity and then unit of measurement.
- Enter the number of steps.
- For each step, describe what must be done.
- Display whole recipe in neat format.

Methods:

scale (int ratio)
- Scale the ingredient quantities as requested.
- Search the string, for keywords such as: tablespoon, teaspoon, cup, etc... Then scale it according.
- Check for unit of measurement after quantities are scaled:
- If teaspoon quantity % 3 == 0 then convert to tablespoons.
- Then if tablespoon quantity % 4 == 0 then convert to cups.

clearData()
- Clears all data to enter new recipe.

reset()
- Resets the quantities to original values.
- Maybe returns the array stored as private variable?

displayRecipe()
- Display the whole recipe in a clean format.

Class Recipe {

Private values:
- Number of ingredients (Array [][]?)
- Number of steps (Array []?)

- Ingredients[][] = Ingredients [name][{quantity},{measurement}]
- Steps[]

}
