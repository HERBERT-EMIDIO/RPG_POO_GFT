using DOTNET_POO.src.Enteties;
using DOTNET_POO.Enteties;

namespace DOTNET_POO.Enteties
{
    public abstract class Hero
    {
        public Hero(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }


        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }



        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }


    }
}