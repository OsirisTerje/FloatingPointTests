using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary31
{
    public class VerifyDoubleEquality
    {
        [Test]
        public void ThisOneShouldWork()
        {
            int i = 5;
            double d = 5;
            var d1 = d/1.23456789123456789;
            var d2 = d1*1.23456789123456789;

            Assert.That(i,Is.EqualTo(d2),$"{d2} is not equal to {i}");
        }

        [Test]
        public void ThisOneShouldWork2()
        {
            double i = 0.5;
            double d = 0.5;
            var d1 = Math.Sin(d);
            var d2 = Math.Asin(d1); 

            Assert.That(i, Is.EqualTo(d2), $"{d2} is not equal to {i}");
        }

        [Test]
        public void ThisOneShouldWork21()
        {
            double result = 0;
            double d = 1/5d;
            var d1 = Math.Sin(d);
            var d2 = Math.Sin(-d);
            var d3 = d1 + d2;

            Assert.That(d3, Is.EqualTo(0), $"{d3} is not equal to {result}");
        }

        [Test]
        public void ThisOneShouldWork22()
        {
            double result = 0;
            double d = 1 / 5d;
            var d1 = 2*Math.Sin(d)*Math.Cos(d)-2*Math.Cos(d)*Math.Sin(d);
            

            Assert.That(d1, Is.EqualTo(0), $"{d1} is not equal to {result}");
        }


        [TestCase(1d / 3)]
        [TestCase(0.6111)]
        [TestCase(0.6113)]
        [TestCase(1d/5)]
        [TestCase(0.4365)]
        public void ThisOneShouldWork23(double d)
        {
            double expected = 1.0d;
            var d1 = Math.Sin(d) * Math.Sin(d) + Math.Cos(d) * Math.Cos(d);


            Assert.That(d1, Is.EqualTo(expected), $"{d1} is not equal to {expected}");
        }



        [Test]
        public void ThisOneShouldWork7()
        {

            double d = 1.0;
            var d1 = 1.0 / 6.0;
            var d2 = d1 + d1 + d1 + d1 + d1 + d1;

            Assert.That(d2, Is.EqualTo(d), $"{d2} is not equal to {d}");
        }


        [TestCase(43.01, 61.10, 104.11)]
        [TestCase(43.00, 61.00, 104.00)]
        [TestCase(43.65, 61.11,104.76)]
        [TestCase(43.66, 61.12, 104.78)]
        public void ThisOneShouldWork10(double d1,double d2,double expected)
        {
           double d3 = d1 + d2;
           
            Assert.That(d3, Is.EqualTo(expected), $"{d3} is not equal to {expected}");
        }

        [Test]
        public void ThisOneShouldWork11()
        {
            double expected = 104.76;
            int i = 10476;
            double d = i/100d;

            Assert.That(d, Is.EqualTo(expected), $"{d} is not equal to {expected}");
        }



        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(42)]
        public void ThisOneShouldWork8(int i)
        {

            double d = 1.0;
            var d1 = 1.0/i;
            double d2 = 0;
            for (int j = 0; j < i; j++)
            {
                d2 += d1;
            }
            

            Assert.That(d, Is.EqualTo(d2), $"{d2} is not equal to {d}");
        }


        [Test]
        public void ThisOneShouldWork5()
        {

            double d = 1.0;
            var d1 = 1.0 / 6.0;
            var d2 = d1*6;

            Assert.That(d, Is.EqualTo(d2), $"{d2} is not equal to {d}");
        }

        [Test]
        public void ThisOneShouldWork4()
        {
            double d1 = -0.0;
            double d2 = +0.0;
            Assert.That(d1, Is.EqualTo(d2), $"{d2} is not equal to {d1}");
        }


        [Test]
        public void ThisOneShouldWork6()
        {

            double d1 = 0.1;
            double d2 = 0.3;
            double d3 = d1+d2;
            var d1s = String.Format($"{d1:G20}");
            var d2s = String.Format($"{d2:G20}");
            var d3s = String.Format($"{d3:G20}");

            var d1st = d1s.Substring(0, 6);
            var d2st = d2s.Substring(0, 6);
            var d3st = d3s.Substring(0, 6);

            Assert.That(d1st,Is.EqualTo("0.1000"),d1s);
            Assert.That(d3st, Is.EqualTo("0.4000"),d3s);
            Assert.That(d2st, Is.EqualTo("0.3000"),d2s);


        }
    }
}
