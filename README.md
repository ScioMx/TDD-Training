# Test Driven Development Training

Test-driven development (TDD) is a software development process that relies on the repetition of a very short development cycle: first the developer writes an (initially failing) automated test case that defines a desired improvement or new function, then produces the minimum amount of code to pass that test, and finally refactors the new code to acceptable standards.

## Instructions

Follow these instructions:

1. Read [this article](http://agiledata.org/essays/tdd.html) to get the theory behind this methodology.

2. Clone the repository.

3. Open the solution in Visual Studio.

4. Implement the tests (Each exercise is described [here](https://github.com/ScioMx/TDD-Training/wiki)).

5. Implement the code.

6. Push to your repository.

## Basics

      namespace Bank
      {
        using NUnit.Framework;
      
        [TestFixture]
        public class AccountTest
        {
          [Test]
          public void TransferFunds()
          {
            Account source = new Account();
            source.Deposit(200m);
            
            Account destination = new Account();
            destination.Deposit(150m);
      
            source.TransferFunds(destination, 100m);
      	  
            Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
          }
        }
       }

## About the exercises
These exercises comply with the following criteria:

- Can be implemented and tested in less than 10 minutes.
- Follows the Single Responsability Principle.
- Illustrates a common but interesting programming problem.
- The solution is well known.
