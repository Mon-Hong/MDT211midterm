using System;

namespace GameHangman
{
    class Program
    {
        static void Main(string[] args)
        {
			//เลือกเมนู
			string menu;

			do
			{
				Console.Clear();
				Console.Write("Welcome to Hangman Game\n----------------------------------------\n1. Play game \n2. Exit \n\nPlease Select Menu : ");
				menu = Console.ReadLine();
				

			} while (menu != "1" && menu != "2");//ถ้าไม่ใข่1หรือ2ให้กลับไปเลือกใหม่

			if (menu == "1")
			{
				Console.Clear();
				PlayGame playgame = new PlayGame();

			}

			else if (menu == "2")
			{
				Console.Write(" ");
			}

		}





    }
}
