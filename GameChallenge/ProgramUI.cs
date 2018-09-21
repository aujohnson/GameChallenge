using System;

namespace GameChallenge
{
    internal class ProgramUI
    {
        private HeroRepository _heroRepo = new HeroRepository();
        private EnemyRepository _enemyRepo = new EnemyRepository();



        public void Run()
        {
            SetUpGame();
            RunGame();
            EndGame();
        }

        private void SetUpGame()
        {
            CreteHero();
            CreateEnemy();
            ShowHeroDetails();
            ShowEnemyDetails();
        }

        private void CreteHero()
        {
            Console.WriteLine("What is thy name, wanderer?\n");

            string name = Console.ReadLine();

            _heroRepo.CreateCharacter(name);
        }

        private void CreateEnemy()
        {
            Console.WriteLine("What is the name, of thy foe?\n");
            string name = Console.ReadLine();

            _enemyRepo.CreateCharacter(name);
        }

        private void ShowHeroDetails()
        {
            Console.WriteLine("Here are the details for your hero:");

            var hero = _heroRepo.CharacterDetails();

            Console.WriteLine($"Character Details for {hero.Name}\n" +
                $"Health: {hero.Health}\n" +
                $"Attack: {hero.AttackPower}\n" +
                $"Stuff: {hero.Name}\n");
        }

        private void ShowEnemyDetails()
        {
            Console.WriteLine("Here are the details for your enemy:");

            var enemy = _enemyRepo.CharacterDetails();

            Console.WriteLine($"Character Details for {enemy.Name}\n" +
                $"Health: {enemy.Health}\n" +
                $"Attack: {enemy.AttackPower}\n" +
                $"Stuff: {enemy.Name}\n");
        }

        private void RunGame()
        {
            var hero = _heroRepo.CharacterDetails();
            var enemy = _enemyRepo.CharacterDetails();

            while (hero.IsAlive && enemy.IsAlive)
            {
                //DO STUFF
                PromptPlayer();
            }
        }

        private void PromptPlayer()
        {
            Console.WriteLine("What would you like to do?:" +
                "1. Attack" +
                "2. Flee" +
                "3. Hide");

            var input = int.Parse(Console.ReadLine());
            HandleBattleInput(input);
        }

        private void HandleBattleInput(int input)
        {
            switch (input)
            {
                case 1:
                    Attack();
                    break;
                case 2:
                    Flee();
                    break;
                case 3:
                    Hide();
                    break;
                default:
                    break;
            }



        }

        private void Attack()
        {
            //Get a hero variable
            var hero = _heroRepo.CharacterDetails();
            var enemy = _enemyRepo.CharacterDetails();

            _enemyRepo.TakeDamage(hero.AttackPower);

            Console.WriteLine($"{enemy.Name}'s health is {enemy.Health}");


        }

        private void Flee()
        {
            throw new NotImplementedException();
        }

        private void Hide()
        {
            throw new NotImplementedException();
        }

        private void EndGame()
        {
            throw new NotImplementedException();
        }
    }
}