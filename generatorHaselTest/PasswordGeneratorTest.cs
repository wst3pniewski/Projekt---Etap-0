using generator_hasel;
namespace generatorHaselTest
{
    [TestClass]
    public class PasswordGeneratorTest
    {
        PasswordGenerator generator = new PasswordGenerator();

        [TestMethod]
        public void PasswordLengthTest()
        {
            Assert.AreEqual(10, generator.generatePassword(10, true, true, true, true).Length);
        }

        [TestMethod]
        public void GeneratePasswordAnyOptionSelectedTest()
        {
            Assert.ThrowsException<AnyCheckBoxSelectedException>(() => generator.generatePassword(10, false, false, false, false));
        }

        [TestMethod]
        public void GeneratePasswordWrongLengthTest()
        {
            Assert.ThrowsException<WrongPasswordLengthException>(() => generator.generatePassword(5, true, false, false, false));
        }

        [TestMethod]
        public void GeneratePasswordOnlyBigLettersTest()
        {
            List<Char> bigLetters = new List<Char>();
            for (char j = 'A'; j <= 'Z'; j++)
            {
                bigLetters.Add(j);
            }
            string passwd = generator.generatePassword(10, true, false, false, false);

            foreach (char c in passwd)
            {
                Assert.IsTrue(bigLetters.Contains(c));
            }
        }

        [TestMethod]
        public void GeneratePasswordOnlySmallLettersTest()
        {
            List<Char> smallLetters = new List<Char>();
            for (char j = 'a'; j <= 'z'; j++)
            {
                smallLetters.Add(j);
            }

            string passwd = generator.generatePassword(10, false, true, false, false);

            foreach (char c in passwd) 
            {
                Assert.IsTrue(smallLetters.Contains(c));
            }

        }

        [TestMethod]
        public void GeneratePasswordOnlyNumbersTest()
        {
            List<Char> numbers = new List<Char>();
            for (char j = '0'; j <= '9'; j++)
            {
                numbers.Add(j);
            }

            string passwd = generator.generatePassword(10, false, false, true, false);

            foreach (char c in passwd)
            {
                Assert.IsTrue(numbers.Contains(c));
            }
        }

        [TestMethod]
        public void GeneratePasswordOnlySpecialSignsTest() 
        {
            List<Char> specialSigns = new List<Char>();
            for (char s = '!'; s <= '/'; s++)
            {
                specialSigns.Add(s);
            }
            for (char s = ':'; s <= '@'; s++)
            {
                specialSigns.Add(s);
            }
            for (char s = '['; s <= '`'; s++)
            {
                specialSigns.Add(s);
            }
            for (char s = '{'; s <= '~'; s++)
            {
                specialSigns.Add(s);
            }

            string passwd = generator.generatePassword(10, false, false, false, true);

            foreach (char c in passwd)
            {
                Assert.IsTrue(specialSigns.Contains(c));
            }
        }

    }
}