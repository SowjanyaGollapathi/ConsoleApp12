using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace ConsoleApp12
{
    class Program
    {
        
        private static void LINQReadXML()
        {
            string myXML = @"<Departments>
                           <Department>Account</Department>
                           <Department>Sales</Department>
                           <Department>Pre-Sales</Department>
                           <Department>Marketing</Department>
                           </Department>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);
            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }
            Console.WriteLine("\npress any key to continue.");
            Console.ReadLine();
            
        }
    }
}
