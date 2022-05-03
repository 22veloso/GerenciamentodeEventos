using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Presentation
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int duration { get; set; }
        public DateTime Hour { get; set; }
        public List<Presentation> Presentations { get; set; }



        public string getPresentation()
        {
            string Presentation = "";
            foreach (var presentation in Presentations)
            {
                Presentation += "\nId: " + presentation.Id + "\nDescrição: " + presentation.Description + "\nhora: " + presentation.Hour;
            }
            return Presentation;
        }



        public override string ToString()
        {

            return "id: " + this.Id +
                    "\nDescrição: " + this.Description +
                    "\nDuração: " + this.duration +
                    "\nData: " + this.Hour;

        }
    }

}