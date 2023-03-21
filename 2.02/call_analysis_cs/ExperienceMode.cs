using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExperienceMode : MonoBehaviour
{
	public ExperienceModeType m_ModeType;

	public LocalizedString m_LocalizedDisplayName;

	public float m_DayNightDurationScale;

	public float m_WeatherDurationScale;

	public float m_ChanceOfBlizzardScale;

	public bool m_WeatherStartForceClear;

	public bool m_WeatherWindForceCalm;

	public float m_CalorieBurnScale;

	public float m_ThirstRateScale;

	public float m_FreezingRateScale;

	public float m_FatigueRateScale;

	public float m_ConditonRecoveryFromRestScale;

	public float m_ConditonRecoveryWhileAwakeScale;

	public float m_DecayScale;

	public float m_GearSpawnChanceScale;

	public int m_ReduceMaxItemsInContainer;

	public int m_ChanceForEmptyContainer;

	public float m_SpawnRegionChanceActiveScale;

	public float m_ClosestSpawnDistanceAfterTransitionScale;

	public float m_SmellRangeScale;

	public bool m_SetWildlifeNotAttackUnprovoked;

	public bool m_SetWildlifeInterruptRest;

	public float m_StruggleTapStrengthScale;

	public float m_StrugglePlayerDamageReceivedIntervalScale;

	public float m_StrugglePlayerDamageReceivedScale;

	public float m_StrugglePlayerClothingDamageScale;

	public float m_StugglePlayerPercentLossFromBearScale;

	public float m_OutdoorTempDropCelsiusMax;

	public int m_OutdoorTempDropDayStart;

	public int m_OutdoorTempDropDayFinal;

	public float m_RespawnHoursScaleMax;

	public int m_RespawnHoursScaleDayStart;

	public int m_RespawnHoursScaleDayFinal;

	public float m_FishCatchTimeScaleMax;

	public int m_FishCatchTimeScaleDayStart;

	public int m_FishCatchTimeScaleDayFinal;

	public float m_RadialRespawnTimeScaleMax;

	public int m_RadialRespawnTimeScaleDayStart;

	public int m_RadialRespawnTimeScaleDayFinal;

	public float m_NumHoursWarmForHypothermiaCureScale;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 26)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void AwakeInternal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ExperienceMode()
	{
	}
}
