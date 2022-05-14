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
    public partial class AddCarPage : ContentPage
    {
        public AddCarPage()
        {
            InitializeComponent();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private void ButtonSave_Clicked(object sender, EventArgs e)
        {
            var car = (Car)BindingContext;
            if (!String.IsNullOrEmpty(car.Name))
            {
                App.Database.SaveItem(car);
            }
            this.Navigation.PopAsync();
        }
    }
}