using CalculatorLibrary;
using CalculatorLibraryTests.Mocks;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Linq;

namespace CalculatorLibraryTests
{
    public class SimpleCalculatorTests
    {
        private readonly int maxIntValue = int.MaxValue;
        private MockDebugReporter TestDebugReporter;

        [SetUp]
        public void SetUpTest()
        {
            TestDebugReporter = new MockDebugReporter();
        }

        [Test]
        public void Can_instantiate_calculator()
        {
            // Act
            var result = new SimpleCalculator(TestDebugReporter);

            // Assert
            result.Should().BeOfType(typeof(SimpleCalculator));
        }

        #region Addition Tests
        [Test]
        public void Can_add_integers()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            int result = testFunction.Add(8, 5);

            //Assert
            result.Should().Be(13);
            TestDebugReporter.ReportedMessages.First().Should().Contain("Calculator called Add method.");
        }

        [Test]
        public void Can_add_negative_integer()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            int result = testFunction.Add(8, -5);

            //Assert
            result.Should().Be(3);
            TestDebugReporter.ReportedMessages.First().Should().Contain("Calculator called Add method.");
        }

        [Test]
        public void Can_return_error_if_add_exceeds_min_value()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            try
            {
                int result = testFunction.Add(-5, -maxIntValue);
            }
            catch (OverflowException exception)
            {
                // Assert
                exception.Should().NotBeNull();
            }
        }

        [Test]
        public void Can_return_error_if_add_exceeds_max_value()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            try
            {
                int result = testFunction.Add(106, maxIntValue);
            }
            catch (OverflowException exception)
            {
                // Assert
                exception.Should().NotBeNull();
            }
        }
        #endregion


        #region Subtraction Tests
        [Test]
        public void Can_subtract_integers()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            int result = testFunction.Subtract(15, 2);

            //Assert
            result.Should().Be(13);
            TestDebugReporter.ReportedMessages.First().Should().Contain("Calculator called Subtract method.");
        }

        [Test]
        public void Can_subtract_negative_integers()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            int result = testFunction.Subtract(8, -5);

            //Assert
            result.Should().Be(13);
            TestDebugReporter.ReportedMessages.First().Should().Contain("Calculator called Subtract method.");
        }

        [Test]
        public void Can_return_error_if_subtract_exceeds_min_value()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            try
            {
                int result = testFunction.Subtract(-106, maxIntValue);
            }
            catch (OverflowException exception)
            {
                // Assert
                exception.Should().NotBeNull();
            }
        }

        [Test]
        public void Can_return_error_if_subtract_exceeds_max_value()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            try
            {
                int result = testFunction.Subtract(5, -maxIntValue);
            }
            catch (OverflowException exception)
            {
                // Assert
                exception.Should().NotBeNull();
            }
        }
        #endregion


        #region Multiplication Tests
        [Test]
        public void Can_multiply_integers()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            int result = testFunction.Multiply(8, 5);

            //Assert
            result.Should().Be(40);
            TestDebugReporter.ReportedMessages.First().Should().Contain("Calculator called Multiply method.");
        }

        [Test]
        public void Can_multiply_negative_integer()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            int result = testFunction.Multiply(8, -5);

            //Assert
            result.Should().Be(-40);
            TestDebugReporter.ReportedMessages.First().Should().Contain("Calculator called Multiply method.");
        }

        [Test]
        public void Can_return_error_if_multiply_exceeds_min_value()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            try
            {
                int result = testFunction.Multiply(2, -maxIntValue);
            }
            catch (OverflowException exception)
            {
                // Assert
                exception.Should().NotBeNull();
            }
        }

        [Test]
        public void Can_return_error_if_multiply_exceeds_max_value()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            try
            {
                int result = testFunction.Multiply(2, maxIntValue);
            }
            catch (OverflowException exception)
            {
                // Assert
                exception.Should().NotBeNull();
            }
        }
        #endregion


        #region Division Tests
        [Test]
        public void Can_divide_integers()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            float result = testFunction.Divide(20, 5);

            //Assert
            result.Should().Be(4);
            TestDebugReporter.ReportedMessages.First().Should().Contain("Calculator called Divide method.");
        }

        [Test]
        public void Can_divide_negative_integer()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            float result = testFunction.Divide(20, -5);

            //Assert
            result.Should().Be(-4);
            TestDebugReporter.ReportedMessages.First().Should().Contain("Calculator called Divide method.");
        }
        #endregion


        #region Prime Tests
        [Test]
        public void Can_get_prime()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            int result = testFunction.GetPrimeNumber(3);

            //Assert
            result.Should().Be(5);
            TestDebugReporter.ReportedMessages.First().Should().Contain("Calculator called Get Prime method.");
        }

        [Test]
        public void Can_return_error_with_unsuitable_index()
        {
            // Arrange
            SimpleCalculator testFunction = new SimpleCalculator(TestDebugReporter);

            //Act
            try
            {
                int result = testFunction.GetPrimeNumber(-3);
            }
            catch (CalculatorException exception)
            {
                // Assert
                exception.Should().NotBeNull();
                exception.Message.Should().Contain("index must be > 0");
            }
        }
        #endregion
    }
}
