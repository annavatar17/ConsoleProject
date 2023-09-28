using ConsoleProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleProjectTests
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void IsMatchBrackets_GivenMatchBrackets_ShouldReturnTrue()
        {
            string str = "<>";
            bool isMatch = StringExtension.IsMatchBrackets(str);

            Assert.IsTrue(isMatch);
        }

        [TestMethod]
        public void IsMatchBrackets_GivenCloseBracketBeforeOpenBracket_ShouldReturnFalse()
        {
            string str = "><";
            bool isMatch = StringExtension.IsMatchBrackets(str);

            Assert.IsFalse(isMatch);
        }

        [TestMethod]
        public void IsMatchBrackets_GivenUnclosedBracket_ShouldReturnFalse()
        {
            string str = "<<>";
            bool isMatch = StringExtension.IsMatchBrackets(str);

            Assert.IsFalse(isMatch);
        }

        [TestMethod]
        public void IsMatchBrackets_GivenNoBrackets_ShouldReturnTrue()
        {
            string str = "\"\"_";
            bool isMatch = StringExtension.IsMatchBrackets(str);

            Assert.IsTrue(isMatch);
        }

        [TestMethod]
        public void IsMatchBrackets_GivenMatchBracketsWithExtraCharacters_ShouldReturnTrue()
        {
            string str = "<abc...xyz>";
            bool isMatch = StringExtension.IsMatchBrackets(str);

            Assert.IsTrue(isMatch);
        }
    }
}
