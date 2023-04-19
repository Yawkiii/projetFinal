namespace AppHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Courriel { get; set; }
        public string CarteDeCredit { get; set; }
        public int NumeroChambre { get; set; }

        public Client(string nom, string prenom, string courriel, string carteDeCredit, int numeroChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteDeCredit = carteDeCredit;
            NumeroChambre = numeroChambre;
        }
    }
    public class Hotel
    {
        private List<Client> Clients { get; set; }

        public Hotel()
        {
            Clients = new List<Client>();
        }

        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }

    }