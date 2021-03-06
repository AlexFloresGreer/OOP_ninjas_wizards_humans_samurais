﻿using System;

namespace ConsoleApplication
{
//HUMAN
    public class Human
    {
        public string name;
        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int health { get; set; }

        //These properties are all private
        protected int strength { get; set; }
        protected int intelligence { get; set; }
        protected int dexterity { get; set; }

        //Human Constructor
        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj)
        {
            if(obj.GetType() == typeof(Human))
            {
                var enemy = obj as Human;
                enemy.health -= strength * 5;
            }
            else
            {
                Console.WriteLine("Failed Attack");
            }
        }
    }

}
