using System;
using System.Text;
using System.Linq;
using System.Windows;
using System.IO;


namespace cheers
{
	class MainClass
	{
		public static void Main (string[] args)

	//	user inputs name
		{
			Console.WriteLine ("What is your name?");
			string response = Console.ReadLine(); //changed string to var
			string halfnorsemix = "HALFNORSEMIX";
			string upperResponse = response.ToUpper();

	// User enters birthdate

			Console.WriteLine ("What's your Birthday? mm/dd");	
			string bDay = Console.ReadLine();
			DateTime today = DateTime.Now;
			DateTime userBday = Convert.ToDateTime(bDay);

			TimeSpan bDayCalc;
			if (userBday == today) {
				//bDayCalc == today;
				Console.Write ("Happy Birthday!!");
		}
				if (userBday > today) {
					bDayCalc = userBday - today;
				} else {
					bDayCalc = today - userBday;
				}
	//		}
			int differenceInDays = bDayCalc.Days;

			foreach (var c in upperResponse)
			{
				if (halfnorsemix.IndexOf(c)!=-1)
				{
					Console.WriteLine("Give me an {0}", c);
				}
				else Console.WriteLine("Give me a {0}", c);

			}
			Console.WriteLine (response + " is.. Grand");
			Console.WriteLine (" ");
			Console.Write ("Your Birthday is {0} days away", differenceInDays);


			{
				
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

Your birthday is _____ days away!
If the person's birthday is that day your program should say:

Happy Birthday!!
```
*/
