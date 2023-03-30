using Cpp2ILInjected.CallAnalysis;

public class WaterSourceSaveDataProxy
{
	public float m_CurrentLiters;

	public LiquidQuality m_CurrentLiquidQuality;

	public bool m_RolledSpawnChance;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public WaterSourceSaveDataProxy()
	{
	}
}
