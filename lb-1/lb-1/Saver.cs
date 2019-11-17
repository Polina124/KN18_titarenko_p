using System;
using System.Xml.Linq;

namespace lb_1
{
    class Saver
    {
        static public void SaveResult(double num)
        {
            Console.WriteLine("Сохранять результат? y/n");
            string user_input = Console.ReadLine();
            if (user_input == "y")
            {
                XDocument xdoc = new XDocument();
                XElement result = new XElement("result");
                XElement answer = new XElement("answer", num);
                XElement savedata = new XElement("savedata", DateTime.Now);
                result.Add(answer);
                result.Add(savedata);
                xdoc.Add(result);
                xdoc.Save("../../result.xml");
            }
        }
    }
}
