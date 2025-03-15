namespace QHughes_Roguelike
{
     class Player : Character
    {
        public Player() 
        { 
            health = 50;
            strength = 2;
        }
        public Player(string initName, int initHealth, int initStrength)
        {
            name = initName;
            health = initHealth;
            strength = initStrength;
        }

        public override void Attack(Character attackedCharacter)
        {
            Console.WriteLine("Player attacks");
            attackedCharacter.TakeDamage(strength);
        }
        public void Heal(int healAmount)
        {
            health += healAmount;
        }

    }
}
