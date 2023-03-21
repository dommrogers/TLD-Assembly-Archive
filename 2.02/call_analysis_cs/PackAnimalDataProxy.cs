using Cpp2ILInjected.CallAnalysis;

public class PackAnimalDataProxy
{
	public float m_PackReformDelayTimer;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public PackAnimalDataProxy()
	{
	}
}
