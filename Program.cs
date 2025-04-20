namespace Part1BossBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CityHealth = 15;
            int ManticoreHealth = 10;
            int Round = 1;
            int damage = 1;
            Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
            int place = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Player 2, it is your turn.\n");

            while (CityHealth > 0 && ManticoreHealth > 0)
            {
                if (Round % 3 == 0 && Round % 5 == 0) damage = 5;
                else if (Round % 3 == 0 || Round % 5 == 0) damage = 3;
                else damage = 1;

                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine($"STATUS: Round: {Round} City: {CityHealth}/15 MantiCore: {ManticoreHealth}/10");
                Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
                Console.Write("Enter desired cannon range: ");
                int range = Convert.ToInt32(Console.ReadLine());
                
                CityHealth--;
                if (range > place)
                    Console.WriteLine("That round OVERSHOT the target.");
                else if (range < place)
                    Console.WriteLine("That round FELL SHORT of the target.");
                else
                {
                    ManticoreHealth -= damage;
                    Console.WriteLine("That round was a DIRECT HIT!");
                }
                Round++;
            }
            if (CityHealth == 0)
                Console.WriteLine("The City has been destroyed! The Manticore has won this battle");
            else
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        }
    }
}
