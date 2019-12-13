using Clone_Factory_App.Abstract_Assignables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone_Factory_App
{
    abstract class CloneFactory
    {
        public abstract Weapon AssignWeapon();

        public abstract Division AssignDivision();

        public abstract Rank AssignRank();

        public abstract UniqueEquipment AssignUniqueEquipment();
    }
}
