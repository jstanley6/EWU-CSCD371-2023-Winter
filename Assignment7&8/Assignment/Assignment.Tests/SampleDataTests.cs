using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests;

[TestClass]
public class SampleDataTests
{
    private readonly SampleData _data = new();

    private readonly List<Address> _spokaneAddresses = new()
    {
        new Address("1702 S. Grand Blvd", "Spokane", "WA", "99203"), //Manito Park
        new Address("9711 W. Charles Road", "Nine Miles Falls", "WA", "99026"), //Riverside State Park
        new Address("26107 N. Mt Spokane Park Drive", "Mead", "WA", "99021"), //Mount Spokane
        new Address("2316 W. 1st Avenue", "Spokane", "WA", "99204"), //Northwest Museum
        new Address("3404 W. Woodland Blvd", "Spokane", "WA", "99224"), //John A Finch Arboretum
        new Address("1001 W. Sprague Avenue", "Spokane", "WA", "99201"), //Martin Woldson Theater
        new Address("10 S. Post Street", "Spokane", "WA", "99201") //Davenport Hotel
    };

    [TestMethod]
    public void SampleDataFillListCsvRows_Pass()
    {
        var items = _data.CsvRows;
        Assert.AreEqual(50, items.Count());
    }

    [TestMethod]
    public void GetUniqueSortedListOfStatesGivenCsvRows_Pass()
    {
        var states = _data.GetUniqueSortedListOfStatesGivenCsvRows();
        int actual = 27;
        int expected = states.Count();
        Assert.AreEqual<int>(expected, actual);
    }

    [TestMethod]
    public void SpokaneAddressesYieldDistinctState_True()
    {
        List<string> uniqueStatesList = new();
        foreach (var address in _spokaneAddresses)
        {
            if (!uniqueStatesList.Contains(address.State))
            {
                uniqueStatesList.Add(address.State);
            }
            
        }
        Assert.AreEqual<int>(1, uniqueStatesList.Count);
    }
    
    [TestMethod]
    public void FilterByEmailAddress()
    {
        var personEmail = _data.FilterByEmailAddress(email => email == "mthurnhamr@live.com");
        var valueTuples = personEmail as (string FirstName, string LastName)[] ?? personEmail.ToArray();
        foreach (var person in valueTuples)
        {
            Assert.IsTrue(person.FirstName == "Mayor");
        }
        
        Assert.AreEqual(1, valueTuples.Count());
    }

    [TestMethod]
    public void GetAggregateListOfStatesGivenPeopleCollection_ReturnsAggregateStringOfUniqueStates()
    {
        List<string> states = _data.GetUniqueSortedListOfStatesGivenCsvRows().ToList();
        string aggregate = _data.GetAggregateListOfStatesGivenPeopleCollection(_data.People);
        List<string> tokens = aggregate.Split(",").ToList();
        tokens.Sort();

        foreach (var token in tokens)
        {
            Console.WriteLine(token);
            Assert.IsTrue(aggregate.Contains(token));
        }
    }
    

    [TestMethod]
    public void ReturnValidListOfIPerson()
    {
        var rows = _data.CsvRows;
        var people = _data.People;
        var enumerable = rows as string[] ?? rows.ToArray();
        var zip = enumerable.Zip(people, (row, person) =>
        {
            string[] split = row.Split(",");
            Assert.AreEqual(split[1], person.FirstName);
            Assert.AreEqual(split[2], person.LastName);
            Assert.AreEqual(split[3], person.EmailAddress);
            Assert.AreEqual(split[4], person.Address.StreetAddress);
            Assert.AreEqual(split[5], person.Address.City);
            Assert.AreEqual(split[6], person.Address.State);
            Assert.AreEqual(split[7], person.Address.Zip);
            return true;
        });
        
        Assert.AreEqual(enumerable.Count(), zip.Count());

    }

}