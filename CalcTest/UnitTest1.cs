using NUnit.Framework;
using AwesomeCalculator;
using System.ComponentModel;

namespace CalcTest
{
    [TestFixture]
    public class Tests
    {
             
        Calc calc = new Calc();   

        [Test(Description = "Adding two positive integers")]
        public void Addition_of_two_integers()
        {
            double a = 5, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 9); //assert
        }

        [Test(Description = "Substraction two posiive integers")]
        public void Substraction_of_two_Integer()
        {
            // ARRANGE
            double a = 89, b = 4;
            // ACT
            calc.SetFirstNumber(a);
            calc.SetSecondNumber(b);
            double actual = calc.GetSubtraction();
            // ASSERT
            Assert.AreEqual(actual,85);
            Assert.Positive(actual);

        }

        [Test(Description = "Substraction two equal posiive integers")]
        public void Substraction_of_two_equal_Integer()
        {
            // ARRANGE
            double a = 4, b = 4;
            // ACT
            calc.SetFirstNumber(a);
            calc.SetSecondNumber(b);
            double actual = calc.GetSubtraction();
            // ASSERT
            Assert.Zero(actual);

        }
        [Test(Description = "Multiplication two positive integers")]
        public void Multiplication_of_two_Integers()
        {

        }
        [Test(Description ="Division of two positive integer")]
         public void Division_of_two_Integers()
        {

        }



    }
}
