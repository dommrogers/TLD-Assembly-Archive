using Cpp2ILInjected.CallAnalysis;

public class LocationCount
{
	public static int m_LocationCount;

	public static int m_IndoorCount;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LocationCount()
	{
	}
}
