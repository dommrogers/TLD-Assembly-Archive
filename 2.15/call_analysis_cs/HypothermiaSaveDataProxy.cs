using Cpp2ILInjected.CallAnalysis;

public class HypothermiaSaveDataProxy
{
	public bool m_Active;

	public float m_ElapsedHours;

	public float m_ElapsedWarmTime;

	public string m_CauseLocID;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public HypothermiaSaveDataProxy()
	{
	}
}
