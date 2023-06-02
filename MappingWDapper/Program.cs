using System;
using System.Collections.Generic;
using System.IO;
using File = System.IO.File;

namespace MappingWDapper
{
    public static class Program
    {
        public static string SqlConnectionStringDB1 = "";

        public static string SqlConnectionStringDB2 = "";

        static void Main(string[] args)
        {

            Init.Init_();


            var xx = DapperClass.ReadAll();


            Dictionary<string, bool> mem = new Dictionary<string, bool>();

            DirectoryInfo dif = new DirectoryInfo(File.ReadAllLines(@"C:\textNAme.txt")[0]);
            FileInfo[] fis = dif.GetFiles();
            foreach (FileInfo fi in fis)
            {
                List<listName> Listt = ListOrganizedClass.Start(fi);
                foreach (listName liststringName in Listt)
                {
                    string key = liststringName.Name_id;
                    bool isInMemory = mem.ContainsKey(key);
                    if (!isInMemory)
                    {
                        int v = DapperClass.Control1(liststringName);

                        if (v == 0)
                        {
                            DapperClass.Insert(liststringName);

                        }
                        else
                        {
                            mem.Add(key, true);
                        }
                    }
                }

            }

        }
    }
}