using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i < 111; i++)
			{
				if (i % 12 == 0)
				{
					Console.WriteLine();
				}
				if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)

				{
					Console.Write("cozalozawoza");
				}
				else if (i % 3 == 0 && i % 5 == 0)
				{
					Console.Write("cozaloza");
				}
				else if (i % 3 == 0 && i % 7 == 0)
				{
					Console.Write("cozawoza");
				}
				else if (i % 5 == 0 && i % 7 == 0)
				{
					Console.Write("wozaloza");
				}
				else if (i % 3 == 0)
				{
					Console.Write("coza");
				}
				else if (i % 5 == 0)
				{
					Console.Write("loza");
				}
				else if (i % 7 == 0)
				{
					Console.Write("woza");
				}
				else
				{
					Console.Write("" + i + " ");
				}

				{
					Console.Write("  ");
				}

					

			}
			Console.ReadKey();
		}
	}
}
