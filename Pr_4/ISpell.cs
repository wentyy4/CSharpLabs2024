
namespace GameMagic
{
    public interface ISpell
    {
        int Damage { get; }

        void CauseDamage(IDamage damage);
    }
}
