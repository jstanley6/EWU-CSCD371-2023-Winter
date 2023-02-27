using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests;

[TestClass]
public class AddressTest
{
    [TestMethod]
    public void SetAddressProperties_Pass()
    {
        Address testAddress = new Address("4125 E Eloika Lake", "Deer Park", "WA", "99006");
        Assert.AreEqual("4125 E Eloika Lake", testAddress.StreetAddress);
        Assert.AreEqual("Deer Park", testAddress.City);
        Assert.AreEqual("WA", testAddress.State);
        Assert.AreEqual("99006", testAddress.Zip);
    }
}