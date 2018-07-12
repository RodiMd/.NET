// Assignment3
// CSCI 718
// 2/26/1018
// Rodi Murad

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    [TestFixture]
    public class Time2NUnitTest
    {

        [TestCase]
        public void PositiveHourTest()
        {
            Time2 hr = new Time2(20, 59, 59);
            Assert.AreEqual(20, hr.Hour);
            Time2 hr2 = new Time2(20, 59, 59);
            Assert.AreNotEqual(24, hr2.Hour);
        }

        [TestCase]
        public void NegativeHourTest()
        {


            try
            {
                Time2 hr = new Time2(24, 59, 59);
            }
            catch (System.Exception)
            { }
            finally { Console.WriteLine("out of range"); }
            
        }

        [TestCase]
        public void PositiveMinuteTest()
        {
            Time2 mnt = new Time2(2, 59, 59);
            Assert.AreEqual(59, mnt.Minute);
            Time2 mnt2 = new Time2(2, 59, 59);
            Assert.AreNotEqual(50, mnt2.Minute);
        }

        [TestCase]
        public void NegativeMinuteTest()
        {
            try
            {
                Time2 mnt = new Time2(2, -1, 59);
            }
            catch (System.Exception)
            { }
            finally { 
            Console.WriteLine("out of range"); }
        }

        [TestCase]
        public void PositiveSecondTest()
        {
            Time2 scnd = new Time2(0, 29, 58);
            Assert.AreEqual(58, scnd.Second);
            Time2 scnd2 = new Time2(0, 29, 58);
            Assert.AreNotEqual(50, scnd2.Second);
        }

        [TestCase]
        public void NegativeSecondTest()
        {
            try
            {
                Time2 scnd = new Time2(0, 29, -1);
            }
            catch (System.Exception)
            { }
            finally { 
            Console.WriteLine("out of range"); }
        }
        
        [TestCase]
        public void StringFormatTest()
        {
            Time2 strgFormat = new Time2(20, 35, 59);
            string strgFormatCopy = "20:35:59";
            Assert.AreEqual(strgFormatCopy, strgFormat.ToUniversalString());
        }

        [TestCase]
        public void StringFormatTest2()
        {
            Time2 strgFormat = new Time2(20, 35, 59);
            string strgFormatCopy = "20:35:590";
            Assert.AreNotEqual(strgFormatCopy, strgFormat.ToUniversalString());
        }

        [TestCase]
        public void ToStringTest()
        {
            Time2 strgFormat = new Time2(9, 35, 59);
            string strgFormatCopy = "9:35:59 AM";
            Assert.AreEqual(strgFormatCopy, strgFormat.ToString());
        }

        [TestCase]
        public void NegativeToStringTest()
        {
            Time2 strgFormat = new Time2(9, 35, 59);
            string strgFormatCopy = "9:35:59 PM";
            Assert.AreNotEqual(strgFormatCopy, strgFormat.ToString());
        }

        [TestCase]
        public void ToStringTest2()
        {
            Time2 strgFormat = new Time2(13, 35, 59);
            string strgFormatCopy = "13:35:59";
            Assert.AreEqual(strgFormatCopy, strgFormat.ToUniversalString());
        }

        [TestCase]
        public void NegativeToStringTest2()
        {
            Time2 strgFormat = new Time2(13, 35, 59);
            string strgFormatCopy = "13:35:59 AM";
            Assert.AreNotEqual(strgFormatCopy, strgFormat.ToUniversalString());
        }

    }
}
