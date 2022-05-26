namespace RPG.src.Entities
{
    public abstract class Character
    {
        public string name;
        public string type;
        public int level;
        public int hp;
        public int attack;
               

        public Character(string name, string type, int level, int hp, int attack)
        {
            this.name = name;
            this.type = type;
            this.level = level;
            this.hp = hp;
            this.attack = attack;
        }

        public override string ToString()
        {
            return $"{this.name} {this.type} {this.level} {this.hp} {this.attack}";
        }

        public virtual string Attack()
        {
            return $"{this.name} atacou!";
        }
    }
}