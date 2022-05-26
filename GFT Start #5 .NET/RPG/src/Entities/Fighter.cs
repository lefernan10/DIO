namespace RPG.src.Entities
{
    public class Fighter : Character
    {
        public Fighter (string name, string type, int level, int hp, int attack) : base (name, type, level, hp, attack)
        {
            this.name = name;
            this.type = type;
            this.level = level;
            this.hp = hp;
            this.attack = attack;
        }

        public override string Attack()
        {
            return $"{this.name} atacou com sua Espada!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.name} deu um ataque dilacerador com sua Espada, adicionando +{bonus} de dano!";
            }
            else
            {
                return $"{this.name} acertou um crítico com sua Espada de +{bonus} de dano!";
            }
        }
    }
}