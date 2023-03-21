using Cpp2ILInjected.CallAnalysis;

public class BedSaveDataProxy
{
	public BedRollState m_BedRollState;

	public string m_Guid;

	public string m_BodyGuid;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BedSaveDataProxy()
	{
	}
}
