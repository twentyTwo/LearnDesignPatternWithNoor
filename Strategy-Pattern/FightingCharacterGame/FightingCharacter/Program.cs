using System;

namespace FightingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            King king = new King();
            king.SetFightingWeapon(new Axe());
            king.DisplayFight();

            Console.WriteLine("======================");

            Queen queen = new Queen();
            queen.SetFightingWeapon(new Knife());
            queen.DisplayFight();

            Console.WriteLine("======================");

            Character knight = new Knight();
            knight.SetFightingWeapon(new BowAndArraow());
            knight.DisplayFight();

            Console.ReadKey();
        }
    }
}
