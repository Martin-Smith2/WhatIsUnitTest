using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
//Start reading from here
//Notice that this test is not going to show "HOW" to write tests, but rather
//It's purpose is to show the absolute begginers "WHAT" does it feel like to have your 
//Test , Documentations,and Requirements at a single place.
//So it does not follow the AAA rule, because I wanted it to be readable 
//by any non programmer folks at the room.
namespace Calculator.UnitTests {
    [TestClass]
    public class CalculatorTests {
        [TestMethod]
        public void OnePlusTwo_ShouldEqual_Three() {//The method name indicates what does it means that the test shows the requirement
            1.plus(2).Should().Be(3); //This single line does not follow the AAA rule. It's simply an example to make the students feel what does "your tests are your documentations" mean.
        }
    }
}
