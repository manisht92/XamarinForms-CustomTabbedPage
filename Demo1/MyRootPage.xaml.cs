using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CarouselView.FormsPlugin.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo1
{
    [XamlCompilationAttribute(XamlCompilationOptions.Skip)]
    public partial class MyRootPage : ContentView
    {
        public List<String> products;
        public MyRootPage()
        {
            InitializeComponent();
            //Title = "CarouselView";
            var NameList = new List<ContentView>();
            NameList.Add(new Page1());
            NameList.Add(new Page2());

            myCarousel.ItemsSource = NameList;
        }

        async void Page1_Clicked(object sender, System.EventArgs e)
        {
            page1_UI.BackgroundColor = Color.Gray;
            page2_UI.BackgroundColor = Color.Transparent;
            myCarousel.Position = 0;
            var item = sender as StackLayout;
            //await Task.Delay(2000);
            await item.FadeTo(0, 1000);
            //await Task.Delay(2000);
            await item.FadeTo(1, 1000);
        }

        async void Page2_Clicked(object sender, System.EventArgs e)
        {
            page2_UI.BackgroundColor = Color.Gray;
            page1_UI.BackgroundColor = Color.Transparent;
            myCarousel.Position = 1;
            var item = sender as StackLayout;
            //await Task.Delay(2000);
            await item.FadeTo(0, 1000);
            //await Task.Delay(2000);
            await item.FadeTo(1, 1000);
        }

        void Carousel_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            var Carousel = sender as CarouselViewControl;
            if (Carousel.Position == 0)
            {
                page1_UI.BackgroundColor = Color.Gray;
                page2_UI.BackgroundColor = Color.Transparent;
            }
            else if (Carousel.Position == 1)
            {
                page2_UI.BackgroundColor = Color.Gray;
                page1_UI.BackgroundColor = Color.Transparent;
            }
        }

    }
}