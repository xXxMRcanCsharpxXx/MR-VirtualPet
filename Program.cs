// Your Program Code Here
using template_csharp_virtual_pet;

Shelter shelter = new Shelter();
Pet activePet = new Pet();


Console.WriteLine("Welcome to Virtual Pet!");

bool isRunning = true;
while (isRunning)
{
    Console.Clear();
    Console.WriteLine("><>Welcome<>To<>The<>Pet<>Shelter<><");
    Console.WriteLine("><><><><><><><><><><><><><><><><><><><><><\n");
    Console.WriteLine("Press any key to enter");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("I can't wait to see which pet you adopt!\n");
    Console.WriteLine("Which would you like to do?");
    Console.WriteLine("1. Adopt a pet from the shelter");
    Console.WriteLine("2. View all pets in the shelter");
    Console.WriteLine("3. Feed your pet");
    Console.WriteLine("4. Play with your pet ");
    Console.WriteLine("5. Take your pet to the doctor ");
    Console.WriteLine("6. Put down a pet from the shelter :.(");
    Console.WriteLine("Press D if you're Done");

    string input = Console.ReadLine().ToLower();

   

    switch (input)
    {
        case "1":
            shelter.AddAPetToShelter();
            break;
        case "2":
            shelter.ViewAllPetsInsideShelter();
            break;
        case "3":
            activePet.FeedYourPet();
            break;
        case "4":
            activePet.PlayWithPet();
            break;
        case "5":
            activePet.TakePetToTheDoctor();
            break;
        case "6":
            shelter.DeletePetFromShelter();
            break;
        case "d":
            isRunning = false;
            Console.WriteLine("Come back to adopt a new pet, take care!");
            break;
        default:
            break;
    }
}

