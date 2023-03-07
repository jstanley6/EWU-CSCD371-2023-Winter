using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests;

[TestClass]

public class NodeTests
{
 
    [TestMethod]
    public void NodeLast_Pass() 
    {
        Node<string> newNode1 = new ("one");
        Assert.IsTrue(newNode1.Exists(newNode1.Last()));

        Node<string> newNode2 = new("two");
        Assert.IsTrue(newNode2.Exists(newNode2.Last()));
        
        Node<string> newNode3 = new("three");
        Assert.IsTrue(newNode3.Exists(newNode3.Last()));
    }

    [TestMethod]
    public void ChildItemsReturnsItemsLessThanMaximum_Pass()
    {
        Node<int> node1 = new(1);
        var node2 = node1.Append(2);
        var node3 = node2.Append(3);
        node3.Append(4);

        List<int> intsFromRing = node1.ChildItems(3).ToList();
        foreach (int item in intsFromRing)
        {
            Console.WriteLine(item);
        }
        Assert.AreEqual<int>(2, intsFromRing.Count);
    }
    
    [TestMethod]
    public void EnumeratorFunctions_Pass()
    {
        Node<int> node1 = new(1);
        var node2 = node1.Append(2);
        var node3 = node2.Append(3);
        node3.Append(4);

        List<int> intList = node1.ToList();
        foreach (int item in intList)
        {
            Console.WriteLine(item);
        }
        Assert.AreEqual<int>(4, intList.Count);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Duplicate")]
    public void DuplicateException_Pass()
    {
        Node<int> node1 = new(1);
        var node2 = node1.Append(2);
        var node3 = node2.Append(3);
        node3.Append(2);
    }
    
    
    [TestMethod]
    public void Duplicate_Pass()
    {
        Node<int> node1 = new(1);
        var node2 = node1.Append(2);
        node2.Append(3);
        Assert.IsTrue(node1.Exists(1));
        Assert.IsTrue(node1.Exists(2));
        Assert.IsTrue(node1.Exists(3));
        Assert.IsTrue(node2.Exists(3));
    }
    
    [TestMethod]
    public void Clear()
    {
        Node<int> node1 = new(1);
        var node2 = node1.Append(2);
        var node3 = node2.Append(3);
        Assert.AreEqual(node1, node3.Next);
        node1.Clear();
        Assert.AreEqual(node1, node1.Next);
        Assert.AreEqual(node2, node3.Next);
    }
    
}