using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAPP.Models
{
    public abstract class Card
    {
        public virtual int CardId { get; set; }

        public abstract void Bus(int trans);
        public abstract void Metrobus(int stops);
    }
}
