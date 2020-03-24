using System;
using System.Collections.Generic;
using System.IO;

namespace BullShitGenerater
{
    class Generate
    {
        public static string title { get; set; }
        static List<string> famous { get { return GetList(@"\data\famous_sc.txt"); } }
        static List<string> bosh { get { return GetList(@"\data\bosh_sc.txt"); } }
        static List<string> after { get { return GetList(@"\data\after_sc.txt"); } }
        static List<string> before { get { return GetList(@"\data\before_sc.txt"); } }
        static List<int> famous_l { get; set; } = new List<int>();
        static List<int> bosh_l { get; set; } = new List<int>();
        static List<int> after_l { get; set; } = new List<int>();
        static List<int> before_l { get; set; } = new List<int>();

        static List<string> GetList(string filename)
        {
            List<string> List = new List<string>();
            foreach (string Temp in File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + filename))
            {
                List.Add(Temp);
            }
            return List;
        }
        static string Getfamous(List<string> sourse, List<int> loop, int count)
        {
            Random random = new Random();
            string result = "";
            if (famous_l.Count == famous.Count)
            {
                famous_l = new List<int>();
            }
            while (true)
            {
                int r = random.Next(0, count);
                if (!famous_l.Contains(r))
                {
                    famous_l.Add(r);
                    result = famous[r];
                    break;
                }
            }
            return result;
        }
        public static string GenerateBody(int length)
        {
            int num;
            string body = "\r\n  ";
            Random random = new Random();
            while (body.Length < length)
            {
                num = random.Next(0, 100);
                if (num < 5)
                {
                    if (!body.EndsWith("\r\n  "))
                        body += "\r\n" + "\r\n  ";
                }
                else if (num < 20)
                    body += famous[random.Next(0, famous.Count)]
                        .Replace("a", before[random.Next(0, before.Count)])
                        .Replace("b", after[random.Next(0, after.Count)]);
                else
                    body += bosh[random.Next(0, bosh.Count)];
            }
            body = body.Replace("x", title);
            return body;
        }
    }
}
