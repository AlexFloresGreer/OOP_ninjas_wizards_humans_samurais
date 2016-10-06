using System;

namespace ConsoleApplication
{

   
//Wizard
 public class Wizard : Human
 {
        // public int count = 0;

//         //Wizard Constructor
        public Wizard(string wizardname) : base("wizard")
        {
            name = wizardname;
            strength = 3;
            intelligence = 25;
            dexterity = 3;
            health = 50;
            // count ++;
        }
        public Wizard(string wizardname, int str, int intel, int dex, int hp) :base(wizardname, str, intel, dex, hp)
        {
        }
        //healing method
        public void heal(object obj)
        {
                health = intelligence * 10;
        }
        //fireball method
        public void fireball(object obj)
        {
            Random rnd = new Random();
            if(obj.GetType() == typeof(Human))
            {
                var enemy = obj as Human;
                enemy.health -= rnd.Next(20,50);
            }
        }

 }
}
