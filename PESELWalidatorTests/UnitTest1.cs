using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeselWalidator;

namespace PESELWalidatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumaKontrolna()
        {
            PESELWalidator pw = new PESELWalidator("01211301111");
            var suma = pw.SumaKontrolna();
            Assert.IsNotNull(suma);
            Assert.AreEqual(1, suma);
        }

        [TestMethod]
        public void TestSumaKontrolna_2()
        {
            PESELWalidator pw = new PESELWalidator("01211301111");
            var suma = pw.SumaKontrolna();
            Assert.AreEqual(1, suma);
        }

        [TestMethod]
        public void TestSumaKontrolna_3()
        {
            PESELWalidator pw = new PESELWalidator("01211301111");
            var suma = pw.SumaKontrolna();
            Assert.AreNotEqual(5, suma);
        }

        [TestMethod]
        public void TestPlec()
        {
            PESELWalidator pw = new PESELWalidator("01211301111");
            var plec = pw.Plec();
            Assert.AreEqual(plec, "Mezczyzna");
        }

        [TestMethod]
        public void TestPlec_2()
        {
            PESELWalidator pw = new PESELWalidator("72033012345");
            var plec = pw.Plec();
            Assert.AreEqual(plec, "Kobieta");
        }

        [TestMethod]
        public void TestDataUrodzenia()
        {
            PESELWalidator pw = new PESELWalidator("01211301111");
            var urodziny = pw.DataUrodzenia();
            Assert.AreEqual("012113", urodziny);
            Assert.AreNotEqual("990628", urodziny);
        }

        [TestMethod]
        public void TestDataUrodzenia_2()
        {
            PESELWalidator pw = new PESELWalidator("01211301111");
            var urodziny = pw.DataUrodzenia();
            Assert.AreNotEqual("912910", urodziny);
        }

        [TestMethod]
        public void TestSprawdzPesel()
        {
            PESELWalidator pw = new PESELWalidator("01211301111");
            var wyrazenie = pw.SprawdzPesel();
            Assert.AreEqual(true, wyrazenie);
        }

        [TestMethod]
        public void TestSprawdzPesel_2()
        {
            PESELWalidator pw = new PESELWalidator("niezlypesel");
            var wyrazenie = pw.SprawdzPesel();
            Assert.AreNotEqual(true, wyrazenie);
        }



    }
}