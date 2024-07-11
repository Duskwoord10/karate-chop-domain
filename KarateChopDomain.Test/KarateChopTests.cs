namespace KarateChopDomain.Tests
{
    [TestClass]
    public class KarateChopTests
    {
        [TestMethod]
        public void TestKarateChop_Empty()
        {
            Assert.AreEqual(-1, KarateChop.Chop(3, []));
        }

        [TestMethod]
        public void TestKarateChop_SingleNotFound()
        {
            Assert.AreEqual(-1, KarateChop.Chop(3, [1]));
        }

        [TestMethod]
        public void TestKarateChop_SingleFound()
        {
            Assert.AreEqual(0, KarateChop.Chop(1, [1]));
        }

        [TestMethod]
        public void TestKarateChop_MultipleFound()
        {
            Assert.AreEqual(0, KarateChop.Chop(1, [1, 3, 5]));
            Assert.AreEqual(1, KarateChop.Chop(3, [1, 3, 5]));
            Assert.AreEqual(2, KarateChop.Chop(5, [1, 3, 5]));
        }

        [TestMethod]
        public void TestKarateChop_MultipleNotFound()
        {
            Assert.AreEqual(-1, KarateChop.Chop(0, [1, 3, 5]));
            Assert.AreEqual(-1, KarateChop.Chop(2, [1, 3, 5]));
            Assert.AreEqual(-1, KarateChop.Chop(4, [1, 3, 5]));
            Assert.AreEqual(-1, KarateChop.Chop(6, [1, 3, 5]));
        }

        [TestMethod]
        public void TestKarateChop_LargerListFound()
        {
            Assert.AreEqual(0, KarateChop.Chop(1, [1, 3, 5, 7]));
            Assert.AreEqual(1, KarateChop.Chop(3, [1, 3, 5, 7]));
            Assert.AreEqual(2, KarateChop.Chop(5, [1, 3, 5, 7]));
            Assert.AreEqual(3, KarateChop.Chop(7, [1, 3, 5, 7]));
        }
    }
}