using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DemoDataBinding
{
    public class Persona:Notificable
    {  
        private string pais;
        private DateTime dateTime;
        private decimal  saldo;

        public decimal  Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (saldo == value)
                {
                    return;
                }
                saldo = value;
                OnPropertyChanged();
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return dateTime;
            }
            set
            {
                if (FechaNacimiento == value)
                {
                    return;
                }
                dateTime = value;
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
            return $"{Nombre} | {Pais} | {FechaNacimiento} | {Saldo}";
        }

    }
}
