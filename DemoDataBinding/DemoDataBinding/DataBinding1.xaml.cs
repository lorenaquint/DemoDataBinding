using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoDataBinding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataBinding1 : ContentPage
	{
		public DataBinding1 ()
		{
			InitializeComponent ();
            this.btnEnviar.Clicked += BtnEnviar_Clicked;



        }

        private void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            var person1 = (Persona)Resources["persona1"];
            person1.Nombre = "Gabrriel";
            person1.Pais = "Mexico";
        }
    }
}
