using Cpp2ILInjected.CallAnalysis;

public class PackAnimalDataProxy
{
	public float m_PackReformDelayTimer;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PackAnimalDataProxy()
	{
	}
}
