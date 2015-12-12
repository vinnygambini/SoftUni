using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        List<string> map = new List<string>();
        map = readNumber(int.Parse(Console.ReadLine()));
        List<int> mapWidth = new List<int>();
        mapWidth = checkArea(map);
        map = distinkt(map);
        Console.WriteLine(mapWidth.Max()); int i = 0;
        while (i++ < mapWidth.Max()) 
        { 
            Console.WriteLine(map[mapWidth.IndexOf(mapWidth.Max())]); 
        }
    }
        public static List<string> distinkt( List<string> l) 
        { 
        List<string> l1=new List<string>();
        l1.Add(l[0]);
        for (int i = 1; i < l.Count(); i++) 
        {
            if (l[i] != l[i - 1]) 
            {
                l1.Add(l[i]);
            }
        }

            return l1;
        }

        public static List<string> readNumber(int n)
        {
            List<string> list = new List<string>();
            while (list.Count < n) 
            { 
                list.Add(Console.ReadLine().ToString()); 
            }
            return list;
        }
        public static List<int> checkArea(List<string> list_)
        {
            List<int> listCount = new List<int>();
            List<string> listSign = new List<string>();
            int areaPosition=0;
            listCount.Add(1);
            listSign.Add(list_[0]);
            for (int i = 1; i < list_.Count; i++)
            {
                if (list_[i] == list_[i - 1]) {  listCount[areaPosition]++; }
                else
                {
                    listCount.Add(1); areaPosition++; listSign.Add(list_[i]);
                }
            }
            return listCount;
        }
    }
