using System;
namespace multipleinheritanceexample
{
	public interface ITelevision
	{
		void Apple();
		int Samsung();
	}

	public interface IDth
	{
		void Reliance();
		int Sky();
	}

	public class MultipleinheritanceTVS : ITelevision, IDth
	{
		public void Apple()
		{
			Console.WriteLine("I am using a apple tv");
		}

		public int Samsung()
		{
			int i = 49;
			Console.WriteLine("I am using a 49 inches samsung tv", +i);
			return i;
		}

		void IDth.Reliance()
		{
			Console.WriteLine("I am using a reliance tv");
		}

		int IDth.Sky()
		{
			int i = 60;
			Console.WriteLine("I am using a 60 inches sky tv", +i);
			return i;
		}

		public static void Main(string[] args)
		{
			MultipleinheritanceTVS tv = new MultipleinheritanceTVS();
			tv.Apple();
			tv.Samsung();
			((IDth)tv).Reliance();
			((IDth)tv).Sky();

			EnumExample en = new EnumExample();
			en.PrintDays();
		}
	}

	public class EnumExample
	{
		public enum Days { sun, mon, tue, wed, thurs, fri, sat };
		public void PrintDays()
		{
			int i = (int)Days.wed;
			int j = (int)Days.fri;
			Console.WriteLine(i);
			Console.WriteLine("fri={0}", j);
		}
	}
}