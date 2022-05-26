namespace RPG.src.Entities
{
    public class Ranger : Character
    {
        public Ranger (string name, string type, int level, int hp, int attack) : base (name, type, level, hp, attack)
        {
            this.name = name;
            this.type = type;
            this.level = level;
            this.hp = hp;
            this.attack = attack;
        }

        public override string Attack()
        {
            return $"{this.name} disparou uma flecha!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.name} conseguiu disparar duas flechas ao mesmo tempo, adicionando +{bonus} de dano!";
            }
            else
            {
                return $"{this.name} acertou a flecha em um órgão vital, adicionando +{bonus} de dano!";
            }
        }
    }
}