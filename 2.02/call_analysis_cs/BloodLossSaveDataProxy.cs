using Cpp2ILInjected.CallAnalysis;

public class BloodLossSaveDataProxy
{
	public bool m_Active;

	public float m_ElapsedHours;

	public float m_DurationHours;

	public string[] m_CausesLocIDs;

	public int[] m_Locations;

	public float[] m_ElapsedHoursList;

	public float[] m_DurationHoursList;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BloodLossSaveDataProxy()
	{
	}
}
