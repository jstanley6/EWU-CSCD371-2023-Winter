namespace GenericsHomework.Tests;

[TestClass]
public class NodeTest
{ 
   
    
    [TestMethod]
    public void NodeExists_False()
    {
        Node<int>? node = new (5);
        Assert.IsFalse(node.Exists(10));
        
    }

    [TestMethod]
    public void CreateNodeNext_True()
    { 
        Node<int>? node = new (10);
        Assert.AreEqual(node, node.NextNode);
    }
}