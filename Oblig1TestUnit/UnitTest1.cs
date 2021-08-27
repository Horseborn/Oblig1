using NUnit.Framework;
using Oblig1;

namespace Oblig1TestUnit
{
    public class Tests
    {
        

        [Test]
        public void TestAllFields()
        {
            var p = new Person
            {
                Id = 17,
                fName = "Ola",
                lName = "Nordmann",
                birthYear = 2000,
                deathYear = 3000,
                Father = new Person() { Id = 23, fName = "Per" },
                Mother = new Person() { Id = 29, fName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) Born: 2000 Died: 3000 Father: Per (Id=23) Mother: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }



        [Test]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }


        [Test]
        public void TestSomeFields()
        {
            var p = new Person()
            {
                Id = 52,
                fName = "Sebastian",
                birthYear = 2100,
                   

            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Sebastian (Id=52) Born: 2100 ";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}