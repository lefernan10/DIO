namespace RPG.src.Entities
{
    public class Cleric : Character
    {
        public Cleric (string name, string type, int level, int hp, int attack) : base (name, type, level, hp, attack)
        {
            this.name = name;
            this.type = type;
            this.level = level;
            this.hp = hp;
            this.attack = attack;
        }

        public override string Attack()
        {
            return $"{this.name} atacou com sua Maça!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.name} deu um ataque esmagador com sua Maça, adicionando +{bonus} de dano!";
            }
            else
            {
                return $"{this.name} acertou um crítico com sua Maça de +{bonus} de dano!";
            }
        }
    }
}