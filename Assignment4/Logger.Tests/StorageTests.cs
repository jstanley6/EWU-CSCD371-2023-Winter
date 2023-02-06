using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class StorageTests
{
    [TestMethod]
    public void Adding_Book_Entities()
    {
        Storage storage = new Storage();
        Book bookEntity = new Book
        {
            Id = Guid.NewGuid(),
            BookName = "Along Came A Spider",
            Author = new FullName("James", "Patterson"),
            Isbn = "9780316072915"
        };
        
        storage.Add(bookEntity);
        
        Assert.IsTrue(storage.Contains(bookEntity));

    }

    [TestMethod]
    public void Adding_Student_Entities()
    {
        Storage storage = new Storage();
        Student studentEntity = new Student()
        {
            Id = Guid.NewGuid(),
            FullName = new FullName("Jason", "Stanley"),
            StudentYear = StudentClassification.Senior

        };
        
        storage.Add(studentEntity);
        Assert.IsTrue(storage.Contains(studentEntity));
    }

    [TestMethod]
    public void Adding_Employee_Entities()
    {
        Storage storage = new Storage();
        Employee employeeEntity = new Employee()
        {
            FullName = new FullName("Jimmy", "Hendricks"),
            Employer = "Track Star Studios"
        };
        
        storage.Add(employeeEntity);
        Assert.IsTrue(storage.Contains(employeeEntity));
    }
}