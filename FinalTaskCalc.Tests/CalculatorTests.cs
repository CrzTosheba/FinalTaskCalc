using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalTaskCalc.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void MultiplicationMustReturnEqualValue() // тест умножения,
        {
            var calculator = new Calculator();

           Assert.AreEqual(8, calculator.Miltiplication(2, 4));
           

        }
        [Test]
        public void ReturnsExpectedValue() // парочка тестов в одном сложения и деления на ожидаемое значение
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Additional(10,30), Is.EqualTo(40));
            Assert.That(calculatorTest.Division(100, 5), Is.EqualTo(20));

        }
        [Test]
        public void CheckVakueIsGreaterThenOtherValue() // тест на то что одно значение больше другого, а данном случае результат вычитания больше чем результат деления
        {
            var calcTest = new Calculator();
            Assert.Greater(calcTest.Subtraction(20,10), calcTest.Division(20,10));
        }
        [Test]
        public void CheckPositiveValue() // тест на положительное значение результата сложения и вычитания
        {
            var calcTest = new Calculator();
            Assert.Positive(calcTest.Additional(5, 10));
            Assert.Positive(calcTest.Subtraction(5, 10)); // логично что в данном месте тест не пройдет


        }
      

       
        
        

        
    }
}
