using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diernasiel
{
    class Reservor
    {
        public string Name;
        public DateTime ReservedAt;

        public Reservor(string name,DateTime reservedAt)
        {
            this.Name = name;
            this.ReservedAt = reservedAt;
        }
    }
}
