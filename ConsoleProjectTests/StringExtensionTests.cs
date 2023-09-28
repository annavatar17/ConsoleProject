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
            var str = "<>";
            bool isMatch = StringExtension.IsMatchBrackets(str);

            Assert.IsTrue(isMatch);
        }

        [TestMethod]
        public void IsMatchBrackets_GivenCloseBracketBeforeOpenBracket_ShouldReturnFalse()
        {
            var str = "><";
            bool isMatch = StringExtension.IsMatchBrackets(str);

            Assert.IsFalse(isMatch);
        }

        [TestMethod]
        public void IsMatchBrackets_GivenUnclosedBracket_ShouldReturnFalse()
        {
            var str = "<<>";
            bool isMatch = StringExtension.IsMatchBrackets(str);

            Assert.IsFalse(isMatch);
        }

        [TestMethod]
        public void IsMatchBrackets_GivenNoBrackets_ShouldReturnTrue()
        {
            var str = "\"\"_";
            bool isMatch = StringExtension.IsMatchBrackets(str);

            Assert.IsTrue(isMatch);
        }

        [TestMethod]
        public void IsMatchBrackets_GivenMatchBracketsWithExtraCharacters_ShouldReturnTrue()
        {
            var str = "<abc...xyz>";
            bool isMatch = StringExtension.IsMatchBrackets(str);

            Assert.IsTrue(isMatch);
        }

        [TestMethod]
        public void IsMatchBrackets_GivenOnlyCloseBracket_ShouldReturnFalse()
        {
            var str = ">";
            bool isMatch = StringExtension.IsMatchBrackets(str);

            Assert.IsFalse(isMatch);
        }
    }
}
