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
        public void Add_Front_With_No_Content()
        {
            // Arrange
            LL test_list = new LL();

            // Act
            test_list.AddFront(null);
        }
        [TestMethod]
        public void Add_Front_With_Content()
        {
            // Arrange 
            string test_data = "test Data";
            LL test_list = new LL();

            // Act
            test_list.AddFront(test_data);
        }
        [TestMethod]
        public void Add_Back_With_Content()
        {
            // Arrange 
            string test_data = "test data";
            LL test_list = new LL();

            // Act
            test_list.AddEnd(test_data);

        }
        [TestMethod]
        public void Verify_Print_Nodes_Outputs_All_Nodes_In_Order()
        {
            // Arrange
            string testInputOne = "first";
            string testInputTwo = "second";
            LL test_list = new LL();
            test_list.AddFront(testInputOne);
            test_list.AddEnd(testInputTwo);

            // Act
            test_list.printNodes();
        }
    }
}
