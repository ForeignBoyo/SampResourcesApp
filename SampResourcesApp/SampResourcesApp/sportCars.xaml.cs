using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampResourcesApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class sportCars : ContentPage
	{
		public sportCars ()
		{
			InitializeComponent ();
           //MainPage = new carsPage(new MainPage());
            //AddImage();
        }

        



        /*public void AddImage()
        {
            var assembly = typeof(MainPage);
            string FileName = "SampResourcesApp.ID_558.png";
            ID_558.Source = ImageSource.FromResource(FileName, assembly);

            string FileName2 = "SampResourcesApp.ID_559.png";
            ID_559.Source = ImageSource.FromResource(FileName2, assembly);

            string FileName3 = "SampResourcesApp.ID_560.png";
            ID_560.Source = ImageSource.FromResource(FileName3, assembly);

            string FileName4 = "SampResourcesApp.ID_561.png";
            ID_561.Source = ImageSource.FromResource(FileName4, assembly);

            string FileName5 = "SampResourcesApp.ID_562.png";
            ID_562.Source = ImageSource.FromResource(FileName5, assembly);

            string FileName6 = "SampResourcesApp.ID_565.png";
            ID_565.Source = ImageSource.FromResource(FileName6, assembly);
        }*/

        /*private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new carsPage());
        }

        private async void BtnMain_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }*/


    }

}