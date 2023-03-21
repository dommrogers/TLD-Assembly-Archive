using Cpp2ILInjected.CallAnalysis;

public class AuroraFieldDataProxy
{
	public bool m_IsActive;

	public bool m_CanRollChance;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AuroraFieldDataProxy()
	{
	}
}
