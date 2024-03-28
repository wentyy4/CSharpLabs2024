
namespace GameMagic
{
    public abstract class Heroes : IDamage
    {
        private int _hp;
        private string _name;

        protected Heroes(string name)
        {
            _name = name;
        }

        public int Hp
        {
            get => _hp;
            set
            {
                _hp = value;
                Console.WriteLine($"The current health of the player  {Name}, is [{Hp}]");
            }
        }
        public string Name
        {
            get => _name;
            protected set => _name = value;
        }
        public void TakeDamage(int damage)
        {
            Hp -= damage;
        }

        public abstract void Attack(IDamage damage);
    }
}
