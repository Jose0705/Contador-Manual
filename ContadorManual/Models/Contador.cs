using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorManual.Models
{
    class Contador
    {
        private int _conteo;
        public int Conteo
        {
            get => _conteo;

            set
            {

                if (_conteo != value)
                {

                    _conteo = value;

                }
            }
        }
        public Contador()

        {

            Conteo = 0;

        }
        public void Contar()
        {
            Conteo++;

        }
        public void Reiniciar()
        {
            Conteo = 0;
        }
    }
}
