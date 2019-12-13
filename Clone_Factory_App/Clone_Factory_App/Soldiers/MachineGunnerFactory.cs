using Clone_Factory_App.Abstract_Assignables;
using Clone_Factory_App.Assignables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone_Factory_App.Soldiers
{
    class MachineGunnerFactory : CloneFactory
    {
        public override Weapon AssignWeapon()
        {
            return new MachineGun();
        }

        public override Division AssignDivision()
        {
            return new Division504();
        }

        public override Rank AssignRank()
        {
            return new Rank7();
        }

        public override UniqueEquipment AssignUniqueEquipment()
        {
            return new HeavyArmour();
        }
    }
}
