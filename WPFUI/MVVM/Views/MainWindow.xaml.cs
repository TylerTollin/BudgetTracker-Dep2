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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFUI.MVVM.Views;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HomeUI homeUI = new HomeUI();
        IncomeUI incomeUI = new IncomeUI();
        ExpensesUI expensesUI = new ExpensesUI();   

        public MainWindow()
        {
            InitializeComponent();
            homeUI.Visibility = Visibility.Visible;
            incomeUI.Visibility = Visibility.Hidden;
            expensesUI.Visibility = Visibility.Hidden;
        }

        private void radioHome_Click(object sender, RoutedEventArgs e)
        {
            homeUI.Visibility = Visibility.Visible;
            incomeUI.Visibility = Visibility.Hidden;
            expensesUI.Visibility = Visibility.Hidden;
        }

        private void radioIncome_Click(object sender, RoutedEventArgs e)
        {
            homeUI.Visibility = Visibility.Hidden;
            incomeUI.Visibility = Visibility.Visible;
            expensesUI.Visibility = Visibility.Hidden;
        }

        private void radioExpenses_Click(object sender, RoutedEventArgs e)
        {
            homeUI.Visibility = Visibility.Hidden;
            incomeUI.Visibility = Visibility.Hidden;
            expensesUI.Visibility = Visibility.Visible;
        }
    }
}
