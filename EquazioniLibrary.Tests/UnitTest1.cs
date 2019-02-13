using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDet1()
        {
            double a = 3;
            bool asp = true;
            bool ott = Equazioni.IsDetermined(a);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void TestDet2()
        {
            double a = -3;
            bool asp = true;
            bool ott = Equazioni.IsDetermined(a);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void TestDet3()
        {
            double a = 0;
            bool asp = false;
            bool ott = Equazioni.IsDetermined(a);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void Testimp1()
        {
            double a = 0;
            double b = 0;
            bool asp = false;
            bool ott = Equazioni.Isinconsisted(a,b);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void Testimp2()
        {
            double a = 5;
            double b = 0;
            bool asp = false;
            bool ott = Equazioni.Isinconsisted(a, b);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void Testimp3()
        {
            double a = 5;
            double b = 5;
            bool asp = false;
            bool ott = Equazioni.Isinconsisted(a, b);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void Testimp4()
        {
            double a = 0;
            double b = 5;
            bool asp = true;
            bool ott = Equazioni.Isinconsisted(a, b);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void TestSec1()
        {
            double a = 6;
            bool asp = true;
            bool ott = Equazioni.IsDegree2(a);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void TestSec2()
        {
            double a = 0;
            bool asp = false;
            bool ott = Equazioni.IsDegree2(a);

            Assert.AreEqual(asp, ott);

        }
    }
}
