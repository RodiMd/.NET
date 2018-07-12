// Assignement3
// CSCI 718
// 2/26/2018
// Rodi Murad

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    [TestFixture]
    public class EmployeeNUnitTest
    {
        [Test]
        public void grossSaleOutOfRangeTest()
        {
            CommissionEmployee gS =
                    new CommissionEmployee("John", "Doe", "123", 1, 0.5m);
            Assert.AreEqual(1, gS.GrossSales);

            CommissionEmployee gS2 =
                new CommissionEmployee("John", "Doe", "123", 0, 0.5m);
            Assert.AreNotEqual(1, gS2.GrossSales);

            try
            {
                CommissionEmployee gS3 =
                    new CommissionEmployee("John", "Doe", "123", -1, 0.5m);
            }
            catch (System.ArgumentOutOfRangeException)
            { }
            finally {
                Console.WriteLine("out of range");
            }
        }

        [Test]
        public void GrossSaleTest()
        {
            CommissionEmployee gS = 
                new CommissionEmployee("John", "Doe", "123", 100, 0.5m);
            Assert.AreEqual(100, gS.GrossSales);
        }

        [Test]
        public void CommissionRateTest()
        {
            CommissionEmployee cR = 
                new CommissionEmployee("John", "Doe", "123", 100, 0.5m);
            Assert.AreEqual(0.5, cR.CommissionRate);
        }

        [Test]
        public void ExceptionCommissionRateTest()
        {

            CommissionEmployee cR =
                    new CommissionEmployee("John", "Doe", "123", 100, 0.5m);
            Assert.AreEqual(0.5, cR.CommissionRate);

            CommissionEmployee cR2 =
                    new CommissionEmployee("John", "Doe", "123", 100, 0.5m);
            Assert.AreNotEqual(0.6, cR2.CommissionRate);

            try
            {
                CommissionEmployee cR3 = 
                    new CommissionEmployee("John", "Doe", "123", 100, -0.5m);
            }
            catch (System.ArgumentOutOfRangeException)
            { }
            finally
            {
                Console.WriteLine("out of range");
            }

        }
        [Test]
        public void EarningsTest()
        {
            CommissionEmployee earn = 
                new CommissionEmployee("John", "Doe", "123", 100, 0.5m);
            Assert.AreEqual(50, earn.Earnings());
        }

        [Test]
        public void NegativeEarningTest()
        {
            CommissionEmployee earn = 
                new CommissionEmployee("John", "Doe", "123", 100, 0.5m);
            Assert.AreNotEqual(49, earn.Earnings());
        }

        [Test]
        public void ToStringTest()
        {
            CommissionEmployee tS = 
                new CommissionEmployee("John", "Doe", "123", 100, 0.5m);
            string cmprStrg = "commission employee: John Doe\n" +
                "social security number: 123\n" +
                "gross sales: $100.00\n" +
                "commission rate: 0.50";
            Assert.AreEqual(cmprStrg, tS.ToString());
        }

        //tests for the BasePlusCommissionEmployee
        [Test]
        public void BaseSalaryTest()
        {
            BasePlusCommissionEmployee bS = 
                new BasePlusCommissionEmployee("John", "Doe", "123", 100, 0.5m, 1000m);
            Assert.AreEqual(1000, bS.BaseSalary);
        }

        [Test]
        public void BaseSalaryExceptionTest()
        {
            BasePlusCommissionEmployee bS =
                    new BasePlusCommissionEmployee("John", "Doe", "123", 100, 0.5m, 1000m);
            Assert.AreEqual(1000, bS.BaseSalary);

            BasePlusCommissionEmployee bS2 =
                    new BasePlusCommissionEmployee("John", "Doe", "123", 100, 0.5m, 1000m);
            Assert.AreNotEqual(100, bS2.BaseSalary);

            try
            {
                BasePlusCommissionEmployee bS3 = 
                    new BasePlusCommissionEmployee("John", "Doe", "123", 100, 0.5m, -1000m);
            }
            catch(System.ArgumentOutOfRangeException)
            { }
            finally
            {
                Console.WriteLine("out of range");
            }
        }

        [Test]
        public void Earnings2Test()
        {
            BasePlusCommissionEmployee bCS = new BasePlusCommissionEmployee
                ("John", "Doe", "123", 500, 0.5m, 1000m);
            Assert.AreEqual(1250, bCS.Earnings());
        }

        [Test]
        public void NegativeEarnBaseComTest()
        {
            BasePlusCommissionEmployee bCS = new BasePlusCommissionEmployee
                ("John", "Doe", "123", 500, 0.5m, 1000m);
            Assert.AreNotEqual(1500, bCS.Earnings());
        }

        [Test]
        public void BaseCommToString()
        {
            BasePlusCommissionEmployee bCTS = new BasePlusCommissionEmployee
                ("John", "Doe", "123", 500, 0.5m, 1000m);
            string stringCompare = "base-salaried commission employee: John Doe\n" +
                "social security number: 123\ngross sales: $500.00\n" +
                "commission rate: 0.50\nbase salary: $1,000.00";
            Assert.AreEqual(stringCompare, bCTS.ToString());
        }
    }
}
