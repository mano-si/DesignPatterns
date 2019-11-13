using System;
namespace StrategyPattern
{
    public class BatmanMoves : IMoves
    {
        public void Attack()
        {
            Console.WriteLine("A batman attack!");
        }

        public void Defend()
        {
            Console.WriteLine("A batman defend");
        }

        public void SpecialMove()
        {
            Console.WriteLine("Driving away in batmobil!");
        }
    }
}
