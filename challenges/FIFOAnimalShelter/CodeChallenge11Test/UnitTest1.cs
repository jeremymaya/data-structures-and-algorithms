using System;
using FIFOAnimalShelter.Classes;
using Xunit;

namespace CodeChallenge11Test
{
    public class UnitTest1
    {
        [Fact]
        public void FifoEnqueForShelterExpectedOutcome()
        {
            Dog dogOne = new Dog();
            Dog catOne = new Cat();
            Dog dogTwo = new Dog();

            AnimalShelter shelter = new AnimalShelter();

            shelter.Enqueue(dogOne);
            shelter.Enqueue(catOne);
            shelter.Enqueue(dogTwo);

            Assert.Equal(dogOne, shelter.stackOne.Peek());
        }

        [Fact]
        public void FifoForDqequeShelterExpectedOutcome()
        {
            Dog dogOne = new Dog();
            Dog catOne = new Cat();
            Dog dogTwo = new Dog();

            AnimalShelter shelter = new AnimalShelter();

            shelter.Enqueue(dogOne);
            shelter.Enqueue(catOne);
            shelter.Enqueue(dogTwo);

            Assert.Equal(catOne, shelter.Dequeue("cat"));
        }

        [Fact]
        public void FifoForDqequeShelterExpectedFailure()
        {
            Dog dogOne = new Dog();
            Dog catOne = new Cat();
            Dog dogTwo = new Dog();

            AnimalShelter shelter = new AnimalShelter();

            shelter.Enqueue(dogOne);
            shelter.Enqueue(catOne);
            shelter.Enqueue(dogTwo);

            Assert.NotEqual(dogTwo, shelter.Dequeue("dog"));
        }

        [Fact]
        public void DequeueWorksEdgeCase()
        {
            AnimalShelter shelter = new AnimalShelter();

            Assert.Null(shelter.Dequeue("horse"));
        }
    }
}
