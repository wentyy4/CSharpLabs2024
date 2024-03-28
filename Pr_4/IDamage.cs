
namespace GameMagic
{
    public interface IDamage
    {
        int Hp { get; set; }
        void TakeDamage(int damage);
    }
}
