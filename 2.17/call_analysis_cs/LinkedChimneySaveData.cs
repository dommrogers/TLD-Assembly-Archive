using Cpp2ILInjected.CallAnalysis;

public class LinkedChimneySaveData
{
	public float m_LifetimeMinutes;

	public string m_ChimneyGuid;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LinkedChimneySaveData()
	{
	}
}
