using System;

namespace advantgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Adventure Game!");
            Console.WriteLine("What is your name?");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine("Hello " + player.Name + "!" + " ready to play the game? [y/n]");
            string answer = Console.ReadLine();
            if(answer == "y")
            {
                Console.WriteLine(player.Name + " is entering the world...");
                Enemy enemy1 = new Enemy("Butterfly");
                Console.WriteLine(player.Name + " is encountering " + enemy1.Name);
                Console.WriteLine(enemy1.Name + " is attacking " + player.Name);
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. Run Away");

                while(!player.IsDead && !enemy1.IsDead)
                {
                    string action = Console.ReadLine();
                    switch(action)
                    {
                        case "1":
                            Console.WriteLine(player.Name + " is doing a single attack");
                            enemy1.GetHit(player.AttackPower);
                            player.Experience += 0.3f;
                            enemy1.Attack(enemy1.AttackPower);
                            player.GetHit(enemy1.AttackPower);
                            Console.Write("Player Health: " + player.Health + " | Enemy Health: " + enemy1.Health + "\n");
                            break;
                        case "2":
                            player.Swing();
                            enemy1.GetHit(player.AttackPower);
                            player.Experience += 0.9f;
                            Console.Write("Player Health: " + player.Health + " | Enemy Health: " + enemy1.Health + "\n");
                            break;
                        case "3":
                            player.Rest();
                            enemy1.Attack(enemy1.AttackPower);
                            player.GetHit(enemy1.AttackPower);
                            break;
                        case "4":
                            Console.WriteLine(player.Name + " ran away!");
                            break;
                        default:
                            Console.WriteLine("Invalid action");
                            break;
                    }
                }
                Console.WriteLine(player.Name + " get " + player.Experience + " experience");
            }
            else
            {
                Console.WriteLine("Goodbye...");
                Console.Read();
            }
        }
    }
    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        Random rnd = new Random();
    public Novice()
        {
            Health = 100;
            AttackPower = 1;
            SkillSlot = 0;
            IsDead = false;
            Experience = 0f;
            Name = "Newbie";
        }
        public void Swing()
        {
            if(SkillSlot > 0)
            {
                Console.WriteLine(Name + " is swinging his sword!");
                AttackPower = AttackPower + rnd.Next(3, 11);
                SkillSlot--;
            }
            else
            {
                Console.WriteLine("You don't have enough skill slot!");
            }
        }
        public void GetHit(int hitValue)
        {
            Console.WriteLine(Name + " is hit for " + hitValue + " damage!");
            Health -= hitValue;

            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }
        public void Rest()
        {
            Console.WriteLine(Name + " is resting...");
            SkillSlot = 3;
            AttackPower = 1;
        }
        public void Die()
        {
            IsDead = true;
            Console.WriteLine(Name + " is dead. Game Over!");
        }
    }
    
    class Enemy
    {
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        public string Name { get; set; }
        Random rnd = new Random();

        public Enemy(string name)
        {
            Health = 50;
            Name = name;
        }
        public void Attack(int damage)
        {
            AttackPower = rnd.Next(1, 10);
        }
        public void GetHit(int hitValue)
        {
            Console.WriteLine(Name + " is hit for " + hitValue + " damage!");
            Health -= hitValue;

            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }
        public void Die()
        {
            IsDead = true;
            Console.WriteLine(Name + " has died!");
        }
    }
}