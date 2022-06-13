using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    internal class Shelter
    {
        public List<Pet> Pets;
        public Shelter()
        {
            Pets = new List<Pet>();
 

        }

 public void AddAPetToShelter()
    {
        Console.WriteLine("What are you naming your new pet?");
        string Name = Console.ReadLine();
        Console.WriteLine("Your new pets name is: " + Name);

        Console.Clear();
        Console.WriteLine("What is your pets species?");
        string Species = Console.ReadLine();
        Console.WriteLine("Your new pets species is: " + Species);
        Console.ReadKey();
        Console.WriteLine("You added: " + Species + Name + "to the shelter");
        Console.ReadKey();

        Pet friend = new Pet(Name, Species);
        Pets.Add(friend);
    }

    public void ViewAllPetsInsideShelter()
    {
        foreach (Pet pet in Pets)
        {
            Console.WriteLine(pet.Species);

        }
    }

    public void DeletePetFromShelter()
    {
            bool isRunning = true;
            int input = Int32.Parse(Console.ReadLine());
            while (isRunning)
            {
         switch (input)
        {
            case 0:
                Console.Clear();
                Console.WriteLine("Please type a numeric value.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                break;
            case 1:
                    isRunning = false;
                break;
            case 2:
                    isRunning = false;
                break;
            case 3:
                    isRunning = false;
                break;
            case 4:
                    isRunning = false;
                break;
            case 5:
                    isRunning = false;
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Which Animal would you like to put down? :.(");
                for (int i = 0; i < this.Pets.Count; i++)
                {
                   Console.WriteLine((i + 1) + ". "+ this.Pets[i].Name );
                }
                
               
                    int petChoice;
                    petChoice = Int32.Parse(Console.ReadLine());
                   
                   
                    
                        Console.Clear();
                        Console.WriteLine("You removed pet " + this.Pets[petChoice - 1].Name);
                        this.Pets.RemoveAt(petChoice - 1);
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadKey();
                    
                
                {
                    Console.Clear();
                    Console.WriteLine("You did not remove a pet.");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadKey();
                }
                break;
            case 7:
                isRunning = false;
                break;
            default:
                Console.Clear();
                Console.WriteLine("Not sure what you just tried to do but try again :/");
                Console.WriteLine("Press enter to continue.");
                Console.ReadKey();
                break;
        }
    }

   

}

    }
            }
       
    

   
    

