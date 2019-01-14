using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo1
{
    public partial class Page1 : ContentView
    {
        public Page1()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}
