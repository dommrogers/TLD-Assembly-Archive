using Cpp2ILInjected.CallAnalysis;

public class MatchesItemSaveDataProxy
{
	public float m_BurnTimeGametimeSeconds;

	public float m_ElapsedBurnGametimeSeconds;

	public bool m_Ignited;

	public bool m_IsFresh;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MatchesItemSaveDataProxy()
	{
	}
}
