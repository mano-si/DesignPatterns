using System;
namespace StrategyPattern
{
    public class SupermanMoves : IMoves
    {
        public void Attack()
        {
            Console.WriteLine("A superman attack!");
        }

        public void Defend()
        {
            Console.WriteLine("A superman defend");
        }

        public void SpecialMove()
        {
            Console.WriteLine("A flying kick from superman!");
        }
    }
}
