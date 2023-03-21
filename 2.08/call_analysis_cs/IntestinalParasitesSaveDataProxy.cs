using Cpp2ILInjected.CallAnalysis;

public class IntestinalParasitesSaveDataProxy
{
	public bool m_HasParasites;

	public bool m_HasParasiteRisk;

	public float m_CurrentInfectionChance;

	public float m_ParasitesElapsedHours;

	public float m_RiskElapsedHours;

	public float m_RiskDurationHours;

	public int m_NumDosesTaken;

	public bool m_HasTakenDoseToday;

	public int m_DayToAllowNextDose;

	public int m_NumPiecesEatenThisRiskCycle;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public IntestinalParasitesSaveDataProxy()
	{
	}
}
