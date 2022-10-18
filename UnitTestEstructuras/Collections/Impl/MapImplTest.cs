using Map.Impl;
using Map.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestEstructuras.Collections.Impl
{
    [TestClass]
    public class MapImplTest
    {
        [TestMethod]
        public void MapImpl_ShouldPutElementInMap()
        {
            IMap<string, string> testMap = new MapImpl<string, string>();

            testMap.Put("Vicente", "23");

            Assert.AreEqual("23", testMap.Get("Vicente"));
        }

        [DataTestMethod]
        [DataRow(true, "Vicente", "23", "Vicente")]
        [DataRow(true, "Michelle", "24", "Michelle")]
        [DataRow(false, "Michelle", "24", "Vicente")]
        public void MapImpl_ShouldGetElementFromMap_IfAvailable(
            bool expectIsAvailable,
            string key,
            string value,
            string keyToLookFor)
        {
            IMap<string, string> testMap = new MapImpl<string, string>();

            testMap.Put(key, value);
            var retrievedValue = testMap.Get(keyToLookFor);
            if (expectIsAvailable)
            {
                Assert.AreEqual(value, retrievedValue);
            }
            else
            {
                Assert.IsNull(retrievedValue);
            }
        }
    }
}
