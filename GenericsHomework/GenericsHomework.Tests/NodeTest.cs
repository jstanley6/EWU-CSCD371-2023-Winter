namespace GenericsHomework.Tests;

[TestClass]
public class NodeTest
{ 
   
    
    [TestMethod]
    public void CreateNodeHasSameValue_True()
    {
        int testNodeVal = 52;
        Node<int>? node = new (testNodeVal);
       
        Assert.AreEqual(testNodeVal, node.Value);
        
    }

    [TestMethod]
    public void CreateNodeHasSameValue_False()
    {
        int testNodeVal = 45;
        Node<int> node = new (10);
        
        Assert.IsFalse(testNodeVal == node.Value);
    }

    [TestMethod]
    public void CreateNodeIntValueToString()
    {
        int testNodeVal = 6;
        Node<int> node = new (testNodeVal);
        
        Assert.AreEqual(testNodeVal.ToString(), node.ToString());
    }

    [TestMethod]
    public void CreateNodeString()
    {
        string testNodeVal = "Hello";
        Node<string> node = new(testNodeVal);
        Assert.AreEqual(testNodeVal, node.ToString());
    }
    
}