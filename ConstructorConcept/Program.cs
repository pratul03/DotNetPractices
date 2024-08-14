using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Anime obj1 = new Anime();
            Anime obj2 = new Anime("Naruto","Adventure",9.5);
            Anime obj3 = new Anime(obj2);
        }
    }

    public class Anime
    {
        public string animeName;
        public string generName;
        public double imDbRating;

        public Anime()
        {
            Console.WriteLine("This is default Constructor.");
        }

        public Anime(string animeName, string generName, double imDbRating)
        {
            Console.WriteLine("Parameterized Constructor.");
            Console.WriteLine("Name :" +animeName);
            Console.WriteLine("Gener :" + generName);
            Console.WriteLine("Rating :" + imDbRating);
        }

        public Anime(Anime anime)
        {
            Console.WriteLine("Copy Constructor");
            animeName = anime.animeName;
            generName = anime.generName;
            imDbRating = anime.imDbRating;
        }


    }
}
