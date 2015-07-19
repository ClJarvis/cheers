using System;

namespace cheers
{
	class MainClass
	{
		public static void Main (string[] args)

		name[] delimitername = { ' ', ',', '.', ':', '\t' };
		{
			Console.WriteLine ("What is your name?");
			string response = Console.ReadLine();

			string name = "Bob";
			Console.WriteLine (name + " is.. Grand");
			string[] words = name.Split(name);
			System.Console.WriteLine("{0} letters in name:", name.Length);

			foreach (string s in name)
			{
				System.Console.WriteLine("Give me a.. "+ s);
			}
		}
	}
}




/*### What to Implement
What to Implement

After your user enters their name, your program should ask for their birthdate.
After the cheer, your program should tell the user how many more days there are until their next birthday.
The user should only have to under the Day and Month
THe final version of your app should work like the following:

What's your name?
> Bob
What's your birthday?
> 10/19

Give me a.. b
Give me an.. o
Give me a.. b
BOB is.. GRAND!

Your today is _____ days away!
If the person's birthday is that day your program should say:

Happy Birthday!!
*/
