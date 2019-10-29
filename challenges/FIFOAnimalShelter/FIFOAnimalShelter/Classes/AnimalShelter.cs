using System;
using System.Collections;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Stack stackOne = new Stack();
        public Stack stackTwo = new Stack();

        public void Enqueue(object animal)
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
    }
}
