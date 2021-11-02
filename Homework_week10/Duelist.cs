using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_week10
{
    class Duelist
    {   
        // Declare variables
        private String name;
        private double accuracy;
        private bool alive;
        private Random rand;

        //Constructor
        public Duelist(String name, double accuracy)
        {
            this.name = name;
            this.accuracy = accuracy;
            alive = true;
            rand = new Random();
           
        }

        public string Name { get => name; set => name = value; }
        public double Accuracy { get => accuracy; set => accuracy = value; }
        public bool Alive { get => alive; set => alive = value; }
        public Random Rand { get => rand; set => rand = value; }


        // ShootAtTarget method
        public void ShootAtTarget(Duelist duel)
        {
            if (rand.NextDouble() < accuracy)
            {
                duel.Alive = false;
            }
        }   

            
    }
}
