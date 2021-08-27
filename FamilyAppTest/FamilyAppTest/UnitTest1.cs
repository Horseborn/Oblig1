using NUnit.Framework;
using Oblig1;

namespace FamilyAppTest
{
    public class Tests
    {
        

        [Test]
        public void Test1()
        {
            var sverreMagnus = new Person { Id = 1, fName = "Sverre Magnus", birthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, fName = "Ingrid Alexandra", birthYear = 2004 };
            var haakon = new Person { Id = 3, fName = "Haakon Magnus", birthYear = 1973 };
            var harald = new Person { Id = 6, fName = "Harald", birthYear = 1937 };
            sverreMagnus.Father = haakon;
            ingridAlexandra.Father = haakon;
            haakon.Father = harald;

            var app = new FamilyApp(sverreMagnus, ingridAlexandra, haakon);
            var actualResponse = app.HandleCommand("vis 3");
            var expectedResponse = "Haakon Magnus (Id=3) Født: 1973 Far: Harald (Id=6)\n"
                                   + "  Barn:\n"
                                   + "    Sverre Magnus (Id=1) Født: 2005\n"
                                   + "    Ingrid Alexandra (Id=2) Født: 2004\n";
            Assert.AreEqual(expectedResponse, actualResponse);
        }
    }
    }
