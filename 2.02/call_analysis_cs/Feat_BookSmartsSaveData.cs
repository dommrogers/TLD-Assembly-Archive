using Cpp2ILInjected.CallAnalysis;

public class Feat_BookSmartsSaveData
{
	public int m_HoursResearch;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Feat_BookSmartsSaveData()
	{
	}
}
