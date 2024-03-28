using System.Text;

namespace GameMagic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            Heroe player1 = new Mage(100, new FireBall(10), "artem");
            Heroe player2 = new Mage(100, new FireBall(10), "jhon");


            Console.WriteLine();

            player2.Attack(player1);

        }
    }
}
