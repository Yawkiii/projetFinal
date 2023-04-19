namespace AppHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();

            Console.WriteLine("Veuillez entrer les informations du client :");
            Console.Write("Nom : ");
            string nom = Console.ReadLine();
            Console.Write("Prénom : ");
            string prenom = Console.ReadLine();
            Console.Write("Courriel : ");
            string courriel = Console.ReadLine();
            Console.Write("Carte de crédit : ");
            string carteDeCredit = Console.ReadLine();
            Console.Write("Numéro de chambre : ");
            int numeroChambre = int.Parse(Console.ReadLine());

            Client client = new Client(nom, prenom, courriel, carteDeCredit, numeroChambre);
            hotel.AjouterClient(client);

            Console.WriteLine("Client ajouté avec succès !");
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
        protected List<Client> Clients { get; set; }

        public Hotel()
        {
            Clients = new List<Client>();
        }

        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }
        
        public bool VerificationChambre(int numero)
        {
            foreach (Client client in Clients)
            {
                if (client.NumeroChambre == numero)
                {
                    return false;
                }
            }
            return true;

        public int TotalClients()
        {
            return Clients.Count;

        }

    }
}