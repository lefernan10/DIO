namespace RPG.src.Entities
{
    public class Wizard : Character
    {
        public Wizard (string name, string type, int level, int hp, int attack) : base (name, type, level, hp, attack)
        {
            this.name = name;
            this.type = type;
            this.level = level;
            this.hp = hp;
            this.attack = attack;
        }

        public override string Attack()
        {
            return $"{this.name} lançou uma bola de fogo pequena!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.name} lançou uma bola de fogo grande, adicionando +{bonus} de dano!";
            }
            else
            {
                return $"{this.name} lançou uma bola de fogo com +{bonus} de dano!";
            }
        }
    }
}