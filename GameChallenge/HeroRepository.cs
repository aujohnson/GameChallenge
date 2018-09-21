using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChallenge
{
    class HeroRepository : ICharacter
    {
        //Fields
        private Hero _hero;

        public void CreateCharacter(string name)
        {
            _hero = new Hero
            {
                Name = name,
                IsAlive = true,
                AttackPower = 10,
                Health = 100,
                NumberOfLives = 3
            };
        }

        public Character CharacterDetails()
        {
            return _hero;
        }

        public void TakeDamage(int attackDamage)
        {
            throw new NotImplementedException();
        }
    }
}
