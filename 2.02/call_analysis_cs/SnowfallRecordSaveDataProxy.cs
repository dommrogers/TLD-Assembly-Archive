using Cpp2ILInjected.CallAnalysis;

internal class SnowfallRecordSaveDataProxy
{
	public float m_CurrentSnowDepth;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SnowfallRecordSaveDataProxy()
	{
	}
}
