using Clone_Factory_App.Abstract_Assignables;
using Clone_Factory_App.Assignables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone_Factory_App.Soldiers
{
    class SniperFactory : CloneFactory
    {
        public override Weapon AssignWeapon()
        {
            return new SniperRifle();
        }

        public override Division AssignDivision()
        {
            return new Division527();
        }

        public override Rank AssignRank()
        {
            return new Rank3();
        }

        public override UniqueEquipment AssignUniqueEquipment()
        {
            return new Relaxant();
        }
    }
}
