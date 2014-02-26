using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BraviSoftware.RomanNumerals;

namespace BraviSoftware.RomanNumerals.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Convert_1_Returns_I()
        {
            Assert.AreEqual("I", Converter.Convert(1));
        }

        [TestMethod]
        public void Convert_2_Returns_II()
        {
            Assert.AreEqual("II", Converter.Convert(2));
        }

        [TestMethod]
        public void Convert_3_Returns_III()
        {
            Assert.AreEqual("III", Converter.Convert(3));
        }

        [TestMethod]
        public void Convert_4_Returns_IV()
        {
            Assert.AreEqual("IV", Converter.Convert(4));
        }

        [TestMethod]
        public void Convert_5_Returns_V()
        {
            Assert.AreEqual("V", Converter.Convert(5));
        }

        [TestMethod]
        public void Convert_6_Returns_VI()
        {
            Assert.AreEqual("VI", Converter.Convert(6));
        }

        [TestMethod]
        public void Convert_7_Returns_VII()
        {
            Assert.AreEqual("VII", Converter.Convert(7));
        }

        [TestMethod]
        public void Convert_8_Returns_VIII()
        {
            Assert.AreEqual("VIII", Converter.Convert(8));
        }

        [TestMethod]
        public void Convert_9_Returns_IX()
        {
            Assert.AreEqual("IX", Converter.Convert(9));
        }

        [TestMethod]
        public void Convert_10_Returns_X()
        {
            Assert.AreEqual("X", Converter.Convert(10));
        }

        [TestMethod]
        public void Convert_11_Returns_XI()
        {
            Assert.AreEqual("XI", Converter.Convert(11));
        }

        [TestMethod]
        public void Convert_12_Returns_XII()
        {
            Assert.AreEqual("XII", Converter.Convert(12));
        }

        [TestMethod]
        public void Convert_13_Returns_XIII()
        {
            Assert.AreEqual("XIII", Converter.Convert(13));
        }

        [TestMethod]
        public void Convert_14_Returns_XIV()
        {
            Assert.AreEqual("XIV", Converter.Convert(14));
        }

        [TestMethod]
        public void Convert_15_Returns_XV()
        {
            Assert.AreEqual("XV", Converter.Convert(15));
        }

        [TestMethod]
        public void Convert_16_Returns_XVI()
        {
            Assert.AreEqual("XVI", Converter.Convert(16));
        }

        [TestMethod]
        public void Convert_19_Returns_XIX()
        {
            Assert.AreEqual("XIX", Converter.Convert(19));
        }

        [TestMethod]
        public void Convert_34_Returns_XXXIV()
        {
            Assert.AreEqual("XXXIV", Converter.Convert(34));
        }

        [TestMethod]
        public void Convert_40_Returns_XL()
        {
            Assert.AreEqual("XL", Converter.Convert(40));
        }

        [TestMethod]
        public void Convert_44_Returns_XLIV()
        {
            Assert.AreEqual("XLIV", Converter.Convert(44));
        }

    }
}
