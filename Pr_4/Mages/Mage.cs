using System;

namespace GameMagic
{
    public class Mage : Character
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

        public override void Attack(IDamagebl damagebl)
        {
            if (damagebl.GetHashCode() == this.GetHashCode())
                return;
            Spell.CauseDamage(damagebl);
            Mage mage = (Mage)damagebl;
            Console.WriteLine($"{Name} dealt damage: {mage.Name}");
        }
    }
}