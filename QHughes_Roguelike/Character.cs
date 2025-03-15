namespace QHughes_Roguelike
{
    abstract class Character
    {
        protected int strength;
        protected int health;
        public int Health
        {
            get { return health; }
            set { health = Math.Max(0,value); }
        }
        protected string name = "";
        public string Name
        {
            get { return name; }
        }
        public bool isAlive
        {
            get { return health > 0; }
        }
        //protected int _Speed;

        public abstract void Attack(Character attackedCharacter);
        public void TakeDamage(int damage)
        {
            health -= damage;
        }
        
    }
}
