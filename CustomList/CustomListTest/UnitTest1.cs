using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        // unit test for adding multiple items to check position of last item
        // unit test for adding multiple items to check Count property
        // unit test for adding number of items beyond 'Capacity' but it still adds

        [TestMethod]
        public void Add_AddToFullCapacityList_ItemGoesToNewArray()
        {
            //arrange
            MyList<int> testList = new MyList<int>();
            int expected = 8;
            int actual;

            //act
            testList.Add(15);
            testList.Add(15);
            testList.Add(15);
            testList.Add(15);
            testList.Add(15);
            testList.Add(15);
            actual = testList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }
            
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            MyList<int> testList = new MyList<int>();
            int expected = 12;
            int actual;
            

            // act
            testList.Add(12);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_CountIncrements()
        {
            // arrange
            MyList<int> testList = new MyList<int>();
            int expected = 1 ;
            int actual;

            // act
            testList.Add(25);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_CheckCountOrder()
        { 
            //arrange
            MyList<int> testList = new MyList<int>();
            int expected = 3;
            int actual;

            //act
            testList.Add(3);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_PickItemAtLastIndex()
        {
            //arrange
            MyList<int> testList = new MyList<int>();
            int expected = 5;
            int actual;

            //act
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            actual = testList[3];

            //assert
            Assert.AreEqual(expected, actual);        
        }
    }
    
}
