using System.Security.Cryptography;

namespace ServerManagement.Models
{
    public class Server
    {
        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0 ? false : true;
        }
        //represents whether the server is online or offline
        public int ServerId { get; set; }
        public  bool IsOnline { get; set; }
        public string? Name { get; set; }
        //city where the server is located
        public string? City { get; set; }
    }
}
