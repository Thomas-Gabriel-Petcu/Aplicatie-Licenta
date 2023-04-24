using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_de_gestiune_a_animalelor.Classes
{
    public class Animal
    {
        private static int currentId;
        public int Id
        {
            get {return Id; }
            private set { }
        }
        public int species;
        public string race = "default";
        public string name = "default";
        public Animal() 
        {
            currentId++;
            Id = currentId;
        }   
    }
}
