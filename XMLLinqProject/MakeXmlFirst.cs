using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLLinqProject
{
    internal class MakeXmlFirst
    {
        public static void Run()
        {
            User user = new() { Name = "Joe", Age = 34, City = "Moscow", State = "Member" };

            XDocument xDocument = new XDocument();
            XElement rootDocument = new("Users");


            XElement userElement = new XElement(nameof(User));
            XAttribute userAttribute = new XAttribute(nameof(User.State), user.State);
            XElement nameElement = new(nameof(User.Name), user.Name);
            XElement ageElement = new(nameof(User.Age), user.Age);
            XElement cityElement = new(nameof(User.City), user.City);

            userElement.Add(userAttribute);
            userElement.Add(nameElement);
            userElement.Add(ageElement);
            userElement.Add(cityElement);

            rootDocument.Add(userElement);
            xDocument.Add(rootDocument);

            xDocument.Save("users1.xml");
        }
    }
}
