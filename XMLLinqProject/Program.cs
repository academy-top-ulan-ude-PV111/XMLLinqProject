using System.Xml;
using System.Xml.Linq;

class User
{
    public string? Name { set; get; }
    public int Age { set; get; }
    public string? City { set; get; }

    public string? State { set; get; }

}

namespace XMLLinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //XDocument document = new XDocument(new XElement("Users",
            //    new XElement(nameof(User),
            //        new XAttribute(nameof(User.State), "Member"),
            //        new XElement(nameof(User.Name), "Bob"),
            //        new XElement(nameof(User.Age), 45),
            //        new XElement(nameof(User.City), "Moscow")),
            //    new XElement(nameof(User),
            //        new XAttribute(nameof(User.State), "Admin"),
            //        new XElement(nameof(User.Name), "Joe"),
            //        new XElement(nameof(User.Age), 23),
            //        new XElement(nameof(User.City), "St Peterburg")),
            //    new XElement(nameof(User),
            //        new XAttribute(nameof(User.State), "Member"),
            //        new XElement(nameof(User.Name), "Sam"),
            //        new XElement(nameof(User.Age), 32),
            //        new XElement(nameof(User.City), "Moscow")),
            //    new XElement(nameof(User),
            //        new XAttribute(nameof(User.State), "Member"),
            //        new XElement(nameof(User.Name), "Tim"),
            //        new XElement(nameof(User.Age), 19),
            //        new XElement(nameof(User.City), "St Peterburg")),
            //    new XElement(nameof(User),
            //        new XAttribute(nameof(User.State), "Admin"),
            //        new XElement(nameof(User.Name), "Jim"),
            //        new XElement(nameof(User.Age), 38),
            //        new XElement(nameof(User.City), "Kazan"))
            //    ));

            //document.Save("users3.xml");

            //XDocument document = XDocument.Load("users3.xml");
            //XElement root = document.Root;

            //var usersMoscow = document.Root
            //                          .Elements()
            //                          //.Where(e => e.Element("City")?.Value == "Moscow")
            //                          .Where(e => e.Attribute("State")?.Value == "Admin")
            //                          .OrderBy(e => e.Element("Name")?.Value)
            //                          .Select(e => new
            //                          {
            //                              Name = e.Element("Name")?.Value,
            //                              Age = e.Element("Age")?.Value,
            //                              State = e.Attribute("State")?.Value
            //                          });

            //if(usersMoscow != null)
            //{
            //    foreach(var user in usersMoscow)
            //        Console.WriteLine($"User: {user.Name} {user.Age} {user.State}");
            //}

            //root.Add(new XElement(nameof(User),
            //            new XAttribute(nameof(User.State), "Member"),
            //            new XElement(nameof(User.Name), "Leo"),
            //            new XElement(nameof(User.Age), 28),
            //            new XElement(nameof(User.City), "Voroneg")));


            //var tim = root.Elements()
            //              .FirstOrDefault(e => e.Element("Name")?.Value == "Tim");

            //tim.AddAfterSelf(new XElement(nameof(User),
            //                    new XAttribute(nameof(User.State), "Member"),
            //                    new XElement(nameof(User.Name), "Mike"),
            //                    new XElement(nameof(User.Age), 47),
            //                    new XElement(nameof(User.City), "Pskov")));

            //tim.AddBeforeSelf(new XElement(nameof(User),
            //                    new XAttribute(nameof(User.State), "Admin"),
            //                    new XElement(nameof(User.Name), "Philip"),
            //                    new XElement(nameof(User.Age), 25),
            //                    new XElement(nameof(User.City), "Ryazan")));

            //tim.Add(new XElement("Phone", "+7-999-123-45-67"));


            //var phill = root?.Elements()
            //              .FirstOrDefault(e => e.Element("Name")?.Value == "Philip");

            //phill!.Attribute("State")!.Value = "Member";
            //phill!.Element("Name")!.Value = "Phillip";

            //root?.Elements()?.FirstOrDefault(e => e.Element("Name")?.Value == "Phillip")?.Remove();

            //Console.WriteLine(document);
            //document.Save("users3.xml");


        }
    }
}