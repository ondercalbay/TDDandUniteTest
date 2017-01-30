using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericList.Test;

namespace GenericList.Test
{
    [TestClass]
    public class Generic
    {
        GenericList<string> list { get; set; }

        [TestInitialize]
        public void InitializationTest()
        {
            list = new GenericList<string>();
            Assert.AreEqual(list.Count, 0, "Liste ilk yaratıldığında listenin eleman sayısı sıfır olmalıdır.");
        }

        [TestMethod]
        public void AddItemTest()
        {         
            list.AddItem("Yeni bir liste elemanı");
            Assert.AreEqual<int>(list.Count, 1, "Listenin eleman sayısı yeni bir eleman eklendiğinde bir artmalıdır.");
        }

        [TestMethod]
        public void RemoveItemIndexTest()
        {
            int beforeCount = list.Count;
            list.RemoveItem(0);
            Assert.AreEqual<int>(beforeCount - list.Count, 1, "Listenin eleman sayısı yeni bir eleman eklendiğinde bir azalmalıdır.");
        }
    }
}
