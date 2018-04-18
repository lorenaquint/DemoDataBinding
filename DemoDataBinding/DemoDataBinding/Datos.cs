

namespace DemoDataBinding
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    public  class Datos:Notificable
    {
        private ObservableCollection<Persona> personas;
        private Persona perSeleccion;
        

        public Persona PerSeleccion
        {
            get
            {
                return perSeleccion;
            }
            set
            {
                if (perSeleccion == value)
                {
                    return;
                }

                perSeleccion = value;
                OnPropertyChanged();
            }
        }

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
            var aleatorio = new Random();
            Personas = new ObservableCollection<Persona>();
            for (int i = 0; i < 5; i++)
            {
                
                Personas.Add(new Persona()
                {
                    Nombre = $"Persona {i}",
                    Pais = $"País {i}",
                    FechaNacimiento = new DateTime(1980 + i, i + 1, 1),
                    Saldo = (decimal)(aleatorio.Next(100,5000)*3.1416)
                    

                });
            }
        }

      

    }
}
