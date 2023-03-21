using Cpp2ILInjected.CallAnalysis;

public class LocationRevealQueueInfo
{
	public string m_Text;

	public string m_SubText;

	public bool m_ShowNewLocation;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public LocationRevealQueueInfo()
	{
	}
}
