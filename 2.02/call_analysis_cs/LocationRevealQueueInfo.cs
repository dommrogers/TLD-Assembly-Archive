using Cpp2ILInjected.CallAnalysis;

public class LocationRevealQueueInfo
{
	public string m_Text;

	public string m_SubText;

	public bool m_ShowNewLocation;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LocationRevealQueueInfo()
	{
	}
}
