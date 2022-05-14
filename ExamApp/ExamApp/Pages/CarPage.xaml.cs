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
    public partial class CarPage : ContentPage
    {
        Car car;
        public CarPage(Car newCar)
        {
            InitializeComponent();
            car = newCar;
            carDesc.Text = car.Description;
        }
    }
}