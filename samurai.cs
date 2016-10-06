using System;

namespace ConsoleApplication
{

//Samurai
    public class Samurai
        {
            public string name;
            //The { get; set; } format creates accessor methods for the field specified
            //This is done to allow flexibility
            public int health { get; set; }
            //These properties are all private
            int strength { get; set; }
            int intelligence { get; set; }
            int dexterity { get; set; }

            //Samurai Constructor
            public Samurai(string samurainame)
            {
                name = samurainame;
                strength = 3;
                intelligence = 25;
                dexterity = 175;
                health = 100;
            }
            public Samurai(string samurainame, int str, int intel, int dex, int hp)
            {
                name = samurainame;
                strength = str;
                intelligence = intel;
                dexterity = dex;
                health = 200;
            }
         
            public void death_blow(object obj)
            {
                if(obj.GetType() == typeof(Human))
                { 
                    var enemy = obj as Human;
                    if (enemy.health < 50)
                    {
                        enemy.health = 0;
                    }
                }
            }
            public void mediate(object obj)
            {
                    health = 200;
            }
           
        }


        
    
}
