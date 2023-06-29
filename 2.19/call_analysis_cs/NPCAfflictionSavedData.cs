using Cpp2ILInjected.CallAnalysis;

public class NPCAfflictionSavedData
{
	public bool m_Remedy1Complete;

	public bool m_Remedy2Complete;

	public bool m_AlternateRemedy1Complete;

	public bool m_AlternateRemedy2Complete;

	public float m_WaterLiters;

	public float m_RestHours;

	public string m_AfflictionName;

	public AfflictionType m_AfflictionType;

	public AfflictionBodyArea m_Location;

	public string m_CauseLocId;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public NPCAfflictionSavedData()
	{
	}
}
