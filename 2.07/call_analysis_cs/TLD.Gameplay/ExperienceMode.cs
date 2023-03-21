using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using TLD.Gear;
using UnityEngine;

namespace TLD.Gameplay;

public class ExperienceMode : ScriptableObject
{
	public ExperienceModeType m_ModeType;

	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

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

	private bool m_ShouldInterruptSleepIfFreezing;

	public StartGearData m_StartGear;

	public float m_FrostbiteDamageMultiplier;

	public int m_IntestinalParasitesNumberOfRemedyDoses;

	public int m_DaysBeforeCabinFeverRiskOnset;

	public float m_DecayScale;

	public float m_GearSpawnChanceScale;

	public int m_ReduceMaxItemsInContainer;

	public int m_ChanceForEmptyContainer;

	public float m_SpawnRegionChanceActiveScale;

	public float m_ClosestSpawnDistanceAfterTransitionScale;

	public float m_SmellRangeScale;

	public bool m_SetWildlifeNotAttackUnprovoked;

	public bool m_SetWildlifeInterruptRest;

	public DamageEventTable m_GenericDamageTable;

	public List<DamageEventTableOverride> m_DamageTableOverrides;

	private PackSettings m_PackSettings;

	public float m_StruggleTapStrengthScale;

	public float m_StrugglePlayerDamageReceivedIntervalScale;

	public float m_StrugglePlayerDamageReceivedScale;

	public float m_StrugglePlayerClothingDamageScale;

	public float m_StugglePlayerPercentLossFromBearScale;

	public float m_OutdoorTempDropCelsiusMax;

	public int m_OutdoorTempDropDayStart;

	public int m_OutdoorTempDropDayFinal;

	private bool m_ShouldAdjustFreezingDueToNearbyFire;

	public float m_MinAirTemperatureFromFireOutdoors;

	public float m_MinAirTemperatureFromFireIndoors;

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

	public virtual bool InterruptIfFreezingWhileSleeping
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public virtual bool AdjustFreezingDueToNearbyFire
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public virtual PackSettings GetPackSettings()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetDamageEventsForTag")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesTag")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public DamageEventTable GetDamageEventTable(GameplayTag tag)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ExperienceMode()
	{
	}
}
