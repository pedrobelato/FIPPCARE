using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIPPCARE.Controle
{
    public interface IObservado
    {
        void adicionarObservadores(IObservador observador);
        void notificarObservadores();
    }
}
