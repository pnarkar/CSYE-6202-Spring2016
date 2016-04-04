using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PayrollSystem.Tests
{
    [TestFixture]
    public class RunningPayrollTests
    {

        [Test]
        public void EmployeeTypeIsNull_ResultShouldBeFalse()
        {
            //prepare
            var expected = false;
            //action
            var actual = Program.ValidEmployee("");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void NameIsNull_ResultShouldBeFalse()
        {
            //prepare
            var expected = false;
            //action
            var actual = Program.ValidName("");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void SalariedEmployee_ResultShouldBeTrue()
        {
            //prepare
            var expected = true;
            //action
            var actual = Program.ValidEmployee("SE");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void InvalidUserType_ResultShouldBeFalse()
        {
            //prepare
            var expected = false;
            //action
            var actual = Program.ValidEmployee("RHYT");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }


        [Test]
        public void HourlyEmployee_ResultShouldBeTrue()
        {
            //prepare
            var expected = true;
            //action
            var actual = Program.ValidEmployee("HE");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void CommissionEmployee_ResultShouldBeTrue()
        {
            //prepare
            var expected = true;
            //action
            var actual = Program.ValidEmployee("CE");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void SalaryBasedCommissionEmployee_ResultShouldBeTrue()
        {
            //prepare
            var expected = true;
            //action
            var actual = Program.ValidEmployee("BSCE");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
       
       
        [Test]
        public void EnteredIncorrectNameType_ResultShouldBeFalse()
        {
            //prepare
            var expected = false;
            //action
            var actual = Program.ValidName("1234");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_UserEnteredSSNValue_ResultShouldBeTrue()
        {
            //prepare
            var expected = true;
            //action
            var actual = Program.ValidSSN("123-45-6789");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        
       

        [Test]
        public void When_IncorrectSSNValue_ResultShouldBeFalse()
        {
            //prepare
            var expected = false;
            //action
            var actual = Program.ValidSSN("0000-11-1111");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test, ExpectedException(typeof(NotSupportedException))]
        public void ExpectedExceptionTest()
        {
            throw new NotSupportedException();
        }

        [Test, Ignore]
        public void NotImplementedException()
        {
            throw new NotImplementedException();
        }
    }
}
