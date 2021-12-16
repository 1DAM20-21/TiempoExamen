using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiempoExamen
{
    class PrediccionDia:ObservableObject
    {
        private String dia;

        public String Dia
        {
            get { return dia; }
            set { SetProperty(ref dia, value); }
        }

        private String prediccion;

        public String Prediccion
        {
            get { return prediccion; }
            set { SetProperty(ref prediccion, value);}
        }

        private int minimaFarenheit;

        public int MinimaFarenheit
        {
            get { return minimaFarenheit; }
            set { SetProperty(ref minimaFarenheit, value); }
        }
          private int maximaFarenheit;

        public int MaximaFarenheit
        {
            get { return maximaFarenheit; }
            set { SetProperty(ref maximaFarenheit, value); }
        }

        

        public PrediccionDia()
        {
          
        }

        public PrediccionDia(string dia, string prediccion, int minimaFarenheit, int maximaFarenheit)
        {
            Dia = dia;
            Prediccion = prediccion;
            MinimaFarenheit = minimaFarenheit;
            MaximaFarenheit = maximaFarenheit;
        }

         
       


        public ObservableCollection<PrediccionDia> GetSamples()
        {
            ObservableCollection<PrediccionDia> listaPrediccionDias = new ObservableCollection<PrediccionDia>();
            listaPrediccionDias.Add(new PrediccionDia("Lunes","sol", 44, 60));
            listaPrediccionDias.Add(new PrediccionDia("Martes", "nubes", 55, 70));
            listaPrediccionDias.Add(new PrediccionDia("Miercoles", "sol", 35, 55));
            listaPrediccionDias.Add(new PrediccionDia("Jueves", "nubes", 48,65));
            listaPrediccionDias.Add(new PrediccionDia("Viernes", "lluvia", 37, 50));
            listaPrediccionDias.Add(new PrediccionDia("Sabado", "nubes", 30, 50));
            listaPrediccionDias.Add(new PrediccionDia("Domingo", "nieve", 28, 40));

            return listaPrediccionDias;

        }
    }
}
