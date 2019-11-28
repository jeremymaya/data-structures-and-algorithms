using HashtableImplementation.Classes;
using System;
using Xunit;
using static HashtableImplementation.Program;

namespace CodeChallenge30Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddAKeyValueToHashtableResultsInTheValueBeingInTheDataStructure()
        {
            Hashtable testHashtable = new Hashtable();

            testHashtable.Add("Test", "Value");

            Assert.True(testHashtable.Contains("Test"));
        }

        [Fact]
        public void CanRetrieveBasedOnAKeyReturnsTheValueStored()
        {
            Hashtable testHashtable = new Hashtable();

            testHashtable.Add("Test", "Value");

            Assert.Equal("Value", testHashtable.Get("Test").Value);
        }

        [Fact]
        public void ReturnsNullForAKeyThatDoesNotExistInTheHashtable()
        {
            Hashtable testHashtable = new Hashtable();

            testHashtable.Add("Test", "Value");

            Assert.Null(testHashtable.Get("Hello"));
        }

        [Fact]
        public void CanHandleACollisionWithinTheHashtable()
        {
            Hashtable testHashtable = new Hashtable();

            testHashtable.Add("Test", "ValueOne");
            testHashtable.Add("eTst", "ValueTwo");

            Assert.Equal(testHashtable.Hash("eTst"), testHashtable.Hash("Test"));
        }

        [Fact]
        public void CanrRetrieveAValueFromABucketWithinTheHashtableThatHasACollision()
        {
            Hashtable testHashtable = new Hashtable();

            testHashtable.Add("Test", "ValueOne");
            testHashtable.Add("eTst", "ValueTwo");

            Assert.Equal(testHashtable.Hash("eTst"), testHashtable.Hash("Test"));
            Assert.Equal("ValueOne", testHashtable.Get("Test").Value);
            Assert.Equal("ValueTwo", testHashtable.Get("eTst").Value);
        }

        [Fact]
        public void CanrHashAKeyToAnInRangeValue()
        {
            Hashtable testHashtable = new Hashtable();

            testHashtable.Add("Test", "ValueOne");

            Assert.InRange(testHashtable.Hash("Test"), 0 , 1024);
        }
    }
}
