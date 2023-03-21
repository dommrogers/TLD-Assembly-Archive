using Cpp2ILInjected.CallAnalysis;

public class LinkedChimneySaveData
{
	public float m_LifetimeMinutes;

	public string m_ChimneyGuid;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LinkedChimneySaveData()
	{
	}
}
