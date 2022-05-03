using Eventos;
using System;


namespace ProjEventos
{
    public class Program
    {
        public static List<Event> events = new List<Event>();
        public static List<Client> clients = new List<Client>();
        public static List<Ticket> tickets = new List<Ticket>();

        static void Main(string[] args)
        {

            int opcao = 0;
            do
            {
                Console.WriteLine("Menu");

                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 -cadastrar evento: ");
                Console.WriteLine("3 - listar evento:");
                Console.WriteLine("4 -Cadatrar Apresentação");
                Console.WriteLine("5 -gerar ingressos");
                Console.WriteLine("9 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastroCliente();
                        break;
                    case 2:
                        AddEvent();
                        break;
                    case 3:
                        ListarEvents();
                        break;
                    case 4:
                        AddPresentation();
                        break;
                    case 5:
                        AddTickets();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }

            } while (opcao != 9);

        }




        private static void CadastroCliente()
        {
            Console.WriteLine("informe o Id:");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o nome:");
            String Name = (Console.ReadLine());
            Console.WriteLine("informe o telefone:");
            String Telephone = (Console.ReadLine());


            Client c1 = new Client()
            {

                Id = Id,
                Name = Name,
                Telephone = Telephone
            };
            clients.Add(c1);
        }

        private static void AddEvent()

        {
            Event ev = new Event();

            Console.Write("Id: ");
            ev.Id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            ev.Name = Console.ReadLine();

            Console.Write("Data: ");
            ev.Date = DateTime.Parse(Console.ReadLine());

            Console.Write("capacidade: ");
            ev.Capacity = int.Parse(Console.ReadLine());

            Console.Write("Duração: ");
            ev.Duration = int.Parse(Console.ReadLine());



            ev.Address = new Eventos.Address();

            Console.Write("\n***INFORME O ENDEREÇO DO EVENTO:***\n");
            Console.WriteLine("informe o Id:");
            ev.Address.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o CEP:");
            ev.Address.Cep = (Console.ReadLine());

            Console.WriteLine("informe o Bairro:");
            ev.Address.District = (Console.ReadLine());

            Console.WriteLine("informe o Lagradouro:");
            ev.Address.PublicPlace = (Console.ReadLine());

            Console.WriteLine("informe o Numero:");
            ev.Address.Number = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o complemento:");
            ev.Address.Complement = (Console.ReadLine());


            ev.Type = new Eventos.Type();
            Console.Write("\n***INFORME O TIPO DO EVENTO:***\n");
            Console.Write("Id Tipo: ");
            ev.Type.Id = int.Parse(Console.ReadLine());

            Console.Write("Descrição Tipo: ");
            ev.Type.Description = Console.ReadLine();

            events.Add(ev);




        }

        private static void ListarEvents()
        {
            events.ToList().ForEach(Console.WriteLine);

        }


        private static void AddPresentation()
        {
            Console.Write("Quantidade de Apresentações: ");
            int numberOfPresentation = int.Parse(Console.ReadLine());

            List<Presentation> presentations = new List<Presentation>();

            for (int i = 0; i < numberOfPresentation; i++)
            {
                Presentation ap = new Presentation();

                Console.Write("Id Apresentação: ");
                ap.Id = int.Parse(Console.ReadLine());
                Console.Write("Descrição: ");
                ap.Description = Console.ReadLine();
                Console.Write("Horas: ");
                ap.Hour = DateTime.Parse(Console.ReadLine());
                presentations.Add(ap);

            }
            Presentation presentation = new Presentation()
            {
                Presentations = presentations,

            };
            Console.WriteLine(presentation.getPresentation());
        }


        private static void AddTickets()
        {

            Event eventReceive = null;
            do
            {
                Console.Write("Id Evento para gerar o lote: ");
                int idEvent = int.Parse(Console.ReadLine());

                eventReceive = events.Find(x => x.Id == idEvent);

                if (eventReceive == null)
                    Console.WriteLine("Evento não encontrado!");

            } while (eventReceive != null);


            Console.Write("Qtd de Ingressos");
            int qtdTickets = int.Parse(Console.ReadLine());

            int qtdTicket = tickets.Count();

            for (int i = qtdTicket + 1; i <= qtdTickets; i++)
            {
                tickets.Add(new Ticket() {
                    Id = i, 
                    Event = eventReceive 
                });
            }

            PrintTickets();

        }

        private static void PrintTickets()
        {
            tickets.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }


}










