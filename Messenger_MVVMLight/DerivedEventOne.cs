using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messenger_MVVMLight
{
    public class DerivedEventOne : BaseEvent
    {
        public string Testo { get; set; }
        public DerivedEventOne(int numero, string testo) : base(numero)
        {
            Testo = Testo;
        }
        public override string ToString()
        {
            return $"DerivedOne - Numero: {Numero} Testo: {Testo}";
        }
    }
}
