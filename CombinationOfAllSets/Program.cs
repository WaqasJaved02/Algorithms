using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret
{
	public partial class Program
	{
		static void Main(string[] args)
		{
			combination("ABCD");
			Console.ReadLine();
		}

		public static void combination(string str)
		{
			int len = 1;
			for (int i = 0; i < str.Length; i++) { len *= 2; }
			len -= 1;
			int count = 0;
			string[] ch = new string[len];
			for (int i = str.Length - 1; i >= 0; i--)
			{
				int l = count;
 				for (int j = 0; j < l; j++)
				{
					ch[count++] = str[i] + ch[j];										
				}
				ch[count++] = str[i].ToString();				
			}

			for (int i = 0; i < len; i++)
			{
				Console.WriteLine(ch[i].ToString());
			}
		}
	}
}
