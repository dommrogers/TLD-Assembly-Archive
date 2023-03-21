using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathColours
{
	public static Color RED;

	public static Color GREEN;

	public static Color DARKGREEN;

	public static Color BLUE;

	public static Color GREY;

	public static Color DARKGREY;

	public static Color CYAN;

	public static Color PURPLE;

	public static Color MAGENTA;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CameraPathColours()
	{
	}
}
