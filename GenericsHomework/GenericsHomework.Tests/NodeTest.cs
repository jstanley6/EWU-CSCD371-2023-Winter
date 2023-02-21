namespace GenericsHomework.Tests;

[TestClass]
public class NodeTest
{

    [TestMethod]
    public void ClearCurrentNode()
    {
        int val1 = 5;
        int val2 = 4;

        Node<int> node1 = new(val1);
        Node<int> node2 = node1.Append(val2);
        
        node1.Clear();
        Assert.IsFalse(node1.NextNode == node2);
    }
    
    [TestMethod]
    public void DuplicateNodes_False()
    {
        int val1 = 1;
        int val2 = 2;
        int val3 = 3;

        Node<int> node1 = new(val1);
        Node<int> node12 = node1.Append(val2);

        bool exists = node1.Exists(val3);
        
        Assert.IsFalse(exists);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "The value already Exists")]
    public void Append_ThrowsException()
    {
        int val1 = 1;
        int val2 = 2;
        Node<int> node1 = new(val1);
        Node<int> node2 = node1.Append(val2);
        Node<int> node3 = node2.Append(val2);
        
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