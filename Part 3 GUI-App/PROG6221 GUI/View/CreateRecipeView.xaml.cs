﻿using PROG6221_GUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PROG6221_GUI.Model;

namespace PROG6221_GUI.View
{
    /// <summary>
    /// Interaction logic for CreateRecipeView.xaml
    /// </summary>
    public partial class CreateRecipeView : Window
    {
        RecipeManager recipeManager;

        Recipe newRecipe = new Recipe();

        public CreateRecipeView(RecipeManager _recipeManager)
        {
            this.recipeManager = _recipeManager;
            InitializeComponent();

            string[] ingredientOptions = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };
            string[] stepOptions = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };

            cmbNumberOfIngredients.ItemsSource = ingredientOptions;
            cmbNumberOfSteps.ItemsSource = stepOptions;

            cmbFoodGroup.ItemsSource = Enum.GetValues(typeof(FoodGroup)).Cast<FoodGroup>().Skip(1).ToArray();
            cmbFoodGroup.SelectedIndex = 0;

            cmbUnitOM.ItemsSource = Enum.GetValues(typeof(UnitOM));
            cmbUnitOM.SelectedIndex = 0;

            newRecipe = new Recipe();
        }

        private void btnViewRecipe_Click(object sender, RoutedEventArgs e)
        {
            RecipeView recipeView = new RecipeView(recipeManager);
            recipeView.Show();
            this.Close();
        }

        private void btnCreateRecipe_Click(object sender, RoutedEventArgs e)
        {
            CreateRecipeView createRecipeView = new CreateRecipeView(recipeManager);
            createRecipeView.Show();
            this.Close();
        }

        private void btnEditScale_Click(object sender, RoutedEventArgs e)
        {
            EditScaleView editScaleView = new EditScaleView(recipeManager);
            editScaleView.Show();
            this.Close();
        }

        private void btnDeleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            DeleteRecipeView deleteRecipeView = new DeleteRecipeView(recipeManager);
            deleteRecipeView.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            this.Close();
        }

        private void btnSearchRecipe_Click(object sender, RoutedEventArgs e)
        {
            SearchRecipeView searchRecipeView = new SearchRecipeView(recipeManager);
            searchRecipeView.Show();
            this.Close();
        }

        private void btnGoIngredientsPrompt_Click(object sender, RoutedEventArgs e)
        {
            newRecipe.RecipeName = txtRecipeNameField.Text;
            
            txtRecipeName.Text = newRecipe.RecipeName;

            panelRecipeDetails.Visibility = Visibility.Hidden;
            panelIngredientDetails.Visibility = Visibility.Visible;
            txtRecipeName.Visibility = Visibility.Visible;
            txtIngredients.Visibility = Visibility.Visible;
        }

        private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            Ingredient newIngredient = new Ingredient();
            newIngredient.FoodGroup = (FoodGroup)cmbFoodGroup.SelectedValue;
            newIngredient.Name = txtIngredientName.Text;
            newIngredient.Quantity = double.Parse(txtQuantity.Text);
            newIngredient.UnitOfMeasurement = (UnitOM)cmbUnitOM.SelectedValue;
            newIngredient.Calories = double.Parse(txtCalories.Text);

            newRecipe.Ingredients.Add(newIngredient);
            lstIngredients.ItemsSource = recipeManager.IngredientCheckBoxFormat(newRecipe);
            ClearUIFields();

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            PopUpBox popUpBox = new PopUpBox("Cancelled!");
            popUpBox.ShowDialog();

            RecipeView recipeView = new RecipeView(recipeManager);
            recipeView.Show();
            this.Close();

        }

        private void btnGoStepsPrompt_Click(object sender, RoutedEventArgs e)
        {
            txtSteps.Visibility = Visibility.Visible;
            panelIngredientDetails.Visibility = Visibility.Hidden;
            panelStepDetails.Visibility = Visibility.Visible;
        }

        private void btnAddStep_Click(object sender, RoutedEventArgs e)
        {
            Step newStep = new Step();
            newStep.Description = txtStepDescription.Text;
            newRecipe.Steps.Add(newStep);
            lstSteps.ItemsSource = null;
            lstSteps.ItemsSource = newRecipe.Steps;
            txtStepDescription.Clear();

        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            recipeManager.AddNewRecipe(newRecipe);

            PopUpBox popUpBox = new PopUpBox("Successful!");
            popUpBox.ShowDialog();

            RecipeView recipeView = new RecipeView(recipeManager);
            recipeView.cmbSelectRecipe.SelectedItem = newRecipe;
            recipeView.Show();
            this.Close();
        }

        private void ClearUIFields()
        {
            txtIngredientName.Clear();
            txtQuantity.Clear();
            cmbFoodGroup.SelectedIndex = 0;
            cmbUnitOM.SelectedIndex = 0;
            txtCalories.Clear();
            
        }


    }
}
