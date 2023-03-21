using Cpp2ILInjected.CallAnalysis;

public class AuroraFieldDataProxy
{
	public bool m_IsActive;

	public bool m_CanRollChance;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public AuroraFieldDataProxy()
	{
	}
}
