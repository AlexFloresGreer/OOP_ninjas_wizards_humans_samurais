using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human alexhuman = new Human("Alex");
            // Console.WriteLine($"human's name is {alexhuman.name}");
            // Console.WriteLine(alexhuman.health);
            // alexhuman.attack(alexhuman);
            // Console.WriteLine("alex's health");
            // Console.WriteLine(alexhuman.health);

             Ninja rosaninja = new Ninja("Rosa");
            // Console.WriteLine($"ninja's name is {rosaninja.name}");
            // Console.WriteLine("rosa's health");
            // Console.WriteLine(rosaninja.health);
            // Console.WriteLine("rosa stealing");
            // rosaninja.steal(alexhuman);
            // Console.WriteLine("rosa's health");
            // Console.WriteLine(rosaninja.health);
            // Console.WriteLine("alex's health");
            // Console.WriteLine(alexhuman.health);
            // Console.WriteLine("rosa's health");
            // Console.WriteLine(rosaninja.health);
            // rosaninja.get_away(rosaninja);
            // Console.WriteLine("rosa's health");
            // Console.WriteLine(rosaninja.health);

            Wizard tejuwizard = new Wizard("Teju");
            // Console.WriteLine($"wizard's name is {tejuwizard.name}");
            // Console.WriteLine(tejuwizard.health);
            // tejuwizard.heal(tejuwizard);
            // Console.WriteLine(tejuwizard.health);
            // Console.WriteLine("rosa's health");
            // Console.WriteLine(rosaninja.health);
            // tejuwizard.fireball(rosaninja);
            // Console.WriteLine("rosa's health");
            // Console.WriteLine(rosaninja.health);
            // Console.WriteLine(tejuwizard.health);


            // Samurai iainsamurai = new Samurai("Iain");

           

            Samurai iainsamurai = new Samurai("Iain");
            Console.WriteLine($"samurai's name is {iainsamurai.name}");
            Console.WriteLine(iainsamurai.health);
            iainsamurai.death_blow(iainsamurai);
            Console.WriteLine("iain's health");
            Console.WriteLine(iainsamurai.health);
            iainsamurai.mediate(iainsamurai);
            Console.WriteLine(iainsamurai.health);


        }
    }
}
