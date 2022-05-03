namespace Eventos
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }



        public override string ToString()
        {

            return "id: " + Id +
                "\nNome: " + Name +
                "\nTelefone: " + Telephone;
        }


        }


    }
