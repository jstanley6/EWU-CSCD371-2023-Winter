using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        [TestMethod]
        public void Jester_HasJokeServiceDependency_Pass()
        {
            OutputJoke outputJoke = new();
            JokeService jokeService = new();
            Jester jester = new(jokeService, outputJoke);
            Assert.AreEqual<IJokeService>(jokeService, jester.JokeService);
        }
        
        [TestMethod]
        public void Jester_HasOutputJokeDependency_Pass()
        {
            OutputJoke outputJoke = new();
            JokeService jokeService = new();
            Jester jester = new(jokeService, outputJoke);
            Assert.AreEqual<IOutputJoke>(outputJoke, jester.OutputJoke);
            
        }
        
        [TestMethod]
        public void Jester_IfJokeServiceIsNullThrowException_Pass()
        {
            
            JokeService jokeService = null!;
            OutputJoke outputJoke = new();
            Jester jester;
            Assert.ThrowsException<ArgumentNullException>(() => jester = new(jokeService, outputJoke));
        }

        [TestMethod]
        public void Jester_IfOutputJokeIsNullThrowsException_Pass()
        {

            JokeService jokeService = new()!;
            OutputJoke outputJoke = null!;
            Jester jester;
            Assert.ThrowsException<ArgumentNullException>(() => jester = new(jokeService, outputJoke));

        }
    }
}

