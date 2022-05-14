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
    public partial class EditPage : ContentPage
    {
        Car car;
        public EditPage(Car newCar)
        {
            InitializeComponent();
            car = newCar;

            txt_AddName.Text = car.Name;
            txt_AddDescription.Text = car.Description;
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private async void ButtonSave_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите изменить \n{car.Name}?", "Да", "Нет");

            if (result == true)
            {
                try
                {
                    var proj = (Car)BindingContext;
                    if (!String.IsNullOrEmpty(proj.Name))
                    {
                        App.Database.SaveItem(proj);
                    }
                    await this.Navigation.PopAsync();
                }
                catch (Exception)
                {
                    _ = DisplayAlert("Подтвердить действие", "Укажите имя", "Ок");
                }
            }
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите удалить \n{car.Name}?", "Да", "Нет");

            if (result == true)
            {
                App.database.DeleteItem(car.Id);
                CarsPage projectsPage = new CarsPage();
                await Navigation.PushAsync(projectsPage);
            }
        }
    }
}