﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simple.Data.Test
{
    [TestClass]
    public class DynamicStringExtensionsTest
    {
        [TestMethod]
        public void PascalToSnakeTest()
        {
            var actual = "NameAndPostcode".ToSnakeCase();
            Assert.AreEqual("name_and_postcode", actual, "Snake case incorrect.");
        }
    }
}
