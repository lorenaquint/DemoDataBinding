

namespace DemoDataBinding
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    public  class Datos:Notificable
    {
        private ObservableCollection<Persona> personas;

        public ObservableCollection<Persona> Personas
        {
            get
            {
                return personas;
            }
            set
            {
                if (personas == value)
                {
                    return;
                }
                personas = value;
                OnPropertyChanged();
            }
        }

        public Datos()
        {
            Personas = new ObservableCollection<Persona>();
            for (int i = 0; i < 5; i++)
            {
                Personas.Add(new Persona()
                {
                    Nombre = $"Persona {i}",
                    Pais = $"País {i}"

                });
            }
        }

      

    }
}
