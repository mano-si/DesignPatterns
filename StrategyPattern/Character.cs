using System;
namespace StrategyPattern
{
    public class Character
    {
        private IMoves _moves;

        private Character(IMoves moves)
        {
            this._moves = moves;
        }

        public Character CreateCharacter(string characterName)
        {
            switch (characterName)
            {
                case "antman":
                    return new Character(new AntmanMoves());

                case "superman":
                    return new Character(new SupermanMoves());

                case "batman":
                    return new Character(new BatmanMoves());

                default:
                    return null;
            }
        }
    }
}
