using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldmMan
{
    class Program
    {
        static void Main(string[] args)
        {

            //string h = "GGeeJJrrr";
            //// Console.WriteLine();

            ////getNonRepeatative("kirti");
            //   getstr(h);

            //string inr = "left  right  right left right up up down";
            //var co = GetCoordinate(inr);


            List<PersonDetails> phoneBook = new List<PersonDetails>{
      new PersonDetails(){Name="Kirt",Number=89766},
        new PersonDetails(){Name="Ke",Number=866},
        new PersonDetails(){Name="deepak",Number=89766},
        new PersonDetails(){Name="ki",Number=89766},
        new PersonDetails(){Name="juu",Number=89766},
        new PersonDetails(){Name="abhi",Number=89766}
    };

            phoneBook.Sort();

           var j= SearchNumber(phoneBook, "ki");
            Console.WriteLine(j);
        }

        static long SearchNumber(List<PersonDetails> phoneBook, string name)
        {
            long min = 0; long max = phoneBook.Count();

            int mid = 0;
            while (min <= max) 
            {
                mid =(int) (min + max) / 2;

                if (name.CompareTo(phoneBook[mid].Name)>0)
                {

                    min = mid + 1;
                }
                else if (name.CompareTo(phoneBook[mid].Name)<0)
                {
                    max = mid - 1;
                }
                else if (name == phoneBook[mid].Name)
                {
                    return phoneBook[mid].Number;
                }
            } 
            return 000000000;

        }
        class PersonDetails : IComparer<PersonDetails>,IComparable<PersonDetails>
        {
            public string Name { set; get; }

            public long Number { get; set; }


            public int Compare(PersonDetails obj1, PersonDetails obj2)
            {
                return (obj1.Name).CompareTo(obj2.Name);

            }

            public int CompareTo(PersonDetails other)
            {
                return this.Name.CompareTo(other.Name);
            }
        }

        private static void getstr(string str)
        {
            //var res = new StringBuilder();
            //var instance = 1;
            //for (int i = 0 ,j=i+1; j < str.Length; i++,j++)
            //{
            //    var cur = str[i];
            //    char next = str[j];

            //    if( cur.Equals(next))
            //    {
            //        ++instance;
            //    }
            //    else
            //    {

            //        res = res.Append(instance + cur.ToString());
            //        instance = 1;
            //    }
            //}


            numbercompare c = new numbercompare();
            List<string> j = new List<string>() { "4", "6", "7", "34", "56" };
            SortedSet<string> s = new SortedSet<string>(c);
            s.Add("4");
            s.Add("6");
            s.Add("7");
            s.Add("34");
            s.Add("56");

            SortedSet<long> set = new SortedSet<long>(new TestCompare());
            set.Add(9);
            set.Add(1);
            set.Add(6);
            set.Add(0);
            set.Add(8);
            set.Add(10);
            set.Add(16);
            set.Add(5);


            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            j.Sort(0,j.Count(),c);

            //j.Sort();
            string rres = "";
            foreach (var item in j)
            {
                rres += item;
            }

            Console.WriteLine(rres); ;
            //return res.ToString();
        }

     
        public class numbercompare:IComparer<string>
        {
            public int Compare(string x, string y)
            {

                return (x + y).CompareTo(y + y);
            }

        }

        public class TestCompare : IComparer<long>
        {
            public int Compare(long x, long y)
            {
                return y.CompareTo(x);
            }
        }


        public struct Car    
        {
            public int start;
            public int end;
            public int rent;


        }

        class intervalcomparator :IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                throw new NotImplementedException();
            }

            

            bool JobComaperator(Car a, Car b)
            {
                return (a.end > b.end);
            }
        }


        //static void GetCar(List<Car> arr)
        //{
        //  arr.Sort(0,arr.Count,JobComaperator)
        //}
            
        static int getNonRepeatative(string str)
        {
            int[] chararr = new int[26];
            int[] indexarr = new int[26];
            indexarr = Enumerable.Repeat(-1, 26).ToArray();

            for (int i = 0; i < str.Length; i++)
            {
                int index = (int)(str[i] - 97);
                chararr[index]++;
                indexarr[index] = i;

            }

            int result = 32672;

            for (int i = 0; i < 26; i++)
            {
                if (chararr[i] == 1)
                {
                    result = result < indexarr[i] ? result : indexarr[i];
                }
            }
            return result;
        }

        struct COordinates
        {
            public int x;
            public int y;
        }

        static COordinates GetCoordinate(string instruction)
        {

            List<string> instrlist = new List<String>();
            COordinates original;
            original.x = 0;
            original.y = 0;
        instrlist = instruction.Split(' ').ToList();
            foreach (var i in instrlist)
            {
                switch (i)
                {
                    case "left":
                        var j = --original.x;
                        original.x = j;
                        break;
                    case "right":
                        original.x = ++original.x;
                        break;
                    case "up":
                        original.y = ++original.y;


                        break;
                    case "down":
                        original.y = --original.y;
                        break;
                }

            }

            return original;
    }

}
}
