using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zuci.Common;

namespace Zuci.CommonTests
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //--Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //--Act
            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //--Act
            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
