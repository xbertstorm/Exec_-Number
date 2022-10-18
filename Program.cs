using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec__Number
{
    internal class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Q1：判斷是否為質數");
			Q01();
			Console.WriteLine();
			Console.WriteLine("Q2：找出數值區間內的所有質數");
			Q02();
			Console.WriteLine();
			Console.WriteLine("Q3：有一四位數，左邊兩位數相同，右邊兩位數相同，此四位數恰好是某數的平方，尋找此數");
			Q03();
			Console.WriteLine();
			Console.WriteLine("Q4：百元買百雞");
			Q04();

			Console.Read();
		}
		private static void Q01()
		{

			Console.Write("請輸入一個數字：");
			string input = Console.ReadLine();
			int num1 = int.Parse(input);
			int num2 = (int)Math.Sqrt(num1);
			int count = 0;

			if (num1 < 2)
				Console.WriteLine($"{num1}不是質數。");
			else
			{
				if (num1 == 2)
					Console.WriteLine($"{num1}是質數。");
				else if (num1 % 2 == 0)
					Console.WriteLine($"{num1}不是質數。");
				else
				{
					for (int i = 1; i <= num2; i += 2)
					{
						if (num1 % i == 0)
							count++;
					}

					if (count == 1)
						Console.WriteLine($"{num1}是質數。");
					else
						Console.WriteLine($"{num1}不是質數。");
				}
			}
		}
		private static void Q02()
		{
			//找出數值區間內的所有質數
			Console.WriteLine("請輸入兩個數字決定範圍");
			Console.Write("請輸入第一個數字：");
			string input1 = Console.ReadLine();
			int num1 = int.Parse(input1);
			Console.Write("請輸入第二個數字：");
			string input2 = Console.ReadLine();
			int num2 = int.Parse(input2);
			int max, min;

			if (num1 > num2)
			{
				max = num1;
				min = num2;
			}
			else
			{
				max = num2;
				min = num1;
			}

			for (int i = min; i <= max; i++)
			{
				for (int j = 2; j <= i; j++)
				{
					if (i % j == 0)
					{
						if (i == j)
						{
							if (i >= min && i <= max)
								Console.WriteLine(i);
							break;
						}
						else
							break;
					}
				}
			}

		}
		private static void Q03()
		{
			//有一四位數，左邊兩位數相同，右邊兩位數相同，此四位數恰好是某數的平方
			string num;
			int thenum;
			int truenum = 0;

			for (int i = 1; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					num = i.ToString() + i.ToString() + j.ToString() + j.ToString();
					thenum = int.Parse(num);
					if (int.TryParse(Convert.ToString(Math.Sqrt(thenum)), out truenum) == true)
						Console.WriteLine(thenum);
				}
			}
		}
		private static void Q04()
		{
			//百元買百雞
			for (int Cock = 1; Cock <= 20; Cock++)
			{
				for (int Hen = 1; Hen < 33; Hen++)
				{
					int chicken = (100 - Cock - Hen);
					if (chicken % 3 == 0 && Cock * 5 + Hen * 3 + chicken / 3 == 100)
						Console.WriteLine($"公雞有{Cock}隻、母雞有{Hen}隻、小雞有{chicken}隻");
				}
			}
		}
	}
}
