namespace QHughes_Roguelike
{
    class Enemy : Character
    {
        public Enemy()
        {
            health = 20;
            strength = 5;
        }
        public Enemy(string initName, int initHealth, int initStrength)
        {
            name = initName;
            health = initHealth;
            strength = initStrength;
        }

        public override void Attack(Character attackedCharacter)
        {
            Console.WriteLine("Enemy attacks");
            attackedCharacter.TakeDamage(strength);
        }
    }
}
