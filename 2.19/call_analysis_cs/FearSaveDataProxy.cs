using Cpp2ILInjected.CallAnalysis;

public class FearSaveDataProxy
{
	public bool m_HasAffliction;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public FearSaveDataProxy()
	{
	}
}
