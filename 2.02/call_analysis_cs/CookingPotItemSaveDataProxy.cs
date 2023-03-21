using Cpp2ILInjected.CallAnalysis;

public class CookingPotItemSaveDataProxy
{
	public string m_FireBeingUsedGUID;

	public string m_GearItemBeingCookedGUID;

	public float m_CookingElapsedHours;

	public float m_GracePeriodElapsedHours;

	public float m_FireBurningTimeTODHours;

	public float m_HoursPlayedWhenSerialized;

	public float m_LitersSnowBeingMelted;

	public float m_LitersWaterBeingBoiled;

	public bool m_CanOnlyWarmUpFood;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CookingPotItemSaveDataProxy()
	{
	}
}
