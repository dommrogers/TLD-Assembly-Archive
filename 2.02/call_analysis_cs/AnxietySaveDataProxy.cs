using Cpp2ILInjected.CallAnalysis;

public class AnxietySaveDataProxy
{
	public bool m_HasAffliction;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AnxietySaveDataProxy()
	{
	}
}
