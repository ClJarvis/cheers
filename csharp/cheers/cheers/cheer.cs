using System;

namespace cheers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("What is your name?");

			string name = "Bob";
			Console.WriteLine (name + " is.. Grand");
			string[] words = name.Split(name);
			System.Console.WriteLine("{0} letters in name:", name.Length);

			foreach (string s in name)
			{
				System.Console.WriteLine(s);
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
