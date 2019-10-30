using System;
using System.Collections.Generic;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Stack<Animal> stackOne = new Stack<Animal>();
        public Stack<Animal> stackTwo = new Stack<Animal>();

        public void Enqueue(Animal animal)
        {
            while (stackOne.Count != 0)
            {
                stackTwo.Push(stackOne.Pop());
            }

            stackOne.Push(animal);

            while (stackTwo.Count != 0)
            {
                stackOne.Push(stackTwo.Pop());
            }
        }

        public Animal Dequeue(string pref)
        {
            if(pref == "dog")
            {
                while (stackOne.Peek().GetType() != typeof(Dog))
                {
                    stackOne.Push(stackTwo.Pop());
                }
            }
            else if (pref == "cat")
            {
                while (stackOne.Peek().GetType() != typeof(Cat))
                {
                    stackOne.Push(stackTwo.Pop());
                }
            }
            else if (pref != "dog" || pref != "cat")
            {
                return null;
            }

            Animal animal = stackOne.Pop();

            while (stackTwo.Count != 0)
            {
                stackOne.Push(stackTwo.Pop());
            }

            return animal;
        }
    }
}
