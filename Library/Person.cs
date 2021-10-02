using System;

public class Person
{
	protected string name;
	protected string password;
	protected string type;
	protected string id;
	public Person(string name, string password, string type , string id)
	{
		this.name = name;
		this.password = password;
		this.type = type;
		this.id = id;
	}

	public string GetName()
    {
		return this.name;
    }
}
