using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "I have a transportation device which is a red bike which I love to ride.";
            string[] parts = s.Split(' ');
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (string part in parts.Distinct().ToList())
            {
                words.Add(part, parts.Count(x=>x==part));
            }

            string s1= "", s2= "";
            foreach (string key in words.Keys)
            {
                if (s1 == "")
                {
                    s1 = "List: ";
                }
                else
                {
                    s1 += ", ";
                }
                s1 += $"\"{key}, {words[key]} \"";
            }
            Console.WriteLine(s1);

            words.Clear();
            foreach (string part in parts.Distinct().ToList())
            {
                words.Add(part, part.Length);
            }
            List<int> ls = words.Select(x => x.Value).ToList();
            foreach (int i in words.Select(x => x.Value).Distinct().OrderBy(x=>x))
            {
                if (s2 == "")
                {
                    s2 = "List: ";
                }
                else
                {
                    s2 += ", ";
                }
                s2 += $"\"{i}, {ls.Count(x=>x==i)} \"";
            }

            Console.WriteLine(s2);
        }
    }
}
