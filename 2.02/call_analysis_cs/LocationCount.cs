using Cpp2ILInjected.CallAnalysis;

public class LocationCount
{
	public static int m_LocationCount;

	public static int m_IndoorCount;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LocationCount()
	{
	}
}
