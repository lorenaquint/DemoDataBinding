using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DemoDataBinding
{
    public class Persona:INotifyPropertyChanged
    {
        
        private string pais;

        public string Pais
        {
            get { return pais; }
            set { pais = value;
                OnPropertyChanged("Pais");
            }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged("Nombre");
            }
        }

        #region Implementación
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
