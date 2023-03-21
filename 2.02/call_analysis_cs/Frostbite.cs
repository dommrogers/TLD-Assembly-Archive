using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Frostbite : MonoBehaviour
{
	[Serializable]
	public class BodyAreaFrostbiteHP
	{
		public AfflictionBodyArea m_BodyArea;

		public float m_HP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public BodyAreaFrostbiteHP()
		{
		}
	}

	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_TemperatureToBeginFrostbiteDamage;

	public float m_DamagePerHourBase;

	public float m_DamagePerHourIncreasePerDegree;

	public float m_MaxDamagePerHour;

	public float m_DamageMultiplierInnerFrozenClothing;

	public float m_PilgrimDamageMultiplier;

	public float m_VoyageurDamageMultiplier;

	public float m_StalkerDamageMultiplier;

	public float m_InterloperDamageMultiplier;

	public float m_TemperatureToBeginFrostbiteHeal;

	public float m_HealPerHourBase;

	public float m_HealPerHourIncreasePerDegree;

	public float m_MaxHealPerHour;

	public BodyAreaFrostbiteHP[] m_BodyAreaFrostbiteMaxHPList;

	public float m_HPPercentThresholdToStartRisk;

	public float m_MaxPlayerHPReductionPerInstance;

	public string m_FrostbiteVO;

	private List<int> m_LocationsWithActiveFrostbite;

	private List<int> m_LocationsWithFrostbiteRisk;

	private List<float> m_LocationsCurrentFrostbiteDamage;

	private bool m_StartHasBeenCalled;

	private bool m_SuppressFrostbite;

	private float[] m_MaxHPList;

	private static FrostbiteSaveDataProxy m_FrostbiteSaveDataProxy;

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Frostbite), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 13)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Frostbite), Member = "Start")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 28)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_frostbite_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_frostbite")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	public void FrostbiteStart(int location, bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_frostbite_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void FrostbiteEnd()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTotalHitPointReduction()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int NumInstancesFrostbite()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostBiteLocation")]
	[CalledBy(Type = typeof(FrostbiteIndicator), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostbiteAfflictionCount")]
	public int NumInstancesFrostbiteAtLocation(int location)
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[CalledBy(Type = typeof(Condition), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallsUnknownMethods(Count = 1)]
	public bool HasFrostbite()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Condition), Member = "HasAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Condition), Member = "HasRiskAffliction")]
	public bool HasFrostbiteRisk()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteAfflictionCount")]
	public bool HasFrostbiteAffliction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskAfflictionCount")]
	public bool HasFrostbiteRiskAffliction()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[CalledBy(Type = typeof(Frostbite), Member = "HasFrostbiteRiskAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	public int GetFrostbiteRiskAfflictionCount()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Frostbite), Member = "HasFrostbiteAffliction")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	public int GetFrostbiteAfflictionCount()
	{
		return default(int);
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(FrostbiteIndicator), Member = "Update")]
	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostbiteRiskAfflictionCount")]
	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostBiteRiskLocation")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 5)]
	public float GetFrostbiteRiskValue(int location)
	{
		return default(float);
	}

	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AfflictionBodyArea GetFrostBiteRiskLocation(int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[CallsUnknownMethods(Count = 4)]
	public AfflictionBodyArea GetFrostBiteLocation(int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSuppressFrostbite(bool suppress)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool GetSuppressFrostbite()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool LocationIsIgnored(int location)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Frostbite), Member = "Update")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[Calls(Type = typeof(PlayerManager), Member = "RegionHasNonFrozenClothing")]
	[Calls(Type = typeof(PlayerManager), Member = "RegionHasFullFrozenInnerLayer")]
	[Calls(Type = typeof(Frostbite), Member = "GetXPModeMultiplier")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "RegionHasFullFrozenInnerLayer")]
	[Calls(Type = typeof(Frostbite), Member = "GetXPModeMultiplier")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[Calls(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void UpdateFrostbite()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private void DealFrostbiteDamageToRegion(float damageValue, ClothingRegion region)
	{
	}

	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private bool DealFrostbiteDamageToLocation(float damageValue, AfflictionBodyArea bodyArea)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[Calls(Type = typeof(Weather), Member = "GetCurrentWindchill")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Rest), Member = "GetBedWarmthBonusCelsius")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PassTime), Member = "GetBedWarmthBonusCelsius")]
	private float CalculateBodyTemperatureWithoutClothing()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	private float GetXPModeMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 37)]
	public Frostbite()
	{
	}
}
