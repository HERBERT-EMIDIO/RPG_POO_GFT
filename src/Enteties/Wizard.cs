using System;
using DOTNET_POO.Enteties;
using DOTNET_POO.src.Enteties;

namespace DOTNET_POO.src.Enteties
{
    public class Wizard : Hero
    {


        public Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }


        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + "Lançou Magia Super Efetiva com Bonus de " + Bonus;
            }
            else
            {
                return this.Name + "Lançou Magia com Força Fraca de " + Bonus;
            }
        }
    }
}