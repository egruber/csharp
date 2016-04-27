using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using linkedList;

namespace LinkedListTesting
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void Print_First_Node_Without_Content()
        {
            // Arrange
            LL test_list = new LL();

            // Act
            test_list.printFirstNode();
        }
        [TestMethod]
        public void Add_New_Node_With_No_Content()
        {
            // Arrange
            int data = 1;
            LL test_list = new LL();

            // Act
            test_list.Add(data);
        }
    }
}
