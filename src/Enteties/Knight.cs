using DOTNET_POO.Enteties;

namespace DOTNET_POO.src.Enteties{
    public class Knight : Hero
    {
        public Knight(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

    }
}