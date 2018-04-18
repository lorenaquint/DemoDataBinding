

namespace DemoDataBinding
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using Xamarin.Forms;

    public class ColeccionesListas
    {
        private ObservableCollection<Page> listPaginas;

        public ObservableCollection<Page> ListPaginas
        {
            get { return listPaginas; }
            set { listPaginas = value; }
        }

        public ColeccionesListas()
        {
            ObservableCollection<Page> ListPaginas = new ObservableCollection<Page>()
            {
                new DataBinding1(),
                new MainPage()
            };
        }

    }
}
