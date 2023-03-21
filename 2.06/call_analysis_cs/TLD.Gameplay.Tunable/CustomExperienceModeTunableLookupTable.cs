using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay.Tunable;

public class CustomExperienceModeTunableLookupTable : ScriptableObject
{
	public float m_IndoorSpawnChance;

	private List<ExperienceMode> m_BaseExperienceModes;

	public CustomTunableLookup_NLMH m_AuroraChanceModifierList;

	public CustomTunableLookup_LMH m_WindSpeedModifierList;

	public CustomTunableLookup_LMH m_WindChangeFrequencyModifierList;

	public CustomTunableLookup_NLMH m_BloodScentModifierList;

	public CustomTunableLookup_Distance m_WildlifeDetectionModifierList;

	public CustomTunableLookup_NLMH m_WolfFleeModifierList;

	public CustomTunableLookup_LMH m_PlantSpawnChanceList;

	public CustomTunableLookup_LMHV m_WildlifeRespawnTimeModifierList;

	public CustomTunableLookup_LMHV m_ThirstScaleList;

	public CustomTunableLookup_LMHV m_FatigueScaleList;

	public CustomTunableLookup_NLMHV m_ConditionRecoveryRestList;

	public CustomTunableLookup_NLMHV m_ConditionRecoveryAwakeList;

	public CustomTunableLookup_NLMH m_EmptyContainerChanceList;

	public CustomTunableLookup_LMHV m_SmellRangeList;

	public CustomTunableLookup_NLMH m_StruggleDamageReceivedList;

	public CustomTunableLookup_NLMH m_StruggleClothingDamageList;

	public CustomTunableLookup_NLMHV m_FishCatchTimeScaleMaxList;

	public CustomTunableLookup_NLMHV m_FishCatchTimeScaleDayStartList;

	public CustomTunableLookup_NLMHV m_FishCatchTimeScaleDayFinalList;

	public CustomPackSettingsLookup_LMH m_TimberWolfPackFearList;

	public CustomTunableLookup_ProportionalMaxItems m_MaxItemReductionByEmptyContainerChance;

	[DeduplicatedMethod]
	[CallerCount(Count = 27)]
	public IList<ExperienceMode> GetBaseExperienceModes()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public CustomExperienceModeTunableLookupTable()
	{
	}
}
