using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class TestEntities
{
    [TestMethod]
    public void StudentEntities_AreEqual()
    {
        Student student1 = new Student()
        {
            Id = Guid.NewGuid(),
            FullName = new FullName("Jason", "Stanley", "Lee"),
            StudentYear = StudentClassification.Senior
        };
        Student student2 = new Student()
        {
            Id = student1.Id,
            FullName = student1.FullName,
            StudentYear = student1.StudentYear
        };
        Assert.AreEqual(student1, student2);
    }
    
    [TestMethod]
    public void BookEntities_AreEqual()
    {
        Book book1 = new Book()
        {
            Id = Guid.NewGuid(),
            BookName = "Harry Potter: The Sorceress Stone",
            Author = new FullName("J.K.", "Rowling"),
            Isbn = "978-0439708180"
        };
        Book book2 = new Book()
        {
            Id = book1.Id,
            BookName = book1.BookName,
            Author = book1.Author,
            Isbn = book1.Isbn
        };
        Assert.AreEqual(book1, book2);
    }
    
    [TestMethod]
    public void EmployeeEntities_AreEqual()
    {
        Employee employee1 = new Employee()
        {
            FullName = new FullName("Jimmy", "Hendricks"),
            Employer = "Track Star Studios"
        };
        Employee employee2 = new Employee()
        {
            FullName = employee1.FullName,
            Employer = employee1.Employer

        };
        Assert.AreEqual(employee1, employee2);
    }

    [TestMethod]
    public void EmployeeEntity_NotNull()
    {
        Employee employee = new Employee()
        {
            FullName = new FullName("Jimmy", "Hendricks"),
            Employer = "Track Star Studios"
        };
        Assert.IsNotNull(employee);
    }

    [TestMethod]
    public void BookEntity_NotNull()
    {
        Book book = new Book()
        {
            Id = Guid.NewGuid(),
            BookName = "Harry Potter: The Sorceress Stone",
            Author = new FullName("J.K.", "Rowling"),
            Isbn = "978-0439708180"
        }; 
        
        Assert.IsNotNull(book);
    }

    [TestMethod]
    public void StudentEntity_NotNull()
    {
        Student student = new Student()
        {
            Id = Guid.NewGuid(),
            FullName = new FullName("Jason", "Stanley", "Lee"),
            StudentYear = StudentClassification.Senior
        };
        
        Assert.IsNotNull(student);
    }
}