﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PROG6221_GUI.Model;
using PROG6221_GUI.View;

namespace PROG6221_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RecipeManager recipeManager;
        public MainWindow()
        {
            Console.WriteLine("\nInitializing Recipe Manager\n");
            recipeManager = new RecipeManager();
            InitializeComponent();
        }

        private void btnViewRecipe_Click(object sender, RoutedEventArgs e)
        {
            RecipeView recipeView = new RecipeView();
            recipeView.Show();
            this.Close();

        }

        private void btnCreateRecipe_Click(object sender, RoutedEventArgs e)
        {
            CreateRecipeView createRecipeView = new CreateRecipeView();
            createRecipeView.Show();
            this.Close();
        }

        private void btnEditScale_Click(object sender, RoutedEventArgs e)
        {
            EditScaleView editScaleView = new EditScaleView();
            editScaleView.Show();
            this.Close();
        }

        private void btnDeleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            DeleteRecipeView deleteRecipeView = new DeleteRecipeView();
            deleteRecipeView.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            ExitView exitView = new ExitView();
            exitView.Show();
            Application.Current.Shutdown();
            this.Close();
        }
    }
}
