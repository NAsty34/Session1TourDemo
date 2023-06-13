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

namespace st1_Mihailova_Tur
{
    /// <summary>
    /// Логика взаимодействия для HotelWindow.xaml
    /// </summary>
    public partial class HotelWindow : Window
    {
        List<Hotel> Hotels = st1_Mihailova_TurEntities.getContext().Hotel.ToList();
        int takeHotels = 10;
        int Pages;
        
        public HotelWindow()
        {
            InitializeComponent();
            ListHotel.ItemsSource = st1_Mihailova_TurEntities.getContext().Hotel.ToList().Take(takeHotels);
            UpdateCountPage();

        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            var totalElements = int.Parse(NumberPage.Text) * takeHotels;
            Pages = Hotels.Count / takeHotels;
            if (Hotels.Count % takeHotels < takeHotels && Hotels.Count % takeHotels != 0)
            {
                Pages += 1;
            }

            if (Hotels.Count() < takeHotels)
            {
                takeHotels = Hotels.Count - totalElements;
            }

            if (int.Parse(NumberPage.Text) < Pages)
            {
                ListHotel.ItemsSource = Hotels.Skip(totalElements).Take(takeHotels);
                NumberPage.Text = (int.Parse(NumberPage.Text) + 1).ToString();
            }
        }

        private void FirstPage_Click(object sender, RoutedEventArgs e)
        {
            NumberPage.Text = "1";
            ListHotel.ItemsSource = Hotels.Take(takeHotels);
        }

        private void LastPage_Click(object sender, RoutedEventArgs e)
        {
            Pages = Hotels.Count / takeHotels;
            int skipElement = Hotels.Count / takeHotels;
            if (Hotels.Count % takeHotels < takeHotels && Hotels.Count % takeHotels != 0)
            {
                Pages += 1;
            }
            if (Hotels.Count % takeHotels == 0)
            {
                skipElement--;
            }
            ListHotel.ItemsSource = Hotels.Skip(skipElement * takeHotels).Take(takeHotels);
            NumberPage.Text = $"{Pages}";
        }

        private void Last_Click(object sender, RoutedEventArgs e)
        {
            if (NumberPage.Text != "1")
            {
                NumberPage.Text = (int.Parse(NumberPage.Text) - 1).ToString();
                ListHotel.ItemsSource = Hotels.Skip((int.Parse(NumberPage.Text) - 1) * takeHotels).Take(takeHotels);
            }
        }

        private void ElementsPage_Selection(object sender, RoutedEventArgs e)
        {
            if (userElementsPage.Text == null || userElementsPage.Text == "0" || userElementsPage.Text == "")
            {
                MessageBox.Show("Количество элементов на странице не должно быть меньше или равнятся нулю", "Error pagination");
                userElementsPage.Text = "10";
            }
            else
            {
                takeHotels = int.Parse(userElementsPage.Text);
            }
            if (NumberPage != null)
            {
                NumberPage.Text = "1";
            }
            if (CountPages != null)
            {
                UpdateCountPage();
            }
            ListHotel.ItemsSource = Hotels.Take(takeHotels);
        }
        private void UpdateCountPage()
        {
            var staticPage = Hotels.Count() / int.Parse(userElementsPage.Text);

            if (Hotels.Count % int.Parse(userElementsPage.Text) > 0)
            {
                staticPage += 1;
            };
            
            Pages = staticPage;
            CountRow.Text = Hotels.Count.ToString();
            CountPages.Text = staticPage.ToString();
        }

        public void CreateHotel_Click(object sender, RoutedEventArgs e)
        {
            new UpdateHotel("create", null).Show();
            Close();
        }

        public void RemoveHotel_Click(object sender, RoutedEventArgs e)
        {
            var actualHotel = (ListHotel.SelectedItem as Hotel).Tour.Select(a => a.IsActual);
            if (!actualHotel.Contains(true))
            {
                if (MessageBox.Show($"Вы хотите удалить {(ListHotel.SelectedItem as Hotel).Name}?", "Delete hotel",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    st1_Mihailova_TurEntities.getContext().Hotel.Remove(ListHotel.SelectedItem as Hotel);
                    st1_Mihailova_TurEntities.getContext().SaveChanges();
                }
                Hotels = st1_Mihailova_TurEntities.getContext().Hotel.ToList();
                FirstPage_Click(sender, e);
                UpdateCountPage();
            }
            else
            {
                MessageBox.Show("Отель не может быть удален, так как находит в числе подходящих отелей для актуальных туров", "Error delete hotel");
            } 
            
        }

        public void UpdateHotel_Click(object sender, RoutedEventArgs e)
        {
            new UpdateHotel("update", ListHotel.SelectedItem as Hotel).Show();
            Close();
        }

       
    }
}
