namespace RPG.src.Entities
{
    public class Rogue : Character
    {
        public Rogue (string name, string type, int level, int hp, int attack) : base (name, type, level, hp, attack)
        {
            this.name = name;
            this.type = type;
            this.level = level;
            this.hp = hp;
            this.attack = attack;
        }

        public override string Attack()
        {
            return $"{this.name} atacou com sua Adaga!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.name} apunhalou o alvo pelas costas com sua Adaga, adicionando +{bonus} de dano!";
            }
            else
            {
                return $"{this.name} acertou um crítico com sua Adaga de +{bonus} de dano!";
            }
        }
    }
}