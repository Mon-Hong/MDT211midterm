using System;
using System.Collections.Generic;
public class PlayGame
{
	

	public PlayGame()

	{
		int score = 0;
		int scorewrong = 0;
		string newguess;


	Console.WriteLine("Play Game Hangman\n----------------------------------------\nIncorrect Score: {0}\n" , score);

		Randoms randoms = new Randoms();
		//Console.WriteLine(randoms.numword); //ทดลองเฉยๆว่าดึงมาได้ไหม

		char [] guess = new char[randoms.numword];
		for (int i = 0; i < randoms.numword; i++) //เปลี่ยนเป็นขีด
		{


			guess[i] = '_';
			Console.Write("{0} ", guess[i]);
		}
		Console.Write("\n\nInput letter alphabet: ");
		do//เช็กคำ
		{


			
			char character = char.Parse(Console.ReadLine());

			for (int j = 0; j < randoms.numword; j++)
			{

				if (character == randoms.Mywords[j])
				{
					guess[j] = character;

				}

				else if (character != randoms.Mywords[j])
				{


					score = score + 1;

				}

			}
			//นับคะแนน
			if (score == randoms.numword)
			{
				scorewrong = scorewrong + 1;
				score = 0;
			}
			if (score == randoms.numword - 1)
			{
				score = 0;
			}
			score = 0;

			Console.Clear();
			Console.WriteLine("Play Game Hangman\n----------------------------------------\nIncorrect Score: {0}\n", scorewrong);

			Console.WriteLine(guess);
			Console.Write("\n\nInput letter alphabet: ");
			newguess = new string(guess); // แปลง char array เป็น string 

		} while (true && (scorewrong < 6 && newguess != randoms.Mywords));

		if (scorewrong == 6)
		{
			Console.WriteLine("\n\nGame Over");

		}

		if (scorewrong < 6)
		{
			Console.WriteLine("\n\nYour win!!");

		}
	}




	





}




