using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入需要的階乘數:");
			int number = int.Parse(Console.ReadLine());
			long result = 1;
			for (int i = 1; i <=number; i++)
			{
				result = result * i;
				
			}
			Console.WriteLine($"答案是{result}");
		}
	}     
}
