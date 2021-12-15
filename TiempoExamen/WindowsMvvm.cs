using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiempoExamen
{
    class WindowsMvvm : ObservableObject
    {
        private ObservableCollection<PrediccionDia> listaPrediccionDia;

        public ObservableCollection<PrediccionDia> ListaPrediccionDia
        {
            get { return listaPrediccionDia; }
            set { SetProperty(ref listaPrediccionDia, value); }
        }

        private PrediccionDia diaSeleccionado = new PrediccionDia();
        public PrediccionDia DiaSeleccionado
        {
            get { return diaSeleccionado; }
            set { SetProperty(ref diaSeleccionado, value);}
        }

        private int minimagrados;
            public int MinimaGrados
        {
            get { return minimagrados; }
            set { SetProperty(ref minimagrados, value); }
        }

        private int maximagrados;
        public int MaximaGrados
        {
            get { return maximagrados; }
            set { SetProperty(ref maximagrados, value); }
        }

        

        public WindowsMvvm()
        {
            ListaPrediccionDia = diaSeleccionado.GetSamples();
            diaSeleccionado = ListaPrediccionDia[0];
          
        }


    
}
}
