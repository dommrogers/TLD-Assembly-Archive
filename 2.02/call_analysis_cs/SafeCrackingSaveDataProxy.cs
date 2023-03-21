using Cpp2ILInjected.CallAnalysis;

public class SafeCrackingSaveDataProxy
{
	public bool m_CrackedProxy;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SafeCrackingSaveDataProxy()
	{
	}
}
