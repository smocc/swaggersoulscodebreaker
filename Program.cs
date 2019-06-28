using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Threading;

namespace swaggersoulsisgay
{
    public static class Program
    {
        static List<string> usedList = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("[SSIG]");
            Console.WriteLine("<$> Welcome, for all possible combinations press any key!");
            Console.ReadKey();
            FindCombo(new char[] { 'I', 'l' }, "", 30);
            Console.WriteLine($"<$> {usedList.Count} Possible combinations found!");
            Console.WriteLine("<$> Press any key to test every possible combination for a bit.ly http response that is not an error page!");
            Console.ReadKey();
            for (int i = 0; i < Directory.GetFiles(Environment.CurrentDirectory, "faggot").Length; i++)
                foreach (string s in File.ReadAllLines($"faggot{i}.txt"))
                    if (s.Length == 30)
                        if (PingPage(s))
                            Console.WriteLine($"<$> Found a URL that does not error -> http:\\\\bit.ly\\{s}");
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
        static int fag = 0;
        static void FindCombo(char[] set, string prefix, int k)
        {
            if (k == 0)
                return;
            if (usedList.Count >= 13333337) 
            {
                using (StreamWriter sw = new StreamWriter($"faggot{fag}.txt"))
                {
                    foreach (string s in usedList)
                        sw.WriteLine(s);
                }
                usedList.Clear();
                Console.WriteLine($"<$> List was too big, shortened and added to faggot{fag}.txt");
                fag++;
            }
            for (int i = 0; i < set.Length; ++i)
            {
                string newPrefix = prefix + set[i];
                usedList.Add(newPrefix);
                FindCombo(set, newPrefix, k - 1);
            }
        }
        static bool PingPage(string s)
        {
            try {
                WebRequest req = WebRequest.Create("http://bit.ly/" + s);
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                if (res == null || res.StatusCode != HttpStatusCode.OK)
                    return false;
                return true;
            } catch(Exception e) { if(!e.ToString().ToLower().Contains("403")) Console.WriteLine($"<$> There was an error > {e.Message}"); }
            return false;
        }
    }
}
