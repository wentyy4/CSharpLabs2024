using System;

namespace GameMagic
{
    public class Mage : Heroes
    {
        private ISpell _spell;

        public Spell Spell
        {
            get => (Spell)_spell;
            set => _spell = value;
        }

        public Mage(int hp, ISpell spell, string name) : base(name)
        {
            Hp = hp;
            _spell = spell;
        }

        public override void Attack(IDamage damage)
        {
            if (damagebl.GetHashCode() == this.GetHashCode())
                return;
            Spell.CauseDamage(damage);
            Mage mage = (Mage)damage;
            Console.WriteLine($"{Name} dealt damage: {mage.Name}");
        }
    }
}
