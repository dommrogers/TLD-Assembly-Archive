using Cpp2ILInjected.CallAnalysis;

public class InfectionRiskSaveDataProxy
{
	public bool m_Active;

	public float m_ElapsedHours;

	public float m_DurationHours;

	public bool m_AntisepticTaken;

	public float m_CommentTime;

	public float m_CurrentInfectionChance;

	public string[] m_CausesLocIDs;

	public int[] m_Locations;

	public float[] m_ElapsedHoursList;

	public float[] m_DurationHoursList;

	public bool[] m_AntisepticTakenList;

	public float[] m_CurrentInfectionChanceList;

	public int[] m_ConstantAfflictionIndices;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public InfectionRiskSaveDataProxy()
	{
	}
}
