using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Herd
    {
        public List<Dinosaur> dinosaurs;

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            Dinosaur dinosaur1 = new Dinosaur("T Rex");
            Dinosaur dinosaur2 = new Dinosaur("Velociraptor");
            Dinosaur dinosaur3 = new Dinosaur("Raptorex");
            dinosaurs.Add(dinosaur1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);
        }


        ////choose a weapon
        //public void SelectWeapon()
        //{

        //}
        ////outsmart the enemy
        //public void OutSmart()
        //{

        //}
        ////reboot health
        //public void Rest()
        //{

        //}
        ////escape
        //public void Escape()
        //{

        //}
        ////defend
        //public void Defend()
        //{

        //}
        ////call for help
        //public void Help()
        //{

        //}

        //public string PowerUp()
        //{
        //    Console.WriteLine("Ready to battle?)
        //       battery = Console.ReadLine();
        //}
    }
}
