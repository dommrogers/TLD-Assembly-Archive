using Cpp2ILInjected.CallAnalysis;

namespace Users;

public class Picture
{
	public enum Size
	{
		Small = 1,
		Medium,
		Large,
		ExtraLarge
	}

	private static int[] Dimension;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetDimension(Size size)
	{
		return default(int);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public Picture()
	{
	}
}
