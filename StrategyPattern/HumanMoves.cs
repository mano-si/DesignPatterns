using System;
namespace StrategyPattern
{
    public class HumanMoves : IMoves
    {
        public void Attack()
        {
            Console.WriteLine("A human attack!");
        }

        public void Defend()
        {
            Console.WriteLine("A human defend");
        }

        public void SpecialMove()
        {
            Console.WriteLine("None");
        }
    }
}
