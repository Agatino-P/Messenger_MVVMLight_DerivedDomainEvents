using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messenger_MVVMLight
{
    public class DerivedEventTwo : BaseEvent
    {
        public string Testo { get; set; }
        public DerivedEventTwo(int numero, string testo) : base(numero)
        {
            Testo = Testo;
        }
        public override string ToString()
        {
            return $"DerivedTwo - Numero: {Numero} Testo: {Testo}";
        }
    }
}
