using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFind
{
	class Find
	{
		public static bool Contains(string str, string findStr)
		{
			int i, j;
			int[] next = new int[findStr.Length]; // Префикс-массив
			for (next[0] = j = -1, i = 1; i < findStr.Length; i++) // Цикл заполенния префикс-массива
			{
				for (; j > -1 && findStr[j + 1] != str[i]; j = next[j]) ;
				if (findStr[j + 1] == findStr[i]) j++;
				next[i] = j;
			}

			for (j = -1, i = 0; i < str.Length; i++) // Цикл нахождения подстроки
			{
				for (; j > -1 && findStr[j + 1] != str[i]; j = next[j]) ;
				if (findStr[j + 1] == str[i]) j++;
				if (j == findStr.Length-1) return true;
			}
			return false;
		}
	}
}
