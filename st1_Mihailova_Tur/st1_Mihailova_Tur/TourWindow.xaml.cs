using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace st1_Mihailova_Tur
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class TourWindow : Window
    {
        private List<Tour> Tours = st1_Mihailova_TurEntities.getContext().Tour.ToList();
        private List<Type> Types = st1_Mihailova_TurEntities.getContext().Type.ToList();
        private List<string> sortPrice = new List<string>
        {
            "Нет",
            "По возрастанию цены",
            "По убыванию цены"
        };

        public TourWindow()
        {
            InitializeComponent();

            AllType.SelectedIndex = 0;
            Types.Insert(0, new Type
            {
                Name = "Все типы"
            });
            AllType.ItemsSource = Types;

            ListTour.ItemsSource = Tours;
            Sort.SelectedIndex = 0;
            Sort.ItemsSource = sortPrice;
            UpdateTours();
        }

      

        private void CheckActual_Click(object sender, RoutedEventArgs e)
        {
            UpdateTours();
        }

        private void UpdateTours()
        {
            IEnumerable<Tour> empFiltered = Tours;

            if (AllType.SelectedIndex > 0)
            {
                empFiltered = empFiltered.Where(a => a.Type.Contains(AllType.SelectedItem as Type)).ToList();
            }

            empFiltered = empFiltered.Where(a => a.Name.ToLower().Contains(Search.Text.ToLower())).ToList();
            
            if (CheckActual.IsChecked.Value)
            {
                empFiltered = empFiltered.Where(a => a.IsActual);
            }
            if (Sort.SelectedIndex == 1)
            {
                empFiltered = empFiltered.OrderBy(a=>a.Price);
            }
            if (Sort.SelectedIndex == 2)
            {
                empFiltered = empFiltered.OrderByDescending(a => a.Price);
            }

            decimal price = 0;
            foreach (var tour in empFiltered)
            {
                price += tour.Price * tour.TicketCount;
            }
            AllPrice.Text = $"Общая стоимость туров: {price.ToString(format:($"{0:N2}"))} РУБ";

            ListTour.ItemsSource = empFiltered;
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateTours();
        }

        private void AllType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTours();
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTours();
        }
    }
}
