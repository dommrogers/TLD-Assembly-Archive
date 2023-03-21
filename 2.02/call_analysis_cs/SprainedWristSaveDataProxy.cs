using Cpp2ILInjected.CallAnalysis;

public class SprainedWristSaveDataProxy
{
	public bool m_Active;

	public float m_ElapsedHours;

	public float m_DurationHours;

	public float m_ElapsedRest;

	public string[] m_CausesLocIDs;

	public int[] m_Locations;

	public float[] m_ElapsedHoursList;

	public float[] m_DurationHoursList;

	public float[] m_ElapsedRestList;

	public bool m_IsNoSprainWristForced;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SprainedWristSaveDataProxy()
	{
	}
}
