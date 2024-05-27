using System;
public struct Square
{
	public int width, length;
	public Square(int w, int l)
	{
		width = w;
		length = l;
	}
	public void areaOfsquare()
	{
	Console.WriteLine("Area of square is: " + (width + length));
	}
}
public class tStructs
{
   public static void Main()
	{
		Square S = new Square(25, 30);
		S.areaOfsquare();
	}
}