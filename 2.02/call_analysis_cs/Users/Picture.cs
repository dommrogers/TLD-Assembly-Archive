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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static int GetDimension(Size size)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Picture()
	{
	}
}
