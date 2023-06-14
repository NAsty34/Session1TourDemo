using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для UpdateHotel.xaml
    /// </summary>
    public partial class UpdateHotel : Window
    {
        List<Country> Countries = st1_Mihailova_TurEntities.getContext().Country.ToList();
        private static readonly Regex _regex = new Regex("[^0-5]");
        Hotel selectedHotel;
        private IQueryable<Tour> getTour = st1_Mihailova_TurEntities.getContext().Tour;
        public UpdateHotel(string nameEvent, Hotel hotel)
        {
            InitializeComponent();
            if (nameEvent == "update")
            {
                HeaderWindow.Text = "Редактирование отеля";
                NameHotel.Text = hotel.Name;
                CountStars.Text = hotel.CountOfStars.ToString();
                DescriptionHotel.Text = hotel.DescriptionText;
                ListCountry.SelectedItem = hotel.Country;
                selectedHotel = hotel;
            }
            else
            {
               HeaderWindow.Text = "Добавление отеля";
               ListCountry.SelectedIndex = 0;
            }
            Countries.Insert(0, new Country
            {
                Name = "Выберите страну"
            });
            
            ListCountry.ItemsSource = Countries;
        }


        private void CountStars_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (_regex.IsMatch(CountStars.Text) && CountStars.Text != "")
            {
                MessageBox.Show("Количество звезд должно быть больше 0 и меньше 5", "Validation stars");
                CountStars.Text = "";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (NameHotel.Text == "" || CountStars.Text == "" || DescriptionHotel.Text == "" || ListCountry.SelectedIndex == 0)
            {
                MessageBox.Show("Все поля должныть быть заполнены", "Error save hotel");
            }
            else
            {
                
                if (HeaderWindow.Text == "Добавление отеля")
                {
                    List<Tour> HotelTours = new List<Tour>();
                    if (getTour.Where(a => a.Country == (ListCountry.SelectedItem as Country)) == null)
                    {
                        HotelTours = null;
                    }
                    else
                    {
                        //IQueryable<int> idTour = getTour.Where(a => a.Country == (ListCountry.SelectedItem as Country))
                        //                                .Select(a => a.Id);
                        //foreach (var tours in idTour)
                        //{
                        //    HotelTours.Add(st1_Mihailova_TurEntities.getContext().Tour.FirstOrDefault(a => a.Id == tours));
                        //}
                    }
                    st1_Mihailova_TurEntities.getContext().Hotel.Add(new Hotel
                    {
                        Name = NameHotel.Text,
                        CountOfStars = int.Parse(CountStars.Text),
                        Description = DescriptionHotel.Text,
                        CountryCode = (ListCountry.SelectedItem as Country).Code,
                        Tour = HotelTours
                    });
                    st1_Mihailova_TurEntities.getContext().SaveChanges();
                    MessageBox.Show("Отель добавлен", "Save hotel");
                }

                if (HeaderWindow.Text == "Редактирование отеля")
                {
                    var updateHotel = st1_Mihailova_TurEntities.getContext().Hotel.Find(selectedHotel.Id);
                    updateHotel.Name = NameHotel.Text;
                    updateHotel.CountOfStars = int.Parse(CountStars.Text);
                    updateHotel.Description = DescriptionHotel.Text;
                    updateHotel.CountryCode = (ListCountry.SelectedItem as Country).Code;
                    st1_Mihailova_TurEntities.getContext().SaveChanges();
                    MessageBox.Show("Данные об отеле изменены", "Update hotel");
                }
                new HotelWindow().Show();
                Close();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            new HotelWindow().Show();
            Close();
        }
    }
}
