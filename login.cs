using System;
using System.IO;
					
public class Program
{
	public static void Main()
	{	
		Console.WriteLine("Welcome to Auto-Login System");
		string string_var = @"C:/autologin/login.txt";
		if (File.Exists(string_var)) {
			Console.WriteLine("File does exist, logging with it!");
			string login_text = System.IO.File.ReadAllText(@"C:/dopia/login.txt");
			string[] login_list = login_text.Split(':');
			string username = login_list[0];
			string password = login_list[1];
			// Login with the credentials above (username, password)
		}
		else {
			Console.WriteLine("Please enter your username\n");
			string username = Console.ReadLine();
			Console.WriteLine("Please enter your password\n");
			string password = Console.ReadLine();
			Console.WriteLine("Logging with " + username + " (username) & " + password + " (password)");
			// Login with user input
		}
	}
}
