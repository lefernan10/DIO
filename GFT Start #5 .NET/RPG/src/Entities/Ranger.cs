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
            return $"{this.name} atacou com sua Katana!";
        }

        public string Attack(int bonus)
        {
            return $"{this.name} atacou com sua Katana com um crítico de {bonus}!";
        }
    }
}