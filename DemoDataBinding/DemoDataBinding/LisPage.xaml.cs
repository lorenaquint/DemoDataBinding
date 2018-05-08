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
	public partial class LisPage : ContentPage
	{
        public List<Page> ListPages { get; set; }


        public LisPage ()
		{
			InitializeComponent ();

            ListPages = new List<Page>()
            {
				new ED(),
                new DataBinding1(),
                new MainPage()

            };

            //listPages.ItemsSource = ListPages;
            this.BindingContext = this;
            listPages.ItemSelected += ListPages_ItemSelected;


        }
        void ListPages_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                this.Navigation.PushAsync((Page)e.SelectedItem);
            }
            listPages.SelectedItem = null;
        }

    }
}