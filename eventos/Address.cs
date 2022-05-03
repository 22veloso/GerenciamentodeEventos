using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Address
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string District { get; set; }
        public string PublicPlace { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
    

    public override string ToString()
    {

        return "id: " +  Id +
             "\nCEP: " + Cep +
             "\nBairro: " + District+
             "\n Lagradouro: " + PublicPlace +
             "\nN°: " + Number +
             "\nComplemento: " + Complement;
        }
    }
}
