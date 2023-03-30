using Cpp2ILInjected.CallAnalysis;

public class SafeCrackingSaveDataProxy
{
	public bool m_CrackedProxy;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SafeCrackingSaveDataProxy()
	{
	}
}
