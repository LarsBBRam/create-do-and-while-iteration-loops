namespace create_do_and_while_iteration_loops;

class Program
{
    static void Main(string[] args)
    {
        Random monsterAttack = new Random();
        Random heroAttack = new Random();


        int monsterHealth = 10;
        int heroHealth = 10;

        do
        {
            int heroStrike = heroAttack.Next(1, 11);
            int monsterStrike = monsterAttack.Next(1, 11);

            monsterHealth -= heroStrike;
            Console.WriteLine($"The hero strikes the monster for {heroStrike}! The monster has {monsterHealth} health left.");
            if (monsterHealth >= 0)
            {
                heroHealth -= monsterStrike;
                Console.WriteLine($"The monster strikes the hero for {monsterStrike}! The hero has {heroHealth} health left.");
            }
        } while ((heroHealth > 0) && (monsterHealth > 0));

        if (monsterHealth == 0)
            Console.WriteLine($"The monster is defeated! The hero has {heroHealth} health left.");
        else
            Console.WriteLine($" \t\t\t GAME OVER\nThe monster defeats the hero, and the monster had {monsterHealth} health left.");


        // Random random = new Random();
        // int current = random.Next(1, 11);

        // do
        // {
        //     current = random.Next(1, 11);

        //     if (current >= 8) continue;

        //     Console.WriteLine(current);

        // } while (current != 7);

        // while (current >= 3)
        // {
        //     Console.WriteLine(current);
        //     current = random.Next(1, 11);
        // }
        // Console.WriteLine($"Last number: {current}");
    }
}
