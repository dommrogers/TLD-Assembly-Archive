using Cpp2ILInjected.CallAnalysis;

public class CabinFeverSaveDataProxy
{
	public bool m_Active;

	public bool m_RiskActive;

	public float m_ElapsedHours;

	public float[] m_IndoorTimeTracked;

	public int m_HourLastFrame;

	public bool m_DoneHalloweenEventFix;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CabinFeverSaveDataProxy()
	{
	}
}
