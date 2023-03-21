using Cpp2ILInjected.CallAnalysis;

public class FoodPoisoningSaveDataProxy
{
	public bool m_Active;

	public float m_ElapsedHours;

	public float m_DurationHours;

	public bool m_AntibioticsTaken;

	public float m_ElapsedRest;

	public string m_CauseLocID;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public FoodPoisoningSaveDataProxy()
	{
	}
}
