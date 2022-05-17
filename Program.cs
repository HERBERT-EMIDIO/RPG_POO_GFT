using System;
using DOTNET_POO.src.Enteties;
using DOTNET_POO.Enteties;


namespace DOTNET_POO.Enteties
{
    class program
    {
        static void Main(string[] args)
        {

          Knight arus  = new Knight("Arus", 23, "Knight");

          Wizard wizard = new Wizard("Jennica", 23, "White Wizard");


            System.Console.WriteLine(wizard.Attack(1));
            

        }
    }
}