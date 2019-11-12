using System;
namespace StrategyPattern
{
    public interface IMoves
    {
        public void Attack();

        public void Defend();

        public void SpecialMove();
    }
}
