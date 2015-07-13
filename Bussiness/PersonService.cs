using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PersonService
    {
        

        public IList<Person> ReadAllPersons()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = new StringBuilder();
            string fileContent;

            using (StreamReader sr = new StreamReader(mydocpath + @"\AllTxtFiles.txt"))
            {
                fileContent = sr.ReadToEnd();
            }
            char[] splitter = { ';' };
            IList<string> personStringList = fileContent.Split(splitter);
            IList<Person> personList = new List<Person>();
            foreach (string personString in personStringList)
            {
                int space = personString.IndexOf(" ");
                if (space > 0)
                {
                    Person person = new Person();
                    person.FirstName = personString.Substring(space);
                    person.LastName = personString.Substring(0, space);
                    personList.Add(person);
                }
            }
            return personList;
        }

        public void Save(Person person)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(mydocpath + @"\AllTxtFiles.txt"))
            {
                sb.Append(sr.ReadToEnd());
                sb.Append(person.LastName + " " + person.FirstName);
                sb.Append(";");
            }

            using (StreamWriter outfile = new StreamWriter(mydocpath + @"\AllTxtFiles.txt"))
            {
                outfile.Write(sb.ToString());
            }
        }

        public void deletePerson(Person person)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = new StringBuilder();
            string fileContent;

            using (StreamReader sr = new StreamReader(mydocpath + @"\AllTxtFiles.txt"))
            {
                fileContent = sr.ReadToEnd();
            }
            char[] splitter = { ';' };
            IList<string> nameList = fileContent.Split(splitter);
            StringBuilder sbNew = new StringBuilder();
            foreach (string firstAndLastName in nameList)
            {
                if (!firstAndLastName.Equals(person.LastName + " " + person.FirstName))
                {
                    sb.Append(firstAndLastName);
                    sb.Append(";");
                }
            }

            using (StreamWriter outfile = new StreamWriter(mydocpath + @"\AllTxtFiles.txt"))
            {
                outfile.Write(sb.ToString());
            }
        }
    }
}
