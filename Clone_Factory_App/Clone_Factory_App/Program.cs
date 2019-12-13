using Clone_Factory_App.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone_Factory_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Clone StormStrooper = new Clone(new StormTrooperFactory());
            Console.WriteLine($"Success: {StormStrooper.DescribeClone()}");

            Clone Scout = new Clone(new ScoutFactory());
            Console.WriteLine($"Success: {Scout.DescribeClone()}");

            Clone Sniper = new Clone(new SniperFactory());
            Console.WriteLine($"Success: {Sniper.DescribeClone()}");

            Clone MachineGunner = new Clone(new MachineGunnerFactory());
            Console.WriteLine($"Success: {MachineGunner.DescribeClone()}");

            Console.ReadKey();
        }
    }
}
