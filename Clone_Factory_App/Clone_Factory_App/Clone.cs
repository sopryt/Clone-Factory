using Clone_Factory_App.Abstract_Assignables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone_Factory_App
{
    class Clone
    {
        private Weapon _weapon;
        private Division _division;
        private Rank _rank;
        private UniqueEquipment _uniqueEquipment;

        public Clone(CloneFactory factory)
        {
            _weapon = factory.AssignWeapon();
            _division = factory.AssignDivision();
            _rank = factory.AssignRank();
            _uniqueEquipment = factory.AssignUniqueEquipment();
        }

        public string DescribeClone()
        {
            return $"A {_rank.GetType().Name} clone serving in {_division.GetType().Name} with " +
                $"a {_weapon.GetType().Name} and a {_uniqueEquipment.GetType().Name} was made";
        }
    }
}
