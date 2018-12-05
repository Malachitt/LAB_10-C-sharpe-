using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp10
{
	class Program
	{
		static void Main(string[] args)
		{
		//1
			Random x = new Random();
			int x1 = x.Next(0, 10);
			MySet set = new MySet(new ArrayList { x.Next(0, 10), x.Next(0, 10), x.Next(0, 10), x.Next(0, 10), x.Next(0, 10) });
			set.Add("строка");
			Console.WriteLine(set);
			Console.WriteLine(set.Find("строка"));
			set.Remove("строка");
			Console.WriteLine(set);
			Console.WriteLine(set.Set.Count + " : " + set);
			Console.WriteLine(set.Find("строка"));

		//2
			MySet1 mySet1 = new MySet1();
			mySet1.Add(1, "one");
			mySet1.Add(2, "two");
			mySet1.Add(3, "three");
			mySet1.Add(4, "four");
			mySet1.Add(5, "five");
			mySet1.Add(6, "six");
			MySet1 mySet2 = new MySet1();
			mySet2.Add(1, "one");
			mySet2.Add(2, "two");
			mySet2.Add(3, "three");
			mySet2.Add(4, "four");
			mySet2.Add(5, "five");
			mySet2.Add(6, "six");
			Console.WriteLine(mySet1);
			Console.WriteLine(mySet2);
			Console.WriteLine(mySet1.Find(3));
			mySet1.Remove(3);
			Console.WriteLine(mySet1);
			Console.WriteLine(mySet2);

			
			Console.ReadKey();
		}
	}
	class MySet
	{
		public ArrayList Set { get; set; }			//ArrayList
		public MySet()
		{
			Set = new ArrayList();
		}
		public MySet(ArrayList set)
		{
			Set = set;
		}
		public void Add(object s)			//Добавление
		{
			Set.Add(s);
		}
		public void Remove(object x)		//Удаление
		{
			Set.Remove(x);
		}
		public bool Find(object x)			//Поиск
		{
			bool z = false;
			foreach (object s in Set)
			{
				if (x == s)
				{
					z = true;
					break;
				}
				else z = false;
			}
			return z;
		}
		public override string ToString()	//Переопределение
		{
			string s = "";
			foreach (object x in Set)
				s += x + "; ";
			return s;
		}
	}
	class MySet1
	{
		public Dictionary<int, string> Set1 { get; set; }		//Dictionary
		public MySet1()
		{
			Set1 = new Dictionary<int, string>();
		}
		public MySet1(Dictionary<int, string> set1)
		{
			Set1 = set1;
		}
		public void Add(int x, string y)			//Добавление
		{
			Set1.Add(x, y);
		}
		public void Remove(int n)					//Удаление
		{

			for (; n < Set1.Count && n > 0; n--)
			{
				Set1.Remove(n - 1);			
			}
		}
		public bool Find(int x)					//Поиск
		{
			bool z = false;
			foreach (int x1 in Set1.Keys)
			{
				if (x == x1)
				{
					z = true;
					break;
				}
				else z = false;
			}
			return z;

		}
		public override string ToString()		//Переопределение
		{
			string s = "";
			foreach (int key in Set1.Keys)
				Console.Write("Ключ = " + key + " , значение = " + Set1[key] + "; ");
			return s;
		}
	}


}
