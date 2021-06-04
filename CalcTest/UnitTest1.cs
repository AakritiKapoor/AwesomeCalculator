using NUnit.Framework;
using AwesomeCalculator;

namespace CalcTest
{
    [TestFixture]
    public class Tests
    {
             
        Calc calc = new Calc();   

        [Test]
        public void Addition_of_two_integers()
        {
            double a = 5, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 9); //assert
        }



    }
}
