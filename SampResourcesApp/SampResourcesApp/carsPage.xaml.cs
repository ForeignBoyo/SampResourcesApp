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
	public partial class carsPage : ContentPage
	{
		public carsPage ()
		{
			InitializeComponent ();
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
            //----------
            string FileName7 = "SampResourcesApp.ID_429.png";
            ID_429.Source = ImageSource.FromResource(FileName7, assembly);

            string FileName8 = "SampResourcesApp.ID_541.png";
            ID_541.Source = ImageSource.FromResource(FileName8, assembly);

            string FileName9 = "SampResourcesApp.ID_415.png";
            ID_415.Source = ImageSource.FromResource(FileName9, assembly);

            string FileName10 = "SampResourcesApp.ID_480.png";
            ID_480.Source = ImageSource.FromResource(FileName10, assembly);

            string FileName11 = "SampResourcesApp.ID_434.png";
            ID_434.Source = ImageSource.FromResource(FileName11, assembly);

            string FileName12 = "SampResourcesApp.ID_494.png";
            ID_494.Source = ImageSource.FromResource(FileName12, assembly);

            string FileName13 = "SampResourcesApp.ID_502.png";
            ID_502.Source = ImageSource.FromResource(FileName13, assembly);

            string FileName14 = "SampResourcesApp.ID_503.png";
            ID_503.Source = ImageSource.FromResource(FileName14, assembly);

            string FileName15 = "SampResourcesApp.ID_411.png";
            ID_411.Source = ImageSource.FromResource(FileName15, assembly);

            string FileName16 = "SampResourcesApp.ID_506.png";
            ID_506.Source = ImageSource.FromResource(FileName16, assembly);

            string FileName17 = "SampResourcesApp.ID_451.png";
            ID_451.Source = ImageSource.FromResource(FileName17, assembly);

            string FileName18 = "SampResourcesApp.ID_555.png";
            ID_555.Source = ImageSource.FromResource(FileName18, assembly);

            string FileName19 = "SampResourcesApp.ID_477.png";
            ID_477.Source = ImageSource.FromResource(FileName19, assembly);

            //wagon

            string FileName20 = "SampResourcesApp.ID_400.png";
            ID_400.Source = ImageSource.FromResource(FileName20, assembly);

            string FileName21 = "SampResourcesApp.ID_404.png";
            ID_404.Source = ImageSource.FromResource(FileName21, assembly);

            string FileName22 = "SampResourcesApp.ID_442.png";
            ID_442.Source = ImageSource.FromResource(FileName22, assembly);

            string FileName23 = "SampResourcesApp.ID_458.png";
            ID_458.Source = ImageSource.FromResource(FileName23, assembly);

            string FileName24 = "SampResourcesApp.ID_479.png";
            ID_479.Source = ImageSource.FromResource(FileName24, assembly);

            string FileName25 = "SampResourcesApp.ID_489.png";
            ID_489.Source = ImageSource.FromResource(FileName25, assembly);

            string FileName26 = "SampResourcesApp.ID_579.png";
            ID_579.Source = ImageSource.FromResource(FileName26, assembly);

            //2 door and compact cars

            string FileName27 = "SampResourcesApp.ID_602.png";
            ID_602.Source = ImageSource.FromResource(FileName27, assembly);

            string FileName28 = "SampResourcesApp.ID_496.png";
            ID_496.Source = ImageSource.FromResource(FileName28, assembly);

            string FileName29 = "SampResourcesApp.ID_401.png";
            ID_401.Source = ImageSource.FromResource(FileName29, assembly);

            string FileName30 = "SampResourcesApp.ID_518.png";
            ID_518.Source = ImageSource.FromResource(FileName30, assembly);

            string FileName31 = "SampResourcesApp.ID_527.png";
            ID_527.Source = ImageSource.FromResource(FileName31, assembly);
            //----------
            string FileName32 = "SampResourcesApp.ID_589.png";
            ID_589.Source = ImageSource.FromResource(FileName32, assembly);

            string FileName33 = "SampResourcesApp.ID_419.png";
            ID_419.Source = ImageSource.FromResource(FileName33, assembly);

            string FileName34 = "SampResourcesApp.ID_587.png";
            ID_587.Source = ImageSource.FromResource(FileName34, assembly);

            string FileName35 = "SampResourcesApp.ID_533.png";
            ID_533.Source = ImageSource.FromResource(FileName35, assembly);

            string FileName36 = "SampResourcesApp.ID_526.png";
            ID_526.Source = ImageSource.FromResource(FileName36, assembly);

            string FileName37 = "SampResourcesApp.ID_474.png";
            ID_474.Source = ImageSource.FromResource(FileName37, assembly);

            string FileName38 = "SampResourcesApp.ID_545.png";
            ID_545.Source = ImageSource.FromResource(FileName38, assembly);

            string FileName39 = "SampResourcesApp.ID_517.png";
            ID_517.Source = ImageSource.FromResource(FileName39, assembly);

            string FileName40 = "SampResourcesApp.ID_410.png";
            ID_410.Source = ImageSource.FromResource(FileName40, assembly);

            string FileName41 = "SampResourcesApp.ID_600.png";
            ID_600.Source = ImageSource.FromResource(FileName41, assembly);

            string FileName42 = "SampResourcesApp.ID_436.png";
            ID_436.Source = ImageSource.FromResource(FileName42, assembly);

            string FileName43 = "SampResourcesApp.ID_439.png";
            ID_439.Source = ImageSource.FromResource(FileName43, assembly);

            string FileName44 = "SampResourcesApp.ID_549.png";
            ID_549.Source = ImageSource.FromResource(FileName44, assembly);

            string FileName45 = "SampResourcesApp.ID_491.png";
            ID_491.Source = ImageSource.FromResource(FileName45, assembly);


        }*/

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new sportCars());
        }

        private async void BtnFourDoorCars_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FourDoorCars());
        }

        private async void BtnWagon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wagons());
        }


        private async void BtnHeavy_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HeavyTrucks());
        }

        private async void BtnTwoDoor_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TwoDoorCars());
        }

        private async void BtnMuscle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MuscleCars());
        }

        private async void BtnLowrider_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lowrider());
        }

        private async void BtnLightTrucks_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LightTrucks());
        }

        private async void BtnCivilServices_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CivilServices());
        }

        private async void BtnGovernVeh_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GovernmentVeh());
        }

        private async void BtnBikes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BikesPage());
        }

        private async void BtnAirplanes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AirplanePage());
        }

        private async void BtnHeli_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HeliPage());
        }

        private async void BtnTrailers_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrailersPage());
        }

        private async void BtnTrains_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrainsPage());
        }

        private async void BtnBoats_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoatsPage());
        }

        private async void BtnRecreational_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecreationalPage());
        }

        private async void BtnRc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RcPage());
        }
    }
}