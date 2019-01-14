using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo1
{
    public partial class SampleDemo : ContentPage
    {
        public SampleDemo()
        {
            InitializeComponent();
        }

        void Profile_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        void Material_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MyPage());
        }

        void BottomBar_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MyBottomBar());
        }

        void TabbedWithFab_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TabbedWithFabPage());
        }

        void Elevation_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ElevationFramePage());
        }
    }
}
