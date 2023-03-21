using Cpp2ILInjected.CallAnalysis;

public class SprainedAnkleSaveDataProxy
{
	public bool m_Active;

	public float m_ElapsedHours;

	public float m_DurationHours;

	public float m_ElapsedRest;

	public float m_SecondsSinceLastPainAudio;

	public float m_SecondsUntilNextPainAudio;

	public string[] m_CausesLocIDs;

	public int[] m_Locations;

	public float[] m_ElapsedHoursList;

	public float[] m_DurationHoursList;

	public float[] m_ElapsedRestList;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SprainedAnkleSaveDataProxy()
	{
	}
}
