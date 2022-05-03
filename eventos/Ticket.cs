using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Ticket
    {


        public int Id { get; set; }
        public Event Event { get; set; }


        //public List<Ticket> Tickets { get; set; }

        //public string getTicket()
        //{
        //    string Ticket = "";
        //    foreach (var ticket in Tickets)
        //    {
        //        Ticket += "\nId: " + ticket.Id + "\nDescrição: "+ ticket.Event;
        //    }
        //    return Ticket;
        //}

    }
}