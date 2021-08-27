using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Lag klassen Person. En person skal ha fornavn, etternavn, fødselsår og dødsår. Alle feltene er frivillige.
// For eksempel skal du kunne legge inn en person selv om du ikke vet fødselsår.

//Klassen skal ha en metode GetDescription(). Testen under viser hva den metoden skal returnere om alle feltene er fylt ut.
//Lag et unit test prosjekt og legg til en klasse PersonTest, hvor du legger testene fra oppgaveteksten, men bare testene som tester klassen Person. 
// 


namespace Oblig1
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            

            var sverreMagnus = new Person { Id = 1, fName = "Sverre Magnus", birthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, fName = "Ingrid Alexandra", birthYear = 2004 };
            var haakon = new Person { Id = 3, fName = "Haakon Magnus", birthYear = 1973 };
            var metteMarit = new Person { Id = 4, fName = "Mette-Marit", birthYear = 1973 };
            var marius = new Person { Id = 5, fName = "Marius", lName = "Borg Høiby", birthYear = 1997 };
            var harald = new Person { Id = 6, fName = "Harald", birthYear = 1937 };
            var sonja = new Person { Id = 7, fName = "Sonja", birthYear = 1937 };
            var olav = new Person { Id = 8, fName = "Olav", birthYear = 1903 };

            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            //var app = new FamilyApp(sverreMagnus, ingridAlexandra, haakon,
            //    metteMarit, marius, harald, sonja, olav);
            //Console.WriteLine(app.WelcomeMessage);
            //while (true)
            //{
            //    Console.Write(app.CommandPrompt);
            //    var command = Console.ReadLine();
            //    var response = app.HandleCommand(command);
            //    Console.WriteLine(response);

            }


        




    }
}
