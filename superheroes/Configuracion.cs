using System.ComponentModel;

namespace superheroes
{
    class Configuracion : INotifyPropertyChanged
    {
        public string AjusteImagen { get; set; }
        public string Fondo { get; set; }

        public Configuracion()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}


