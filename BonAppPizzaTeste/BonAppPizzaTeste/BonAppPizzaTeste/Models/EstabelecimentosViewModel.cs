using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class EstabelecimentosViewModel : INotifyPropertyChanged
    {
        public string nomeEstabel, enderecoEstabel, bairroEstabel,
            cidadeEstabel, estadoEstabel, cidadeEstado, enderecoCompleto;

        public event PropertyChangedEventHandler PropertyChanged;


        public string NomeEstabel
        {
            set
            {
                if (nomeEstabel != value)
                {
                    nomeEstabel = value;
                    OnPropertyChanged("NomeEstabel");
                }
            }
            get
            {
                return nomeEstabel;
            }
        }

        public string EnderecoEstabel
        {
            set
            {
                if (enderecoEstabel != value)
                {
                    enderecoEstabel = value;
                    OnPropertyChanged("EnderecoEstabel");
                }
            }
            get
            {
                return enderecoEstabel;
            }
        }

        public string BairroEstabel
        {
            set
            {
                if (bairroEstabel != value)
                {
                    bairroEstabel = value;
                    OnPropertyChanged("BairroEstabel");
                }
            }
            get
            {
                return bairroEstabel;
            }
        }

        public string CidadeEstabel
        {
            set
            {
                if (cidadeEstabel != value)
                {
                    cidadeEstabel = value;
                    OnPropertyChanged("CidadeEstabel");
                }
            }
            get
            {
                return cidadeEstabel;
            }
        }

        public string EstadoEstabel
        {
            set
            {
                if (estadoEstabel != value)
                {
                    estadoEstabel = value;
                    OnPropertyChanged("EstadoEstabel");
                }
            }
            get
            {
                return estadoEstabel;
            }
        }

        protected virtual void OnPropertyChanged (string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string ConcatCidadeEstado (string c, string e)
        {
            return c + ", " + e;
        }

        public string EnderecoCompleto (string e, string b, string c, string est)
        {
            return e + " - " + b + ", " + c + " - " + est;
        }

    }
}
