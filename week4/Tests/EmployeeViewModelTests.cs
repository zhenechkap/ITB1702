using System;
using System.Collections.Generic;
using System.Text;
using Core;
using Facade;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class EmployeeViewModelTests
    {
        private EmployeeViewModel o;
        [SetUp]
        public void SetUp()
        {
            o = new EmployeeViewModel(emp: null);
        }
        [Test]
        public void SalaryColorIsRedByDefaultTest()
        {
            Assert.AreEqual(expected: "red", actual: o.SalaryColor);
        }
        [Test]
        public void SalaryColorIsRedIfSetColorArgumentIsNullTest()
        {
            o.setColor(null);
            Assert.AreEqual("red", o.SalaryColor);
        }
        [Test]
        public void SalaryColorIsYellowForHighSalariesTest()
        {
            o.setColor(new Employee(null, null, 15001));
            Assert.AreEqual("yellow", o.SalaryColor);
        }
        [Test]
        public void SalaryColorIsGreenForSmallSalariesTest()
        {
            o.setColor(new Employee(null, null, 15000));
            Assert.AreEqual("green", o.SalaryColor);
        }
        [Test]
        public void SalaryIsZeroByDefaultTest()
        {
            Assert.AreEqual(expected: 0.ToString("C"),actual: o.Salary);
        }
        [Test]
        public void SalaryTest()
        {
            o.setSalary(new Employee(null, null, 100));
            Assert.AreEqual(100.ToString("C"), o.Salary);
        }
        [Test]
        public void EmployeeNameTest()
        {
            o.setName(new Employee("First", "Last", 0));
            Assert.AreEqual("First Last", o.EmployeeName);
        }
    }
}
