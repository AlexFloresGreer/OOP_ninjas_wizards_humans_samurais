using System;

namespace ConsoleApplication
{

//Ninja
    public class Ninja : Human
         {

            public Ninja(string ninjaname) : base("ninja")
            {
                name = ninjaname;
                strength = 3;
                intelligence = 25;
                dexterity = 175;
                health = 50;
            }
            public Ninja(string ninjaname, int str, int intel, int dex, int hp) :base(ninjaname, str, intel, dex, hp)
            {
            }

            public void steal(object obj)
            {
                if(obj.GetType() == typeof(Human))
                { 
                    health += 10;
                }
                else
                {
                    Console.WriteLine("ninja not stealing");
                }
            }
            public void get_away(object obj)
            {
                    health -= 15;
            }
    }
}


