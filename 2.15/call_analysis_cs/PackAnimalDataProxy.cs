using Cpp2ILInjected.CallAnalysis;

public class PackAnimalDataProxy
{
	public float m_PackReformDelayTimer;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PackAnimalDataProxy()
	{
	}
}
