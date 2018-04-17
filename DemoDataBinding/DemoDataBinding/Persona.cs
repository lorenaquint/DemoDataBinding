using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DemoDataBinding
{
    public class Persona:Notificable
    {  
        private string pais;
        private Persona perSeleccion;

        public Persona PerSeleccion
        {
            get
            { return perSeleccion;
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



        public string Pais
        {
            get { return pais; }
            set
            {
                if (pais == value)
                {
                    return;
                }
                pais = value;
                OnPropertyChanged();
            }
        }
       
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged();
            }
        }
        public override string ToString()
        {
            return $"{Nombre} de {Pais}";
        }

    }
}
