using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    internal class RoboPet : Pet
    {
        public string RobotType;
            //TimeOfDay
            //CheckTheWeather
            //PlayMusic

        public RoboPet(string name, string species)
        {
            Name = name;
            RobotType = "Robot";
            Health = 100;

        }

      


        
    }
}
