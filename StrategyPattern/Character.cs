using System;
namespace StrategyPattern
{
    public class Character
    {
        private IMoves _moves;

        public Character(IMoves moves)
        {
            this._moves = moves;
        }
    }
}
