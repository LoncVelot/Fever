using Shifr;

namespace TestProject1
{
    public class TestShifr
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string key = "ABC";
            string text = "HELLO";
            string expected = "HFNLP";
            var code = new Code().Encode(text, key);
            Assert.AreEqual(expected, code);
        }

        [Test]
        public void Test2()
        {
            string key = "SAINT";
            string text = "3A24X5T";
            string expected = "LAURENT";
            var code = new Code().Decode(text, key);
            Assert.AreEqual(expected, code);
        }

        [Test]
        public void Test3()
        {
            string key = "129";
            string text = "MARK2";
            string expected = "C2PAT";
            var code = new Code().Encode(text, key);
            Assert.AreEqual(expected, code);
        }

        [Test]
        public void Test4()
        {
            string key = "LIPSI HA";
            string text = "HAPPY DOG";
            string expected = "SI476PKOR";
            var code = new Code().Encode(text, key);
            Assert.AreEqual(expected, code);
        }
    }
}