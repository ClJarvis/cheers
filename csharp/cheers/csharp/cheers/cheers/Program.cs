using System;

namespace cheers
{
	class MainClass
	{
		public static void Main (string[] args)

	//	name[] delimitername = { ' ', ',', '.', ':', '\t' };
		{
			Console.WriteLine ("What is your name?");
			var response = Console.ReadLine(); //change string to var
			var halfnorsemix = "HALFNORSEMIX";
			string upperResponse = response.ToUpper();
			//changed to char cannot convert string to char
			foreach (var c in upperResponse)
			{
				if (halfnorsemix.IndexOf(c)!=-1)
				{
					Console.WriteLine("Give me an {0}", c);
				}
				else Console.WriteLine("Give me a {0}", c);

			}
				//now prints your name is grand x times x=name.length cannot ge cheer to print
			Console.WriteLine (response + " is.. Grand");

		//	string[] words = response.Split(response);
			//unneeded
			//System.Console.WriteLine("{0} letters in", + response.Length);


			{
			//	System.Console.WriteLine("Give me a.. "+ c);
			}
		}
	}
}




/*### What to Implement
1. Getting user's name and print it.
2. Cheer the user on.

For example, if name is "Bob", output should be:

```shell
Give me a.. b
Give me an.. o
Give me a.. b
BOB is.. GRAND!
```
*/
