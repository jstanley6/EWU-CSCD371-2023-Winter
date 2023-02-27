using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        // 1.
        public IEnumerable<string> CsvRows => File.ReadAllLines("People.csv").Skip(1);

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
        {
            List<string> uniqueSortedStates = new();
            foreach (var row in CsvRows)
            {
                var splitRow = row.Split(",");
                if (!uniqueSortedStates.Contains(splitRow[6]))
                {
                    uniqueSortedStates.Add(splitRow[6]);
                }
            }
            uniqueSortedStates.Sort();
            return uniqueSortedStates;
        }

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
        {
            var uniqueSortedStatesArray = GetUniqueSortedListOfStatesGivenCsvRows().ToArray();
            var uniqueSortedStates = string.Join(",", uniqueSortedStatesArray);
            return uniqueSortedStates;
        }

        // 4.
        public IEnumerable<IPerson> People => CsvRows.Select((row, index) =>
        {
            var split = row.Split(",");
            if (row.Split(",") is [
                    { } id, { } first, { } last, { } email, { } street, 
                    { } city, { } state, { } zip])
            {
                Address address = new Address(street, city, state, zip);
                return new Person(first, last, address, email);
            }
            throw new FormatException($"Invalid format at row {index}");
        });
        
        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter)
        {
            List<IPerson> matches = People.Where(x => filter(x.EmailAddress)).ToList();
            List<(string, string)> nameList = new();
            foreach (IPerson item in matches)
            {
                nameList.Add((item.FirstName, item.LastName));
            }

            return nameList;
        }

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => people.Select(person => person.Address.State).Distinct()
            .OrderBy(state => state).Aggregate((all, state) => $"{all}, {state}");
        
    }
}
