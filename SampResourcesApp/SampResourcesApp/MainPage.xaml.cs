using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampResourcesApp
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            AddImage();
        }

        public void AddImage()
        {
            var assembly = typeof(MainPage);
            string FileName = "SampResourcesApp.logoGta.png";
            logoGta.Source = ImageSource.FromResource(FileName, assembly);
        }


        private async void BtnWeapon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WeaponsPage());
        }


        private async void BtnSkin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SkinPage());
        }

        private async void BtnCars_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new carsPage());
        }
    }
}
