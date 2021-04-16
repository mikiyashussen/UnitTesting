using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEqnRootsCal.UnitTest
{
    [TestFixture]
    class QuaraticEqnTests
    {

        [Test]
        public void RootsCalculator_HasTwoRoots_ReturnsTwoRoots()
        {
            // Assign
            var quadraticEqn = new QuadraticEqn(1, 3, 2);


            // Act
            List<double> result;
            result = quadraticEqn.RootsCalculator();

            // Assert
            Assert.That(result[0] == -1);
            Assert.That(result[1] == -2);
        }

        [Test]
        public void RootsCalculator_HasOneRoot_ReturnsOneRoot()
        {
            // Assign
            var quadraticEqn = new QuadraticEqn(1, 4, 4);

            // Act
            List<double> result;
            result = quadraticEqn.RootsCalculator();

            // Assert
            Assert.That(result[0] == -2);
        }

        [Test]
        public void RootsCalculator_HasNoRoots_ReturnsNoRoot()
        {
            // Assign
            var quadraticEqn = new QuadraticEqn(1, 2, 4);

            // Act
            List<double> result;
            result = quadraticEqn.RootsCalculator();

            // Assert
            Assert.That(result[0] == 0);
        }
    }
}
