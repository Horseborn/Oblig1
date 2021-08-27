using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1
{
   public class Person
    {
        public int Id;
        public string fName;
        public string lName;
        public int? birthYear;
        public int? deathYear;
        public Person Father;
        public Person Mother;
        private string ShowContent(string bef, object value , string aft)
        {
            if (value == null)
            {
                return "";

            }
            return  $"{bef}{value}{aft}";
            //if (deathYear == 0)
            //{
            //    return "";
            //}

            //if (birthYear == 0)
            //{
            //    return "";
            //}







            //if (birthYear || deathYear == 0)
            //{
            //    return "";
            //}
        }



        public string GetDescription()
        {
            string DescString =

                ShowContent("", fName, " ") +
                ShowContent("", lName, " ") +
                ShowContent("(Id=", Id, ")");
                
                
            if (birthYear != null)
            {
                DescString += 

                ShowContent(" Born: ", birthYear, " ");
            }

            if (deathYear != null)
            {
                DescString +=

                ShowContent("Died: ", deathYear, " ");
            }
            
            if (Father != null)
            {
                DescString +=

                    ShowContent("Father: ", Father.fName, " ") +

                    ShowContent("(Id=", Father.Id, ")");

            }

            if (Mother != null)
            {
                DescString +=
                    ShowContent(" Mother: ", Mother.fName, " ") +
                    ShowContent("(Id=", Mother.Id, ")");
            }

            return DescString;

        }

        //public string MakeProperString()
        //{
        //    string Str;


        //}


        













    }

    












}
