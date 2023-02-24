using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class VariabelenOpdracht
    {
        string programTitle = "reken Opdracht";
        int programWindowPosx = 100;
        int programWindowPosy = 100;
        
        static void Main(string[] args)
        {
            int xPos = 100;
            float yPos;

            yPos = .5f;

            double money;
            string playerName;
            bool isSended;

            playerName = "clement";
            isSended = false;
            money = 500000;

            Console.WriteLine("player name is: " + playerName + System.Environment.NewLine + "bedrag is:" + money + System.Environment.NewLine + "is geld verstuurd : " + isSended);
        }
    }
}