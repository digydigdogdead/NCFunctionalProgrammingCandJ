using FunctionalProgramming;
using FluentAssertions;

namespace FunctionalProgrammingTest
{
    public class Tests
    {
        [Test]
        public void SquareItTest()
        {
            //Arrange

            int input = 3;
            int expected = 9;

            //Act

            int result = Exercises001.SquareIt(input);

            //Assert

            result.Should().Be(expected);
        }

        [Test]
        public void AddTenTest()
        {
            //Arrange

            int input = 7;
            int expected = 17;

            //Act

            int result = Exercises001.AddTen(input);

            //Assert

            result.Should().Be(expected);

        }

        [Test]
        public void GrammarCheckTest()
        {
            //Arrange
            string input = "Amazing!";
            bool expected = true;

            string input2 = "apple";
            bool expected2 = false;

            //Act
            bool result = Exercises001.GrammarCheck(input);

            bool result2 = Exercises001.GrammarCheck(input2);

            //Assert

            result.Should().Be(expected);
            result2.Should().Be(expected2);
        }

        [Test]
        public void CheckValidEmailTest()
        {
            //Arrange

            string email = "valisuser@northcoders.co.uk";
            string expected = "Email domain and user valid, please continue";

            string email2 = "user@gmail.com";
            string expected2 = "Email domain and user name invalid, please check your input";

            //Act

            string result = Exercises001.CheckValidEmail(email);
            string result2 = Exercises001.CheckValidEmail(email2);

            //Assert

            result.Should().Be(expected);
            result2.Should().Be(expected2);
        }

        [Test]
        public void SumIndicesTest()
        {
            //Arrange

            string str1 = "start";
            string str2 = "pale";
            int expected = 5;

            //Act

            int result = Exercises001.SumIndices(str1, str2);

            //Assert

            result.Should().Be(expected);

        }

        [Test]
        public void AddOneTest()
        {
            //Arrange

            int num = 4;
            int expected = 5;

            //Act

            int result = Exercises001.AddOne(num);

            //Assert

            result.Should().Be(expected);
        }
    }
}