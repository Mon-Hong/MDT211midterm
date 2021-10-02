using System;

class Randoms
{
	public int resulRandom;
	public string Mywords;
	public int numword;
	public char[] Usedword;
	public  Randoms()
	{
		string[] word = new string[] { "Tennis", "Football", "Badminton" };

		Random random = new Random();
		resulRandom = random.Next(0, 3);
		//Console.WriteLine(resulRandom); //สุ่มคำถาม

		Mywords = word[resulRandom];
		//Console.WriteLine(Mywords); // คำที่สุ่มได้

		numword = Mywords.Length;
		//Console.WriteLine(numword); //นับคำตัวอักษร

		Usedword = Mywords.ToCharArray();
		//Console.WriteLine(Usedword); // แปลง String เป็น char array
	}
}
