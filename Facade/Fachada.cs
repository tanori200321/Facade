using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Fachada
    {
        private Subsistema1 _subsistema1;
        private Subsistema2 _subsistema2;
        private Subsistema3 _subsistema3;

        public Fachada()
        {
            _subsistema1 = new Subsistema1();
            _subsistema2 = new Subsistema2();
            _subsistema3 = new Subsistema3();
        }

        public void OperacionCompleta()
        {
            Console.WriteLine("Fachada inicializa los subsistemas:");
            _subsistema1.Operacion1();
            _subsistema2.Operacion2();
            _subsistema3.Operacion3();
        }
    }
}
