using System;
namespace StrategyPattern
{
    public interface IMoves
    {
        void Attack();

        void Defend();

        void SpecialMove();
    }
}
