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

        public RoboPet()
        {
            Name = "Robot";
            RobotType = "Robot";
            Health = 100;
        }
    }
}
