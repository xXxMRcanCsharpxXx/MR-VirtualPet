using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet 
    {
        public string Name;
        public string Species;
        public int Health;
        public int Hunger;
        public int Energy;
        public int Boredom;
        
        public Pet()
        {

        }


        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Health = 100;
            Hunger = 100;
            Boredom = 100;
            Energy = 100;
           

        }
        public Pet(string name, string species, int health, int hunger, int boredom, int energy)
        {
            Name = name;
            Species = species;
            Health = health;
          
            Hunger = hunger;
            Boredom = boredom;
            Energy = energy;
        }

       public void CheckPetStatus()
        {
            Console.Clear();
            Console.WriteLine("Here is your pets current status: Hunger: " +this.Hunger + "\n Boredom: " + this.Boredom + "\n Health: " + this.Health);
            Console.ReadKey();
        }
        
        public void PlayWithPet()
           
        {
            Console.Clear();
            if(Boredom >= Energy)
            {
                Boredom -= 25;
            }
            Console.WriteLine("You played with:" + Name);
            Console.ReadKey();
        }

        public void FeedYourPet()
        {
            if (Hunger >= 0)
            {
                Hunger += 50;
            }
        }

        //public void HealthOverTime()
        //{
        //    if (Health >= 100)
        //    {
        //        Health -= 10;
        //    }
        //}

        public void Tick()
        {
            if (Boredom >= 100)
            {
                Boredom -= 10;
            }
            if (Hunger > 0)
            {
                Hunger -= 15; 
            }
            if (Boredom < 0)
            {
                Boredom = 0;
            }
            if (Hunger < 0)
            {
                Hunger = 0;
            }
        }

        public void TakePetToTheDoctor()
        {
            Health = 100;
        }

      
    } 
}

