using System;
namespace StrategyPattern
{
    public class AntmanMoves : IMoves
    {
        public void Attack()
        {
            Console.WriteLine("A antman attack!");
        }

        public void Defend()
        {
            Console.WriteLine("A antman defend");
        }

        public void SpecialMove()
        {
            Console.WriteLine("Becoming too small to see and kicking ass!");
        }
    }
}
