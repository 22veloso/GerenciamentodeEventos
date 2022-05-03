using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Event

    {
        public object ap;

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
        public int Duration { get; set; }
        public Type Type { get; set; }
        public Address Address { get; set; }

        public List<Presentation> Presentations { get; set; }


        public override string ToString()
        {
            string apresentations = "";

            //foreach (var item in Presentations)
            //{
            //    apresentations += item;
            //}
            if (Presentations != null)
                Presentations.ForEach(x => apresentations += x);


            return "id: " + this.Id +
                    "\nNome: " + this.Name +
                    "\nData: " + this.Date +
                    "\nCapacidade: " + this.Capacity +
                    "\nDuração: " + this.Duration +
                    "\nTipo: " + this.Type +
                    "\nEndereço: " + this.Address +
                    "\nApresentações: " + apresentations;
                   

        }
    }
}