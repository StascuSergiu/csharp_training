using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Participant
    {
        public String name{ get; set; }
        public int id { get; set; }
        public int score { get; set; }

        public Participant(string name, int id, int score)
        {
            this.name = name;
            this.id = id;
            this.score = score;
        }   

        public void Print()
        {
            Console.WriteLine("Name is: \t\t" + name);
            Console.WriteLine("Id is: \t\t\t" + id.ToString());
            Console.WriteLine("Score is: \t\t" + score.ToString());
            Console.WriteLine();
        }
    }
}
