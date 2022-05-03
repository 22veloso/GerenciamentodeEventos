using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Type
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {

            return "id: " + Id +
                 "\nDescrição: " + Description;
        }
    }
}
