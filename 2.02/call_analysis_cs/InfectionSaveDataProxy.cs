using Cpp2ILInjected.CallAnalysis;

public class InfectionSaveDataProxy
{
	public bool m_Active;

	public float m_ElapsedHours;

	public float m_DurationHours;

	public bool m_AntibioticsTaken;

	public float m_ElapsedRest;

	public string[] m_CausesLocIDs;

	public int[] m_Locations;

	public float[] m_ElapsedHoursList;

	public float[] m_DurationHoursList;

	public bool[] m_AntibioticsTakenList;

	public float[] m_ElapsedRestList;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public InfectionSaveDataProxy()
	{
	}
}
