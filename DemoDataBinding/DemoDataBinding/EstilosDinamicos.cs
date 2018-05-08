using System;

using Xamarin.Forms;

namespace DemoDataBinding
{
    public class EstilosDinamicos : ContentPage
    {
        public EstilosDinamicos()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

