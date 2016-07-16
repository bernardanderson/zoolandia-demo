using System;

namespace Zoolandia
{
    public class Animal 
    {
        public Animal (string name)
        { // This is a constructor
            this.Name = name;
        }
        
        public string Name {get; set;}

        public virtual string Eat(int numberOfFoods)
        { // virtual allows children to "override" the method
            return "YUM!";
        }
    }
}