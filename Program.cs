using System;

namespace CrytoPal_1_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//define variables
			string hexData = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
			byte[] byteData;
			string finalBase64;

			hexData = hexData.Replace("-", "");

			byte[] resultantArray = new byte[hexData.Length / 2];

			for (int i = 0; i < resultantArray.Length; i++)
			{
				resultantArray[i] = Convert.ToByte(hexData.Substring(i * 2, 2), 16);
			}
			byteData = resultantArray;

			finalBase64 = Convert.ToBase64String(byteData);
			Console.WriteLine(finalBase64);
		}
	}
}
