using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoDataBinding
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            //this.btnEnviar.Clicked += BtnEnviar_Clicked;
            //this.lstPersonas.ItemSelected += LstPersonas_ItemSelected;
           
		}

        //private void LstPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    DisplayAlert(" SElecciono una persona","Sleccion","Ok");
        //}



        //private void BtnEnviar_Clicked(object sender, EventArgs e)
        //{
        //    var per = (Persona)Resources["persona1"];
        //    per.Nombre = "Gabriel";
        //    per.Pais = "Mexico";
        //}
    }
}
