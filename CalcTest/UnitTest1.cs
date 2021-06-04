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
            // ARRANGE
            double a = 5, b = 4;
            calc.SetFirstNumber(a);
            calc.SetSecondNumber(b);
            // ACT
            double res = calc.GetAddition(); 
            // Assert
            Assert.AreEqual(res, 9); 
        }

        [Test(Description = "Substraction two posiive integers")]
        public void Substraction_of_two_positive_Integer()
        {
            // ARRANGE
            double a = 89, b = 4;
            calc.SetFirstNumber(a);
            calc.SetSecondNumber(b);
            // ACT
            double actual = calc.GetSubtraction();
            // ASSERT
            Assert.AreEqual(actual,85);
            Assert.Positive(actual);

        }
        [Test(Description = "Substraction two negitive integers, where SecondNUmber greater FirestNumber")]
        public void Substraction_of_two_negative_Integer()
        {
            // ARRANGE
            double a = -30, b = -4;
            calc.SetFirstNumber(a);
            calc.SetSecondNumber(b);
            // ACT
            double actual = calc.GetSubtraction();
            // ASSERT
            Assert.AreEqual(actual, -26);
            Assert.Negative(actual);
            
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
        public void Multiplication_of_two_positive_Integers()
        {
            // ARRANGE
            double a = 35, b = 2;
            calc.SetFirstNumber(a);
            calc.SetSecondNumber(b);
            // ACT
            double actual = calc.GetMultiplication();
            // ASSERT
            Assert.AreEqual(actual, 70);
            Assert.Positive(actual);
        }

        [Test(Description = "Multiplication two negitive integers")]
        public void Multiplication_of_two_negative_Integers()
        {
            // ARRANGE
            double a = -35, b = -2;
            calc.SetFirstNumber(a);
            calc.SetSecondNumber(b);
            // ACT
            double actual = calc.GetMultiplication();
            // ASSERT
            Assert.AreEqual(actual, 70);
            Assert.Positive(actual);
        }

        [Test(Description = "Multiplication with one negitive integers")]
        public void Multiplication_of_firstnumber_positive_and_secondnumber_negative_Integers()
        {
            // ARRANGE
            double a = -35, b = 2;
            calc.SetFirstNumber(a);
            calc.SetSecondNumber(b);
            // ACT
            double actual = calc.GetMultiplication();
            // ASSERT
            Assert.AreEqual(actual, -70);
            Assert.Negative(actual);
        }

        [Test(Description = "Multiplication with zero integers")]
        public void Multiplication_with_zero_Integers()
        {
            // ARRANGE
            double a = -35, b =0;
            calc.SetFirstNumber(a);
            calc.SetSecondNumber(b);
            // ACT
            double actual = calc.GetMultiplication();
            // ASSERT
            Assert.Zero(actual);
           
        }
        [Test(Description ="Division of two positive integer")]
         public void Division_of_two_Integers()
        {

        }



    }
}
