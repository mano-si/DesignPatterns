using System;
namespace StrategyPattern
{
    public class Character
    {
        private IMoves _moves;

        public Character()
            : this(new HumanMoves())
        {
        }

        public Character(IMoves moves)
        {
            this._moves = moves;
        }

        public void SetCharacterMoveStrategy(IMoves moves)
        {
            this._moves = moves;
        }

        public void Attack()
        {
            this._moves.Attack();
        }

        public void Defend()
        {
            this._moves.Defend();
        }

        public void SpecialMove()
        {
            this._moves.SpecialMove();
        }
    }
}
