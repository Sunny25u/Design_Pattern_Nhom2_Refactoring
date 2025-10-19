using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_ReplaceArraywithObject_23
{
    class Performance
    {
        private string name;
        private string wins;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Wins
        {
            get { return wins; }
            set { wins = value; }
        }

        public Performance(string name, string wins)
        {
            this.name = name;
            this.wins = wins;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Team: {Name}");
            Console.WriteLine($"Wins: {Wins}");
        }
    }
}
