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

namespace PROG6221_GUI.View
{
    /// <summary>
    /// Interaction logic for DeleteRecipeView.xaml
    /// </summary>
    public partial class DeleteRecipeView : Window
    {
        RecipeManager recipeManager;
        public DeleteRecipeView(RecipeManager _recipeManager)
        {
            this.recipeManager = _recipeManager;
            InitializeComponent();
            cmbSelectRecipe.ItemsSource = recipeManager.GetRecipeList();
            if (recipeManager.RecipeList.Count == 0)
            {
                btnDeleteSelectedRecipe.IsHitTestVisible = false;
            }
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

        private void btnDeleteSelectedRecipe_Click(object sender, RoutedEventArgs e)
        {
            int index = cmbSelectRecipe.SelectedIndex;

            OptionPopUpBox optionPopUpBox = new OptionPopUpBox("delete this recipe?");

            var result = optionPopUpBox.ShowDialog();

            if (result.HasValue && result.Value)
            {
                recipeManager.DeleteRecipe(index);
                PopUpBox popUpBox = new PopUpBox("Recipe deleted!");
                popUpBox.ShowDialog();
            }
            else
            {
                PopUpBox popUpBox = new PopUpBox("Cancelled!");
                popUpBox.ShowDialog();
            }

            DeleteRecipeView deleteRecipeView = new DeleteRecipeView(recipeManager);
            deleteRecipeView.Show();
            this.Close();
        }

        private void cmbRecipe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Recipe selectedRecipe = (Recipe)cmbSelectRecipe.SelectedItem;
            if (selectedRecipe != null)
            {
                txtRecipeName.Text = selectedRecipe.RecipeName;
                lstIngredients.ItemsSource = recipeManager.IngredientCheckBoxFormat(selectedRecipe);
                lstSteps.ItemsSource = selectedRecipe.Steps;
                lblTotalCalories.Content = "Total Calories: " + recipeManager.CalculateTotalCalories(selectedRecipe).ToString();
            }
        }
    }
}
