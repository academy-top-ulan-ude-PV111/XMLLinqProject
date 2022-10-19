using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLLinqProject
{
    internal class SaveLoadXml
    {
        public static void Run()
        {
            //User user = new() 
            //{ 
            //    Name = "Joe", 
            //    Age = 34, 
            //    City = "Moscow", 
            //    State = "Member" 
            //};
            //User user2 = new()
            //{
            //    Name = "Tim",
            //    Age = 25,
            //    City = "St Peterburg",
            //    State = "Admin"
            //};

            //XDocument document = new XDocument(new XElement("Users",
            //    new XElement(nameof(User),
            //        new XAttribute(nameof(User.State), user.State),
            //        new XElement(nameof(User.Name), user.Name),
            //        new XElement(nameof(User.Age), user.Age),
            //        new XElement(nameof(User.City), user.City)),
            //    new XElement(nameof(User),
            //        new XAttribute(nameof(User.State), user2.State),
            //        new XElement(nameof(User.Name), user2.Name),
            //        new XElement(nameof(User.Age), user2.Age),
            //        new XElement(nameof(User.City), user2.City))
            //    ));

            //document.Save("users2.xml");
            //Console.WriteLine(document);

            //XElement element = new("Skill",
            //    new XComment("Comment for skills"),
            //    new XElement("web", "javascript"),
            //    new XElement("system", "c++"));
            //Console.WriteLine(element);

            XDocument document = XDocument.Load("users2.xml");

            //Console.WriteLine(document);
            XElement root = document.Root;

            //Console.WriteLine(root);
            foreach (var item in root.Elements())
            {
                Console.WriteLine("Attributes:");
                foreach (var attr in item.Attributes())
                    Console.WriteLine($"\t{attr.Name} -> {attr.Value}");
                Console.WriteLine("Elements:");
                foreach (var elem in item.Elements())
                    Console.WriteLine($"\t{elem.Name} -> {elem.Value}");
                Console.WriteLine(new String('-', 20));
            }
        }
    }
}
