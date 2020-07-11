using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcoloMisteriosoMetodo;

namespace CalcoloMisteriosoTest
{
    [TestClass]
    public class CalcoloTest
    {
        [TestMethod]
        public void TestMisterioso()
        {
            double[] v = new double[] { 1.2, 3.2, 4.3 };
            double s = Calcolo.CalcoloMisterioso(v);
            double somma = 8.7;
            Assert.AreEqual(somma, s);
        }

        [DataTestMethod]
        [DataRow(new double[]{1.2, 3.2, 4.3}, 8.7)]
        [DataRow(new double[] { 1.4, 3.8, 4 }, 9.2)]
        public void DataTestMisterioso(double[] v, double somma)
        {
            double s = Calcolo.CalcoloMisterioso(v);
            Assert.AreEqual(somma, s);
        }
    }
}
