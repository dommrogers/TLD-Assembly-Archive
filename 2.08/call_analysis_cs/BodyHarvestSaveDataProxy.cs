using Cpp2ILInjected.CallAnalysis;

public class BodyHarvestSaveDataProxy
{
	public float m_MeatAvailableKG;

	public int m_HideAvailableUnits;

	public int m_GutAvailableUnits;

	public bool m_Frozen;

	public bool m_Ravaged;

	public float m_Condition;

	public bool m_RolledSpawnChance;

	public bool m_AllowDecay;

	public float m_HoursPlayed;

	public float m_PercentFrozen;

	public float m_HoursRemainingOnCloseFire;

	public float m_DecimationKGPerHour;

	public float m_DecimationHoursRemaining;

	public float m_QuarterDurationMinutes;

	public bool m_HasHarvested;

	public float m_LastHarvestTimeHours;

	public float m_QuarterBagWasteMultiplier;

	public string m_MissionIdSerialized;

	public string m_BearHuntAiReduxSerialized;

	public BaseAi.DamageSide m_DamageSide;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BodyHarvestSaveDataProxy()
	{
	}
}
