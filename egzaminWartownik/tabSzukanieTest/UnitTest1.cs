using egzaminWartownik;

namespace tabSzukanieTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            var tab = new int[51];
            for (int i = 0; i < 51; i++)
                tab[i] = i;
            var oczekiwana = 7;
            var aktualna = TabWartownik.Szukanie(tab,7);
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}