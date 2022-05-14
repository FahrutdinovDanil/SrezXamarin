using ExamApp.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarsPage : ContentPage
    {
        public CarsPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            carsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Car selectedCar = (Car)e.SelectedItem;
            CarPage carPage = new CarPage(selectedCar);
            await Navigation.PushAsync(carPage);
        }

        private async void CreateCar(object sender, EventArgs e)
        {
            Car car = new Car();
            AddCarPage carPage = new AddCarPage();
            carPage.BindingContext = car;
            await Navigation.PushAsync(carPage);
        }
    }
}