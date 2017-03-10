using System;

namespace HabsPolymorphism2
{

	public class Goal // the base class to be inherited
	{
		public virtual void Score()
		{
			Console.WriteLine("Score a Goal");
		}
	}

	public class Blueline : Goal // first child class
	{
		public override void Score()
		{
			Console.WriteLine("GOOOOAALLL."); // output
		}
	}

	public class Shorthanded : Goal // second child class
	{
		public override void Score()
		{
			Console.WriteLine("Holy Mackanaw."); // output
		}
	}

	public class Emptynetter : Goal // third child class
	{
		public override void Score()
		{
			Console.WriteLine("Hat Trick."); // output
		}
	}
	public class Powerplay : Goal // fourth child class
	{
		public override void Score()
		{
			Console.WriteLine("Un But."); // output
		}

		public class ScoreDemo
		{
			public static int Main()
			{
				Goal[] Go = new Goal[4]; // array

				Go[0] = new Blueline();
				Go[1] = new Shorthanded();
				Go[2] = new Emptynetter();
				Go[3] = new Powerplay();

				foreach (Goal Goal in Go)
				{
					Goal.Score();
				}

				return 0;
			}
		}
	}
}