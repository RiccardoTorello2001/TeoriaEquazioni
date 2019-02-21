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
        public void Testnotdet()
        {
            double a = 0;
            double b = 0;
            bool asp = true;
            bool ott = Equazioni.IsnotDetermined(a,b);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void Testnotdet1()
        {
            double a = 0;
            double b = 7;
            bool asp = false;
            bool ott = Equazioni.IsnotDetermined(a, b);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void Testnotdet2()
        {
            double a = 3;
            double b = 3;
            bool asp = false;
            bool ott = Equazioni.IsnotDetermined(a, b);

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
        [TestMethod]
        public void TestDelta1()
        {
            double a = 7;
            double b = 3;
            double c = 4;
            double asp = -103;
            double ott = Equazioni.Delta(a,b,c);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void TestDelta2()
        {
            double a = 3;
            double b = 9;
            double c = 2;
            double asp = 57;
            double ott = Equazioni.Delta(a, b, c);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void TestEquationDegree2()
        {
            double a = 3;
            double b = 9;
            string asp = "3";
            string ott = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void TestEquationDegree3()
        {
            double a = 0;
            double b = 0;
            string asp = "indeterminato";
            string ott = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void TestEquationDegree4()
        {
            double a = 0;
            double b = 2;
            string asp = "impossibile";
            string ott = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void TestEquationDegree5()
        {
            double a = 0;
            double b = 0;
            double c = 3;
            string asp = "indeterminato";
            string ott = Equazioni.EquationDegree2(a,b,c);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void TestEquationDegree6()
        {
            double a = 4;
            double b = 5;
            double c = 5;
            string asp = "impossibile";
            string ott = Equazioni.EquationDegree2(a, b, c);

            Assert.AreEqual(asp, ott);

        }
        [TestMethod]
        public void TestEquationDegree7()
        {
            double a = 1;
            double b = 5;
            double c = -14;
            string asp = "2 e -7";
            string ott = Equazioni.EquationDegree2(a, b, c);

            Assert.AreEqual(asp, ott);

        }
    }
}
