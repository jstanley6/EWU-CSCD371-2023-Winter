using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        
        [TestMethod]
        public void InitializeJester_Pass()
        {
            OutputJoke outputJoke = new OutputJoke();
            JokeService jokeService = new JokeService();
            Assert.IsNotNull(outputJoke);
            Assert.IsNotNull(jokeService);

            Jester jester = new Jester(jokeService, outputJoke);
            Assert.IsNotNull(jester);
            Assert.AreEqual(jokeService, jester._jokeService);
            
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JesterNullArgumentException()
        {
            new Jester(null, new OutputJoke());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OutputIsNullThrowsException()
        {
            Jester testJester = new Jester(new JokeService(), null);
            Assert.IsNotNull(testJester);
            string joke = testJester.TellJoke();
            Assert.IsNotNull(joke);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JesterPrintThrowsNull()
        {
            new Jester(new JokeService(), null);
        }

        public void JesterTellJoke_Pass()
        {
            Jester testJester = new Jester(new JokeService(), new OutputJoke());
            Assert.IsNotNull(testJester);
            string joke = testJester.TellJoke();
            Assert.IsFalse(String.IsNullOrEmpty(joke));


        }
        
    }
}

