using System;
using DMUCars_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMUCarsTesting
{
    [TestClass]
    public class tstDMUCars
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsDMUCars ACar = new clsDMUCars();
            Assert.IsNotNull(ACar);
        }
    }
}
