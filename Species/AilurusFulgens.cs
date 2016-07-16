using System;

namespace Zoolandia.Species
{
    public class AilurusFulgens : Animal
    {
        public AilurusFulgens(string name) : base(name)
        {
            // This is  a constructor, since the parent has this constructor this needs it as well?? 
            // You can't do anything in here since the parent is labled as "virtual" 
        }

        public override string Eat(int numberOfFoods)
        { // override allows this child to change a "virtual" method of a parent
            string animalEat = base.Eat(3); // base allows you to get info from the parent class (in this case Animal)
            return "Nom nom nom";
        }

        public string Eat()
        {
            return "I don't know what I just ate, but it was good";
        }

        public string Welcome (string name) 
        {
            this.Name = name;
            return Welcome();
        }

        public string Welcome()
        {
            return "Welcome, " + this.Name;
        }

    }
}