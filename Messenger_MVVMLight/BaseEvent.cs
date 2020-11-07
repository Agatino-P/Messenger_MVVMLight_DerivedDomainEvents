using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messenger_MVVMLight
{
    public class BaseEvent
    {
        public int Numero { get; set; }
        public BaseEvent(int numero)
        {
            Numero = numero;
        }

        public override string ToString()
        {
            return $"Base - Numero: {Numero}";
        }
    }
}
