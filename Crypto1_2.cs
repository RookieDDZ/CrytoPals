using System;
using System.Text;

namespace CrytoPal_1_2
{
	class MainClass
	{
		public static void Main()
		{
			Console.WriteLine("you feed it the string: 1c0111001f010100061a024b53535009181c");
			Console.WriteLine("after hex decoding, and when XOR'd against: 686974207468652062756c6c277320657965");
			//define variables
			string str1 = "1c0111001f010100061a024b53535009181c";
			string str2 = "686974207468652062756c6c277320657965";
			byte[] byteStr1;
			byte[] byteStr2;
			byte[] final;
			var sb = new StringBuilder();

			//convert str1
			str1 = str1.Replace("-", "");
			byte[] resultantArray1 = new byte[str1.Length / 2];

			for (int i = 0; i < resultantArray1.Length; i++)
			{
				resultantArray1[i] = Convert.ToByte(str1.Substring(i * 2, 2), 16);
			}
			byteStr1 = resultantArray1;

			//convert str2
			byte[] resultantArray2 = new byte[str2.Length / 2];

			for (int i = 0; i < resultantArray2.Length; i++)
			{
				resultantArray2[i] = Convert.ToByte(str2.Substring(i * 2, 2), 16);
			}
			byteStr2 = resultantArray2;

			//XOR
			final = produceCombo(byteStr1, byteStr2);

			//convert bytes to hex
			foreach (var c in final)
			{
				sb.Append(c.ToString("X2"));
			}

			Console.WriteLine("Answer: " + sb);

		}

		static byte[] produceCombo(byte[] arr, byte[] str2)
		{
			var xOR = new byte[arr.Length];
			for (var i = 0; i < arr.Length; i++)
			{
				xOR[i] = (byte)(arr[i] ^ str2[i]);
			}

			return xOR;
		}
}
}
