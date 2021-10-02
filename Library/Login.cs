using System;

public class Login
{
	PersonList person = new PersonList();
	public string namelog;
	public string passwordlog;
	public Login()
	{
		Console.Write("Login Screen\n----------------------------------------");

		Console.Write("\nInput Name: ");
		namelog = Console.ReadLine();

		Console.Write("\nInput Password: ");
		passwordlog = Console.ReadLine();

		
	}
}
