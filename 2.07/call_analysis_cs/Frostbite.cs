using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Frostbite : MonoBehaviour
{
	[Serializable]
	public class BodyAreaFrostbiteHP
	{
		public AfflictionBodyArea m_BodyArea;

		public float m_HP;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	public float m_TemperatureToBeginFrostbiteHeal;

	public float m_HealPerHourBase;

	public float m_HealPerHourIncreasePerDegree;

	public float m_MaxHealPerHour;

	public BodyAreaFrostbiteHP[] m_BodyAreaFrostbiteMaxHPList;

	public float m_HPPercentThresholdToStartRisk;

	public float m_MaxPlayerHPReductionPerInstance;

	public string m_FrostbiteVO;

	private PanelReference<Panel_HUD> m_HUD;

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
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_frostbite_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_frostbite")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	public void FrostbiteStart(int location, bool displayIcon, bool nofx = false)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	public void FrostbiteEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetTotalHitPointReduction()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int NumInstancesFrostbite()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostbiteAfflictionCount")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(FrostbiteIndicator), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostBiteLocation")]
	public int NumInstancesFrostbiteAtLocation(int location)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Condition), Member = "HasAffliction")]
	[CallsUnknownMethods(Count = 1)]
	public bool HasFrostbite()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Condition), Member = "HasRiskAffliction")]
	[CalledBy(Type = typeof(Condition), Member = "HasAffliction")]
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

	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[CalledBy(Type = typeof(Frostbite), Member = "HasFrostbiteRiskAffliction")]
	[CallerCount(Count = 1)]
	public int GetFrostbiteRiskAfflictionCount()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[CalledBy(Type = typeof(Frostbite), Member = "HasFrostbiteAffliction")]
	[CallsUnknownMethods(Count = 2)]
	public int GetFrostbiteAfflictionCount()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostBiteRiskLocation")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostbiteRiskAfflictionCount")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(FrostbiteIndicator), Member = "Update")]
	public float GetFrostbiteRiskValue(int location)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[CallsUnknownMethods(Count = 2)]
	public AfflictionBodyArea GetFrostBiteRiskLocation(int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[CallsUnknownMethods(Count = 2)]
	public AfflictionBodyArea GetFrostBiteLocation(int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetSuppressFrostbite(bool suppress)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool GetSuppressFrostbite()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool LocationIsIgnored(int location)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Frostbite), Member = "Update")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[Calls(Type = typeof(PlayerManager), Member = "RegionHasNonFrozenClothing")]
	[Calls(Type = typeof(PlayerManager), Member = "RegionHasFullFrozenInnerLayer")]
	[Calls(Type = typeof(Frostbite), Member = "GetXPModeMultiplier")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Frostbite), Member = "GetXPModeMultiplier")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[Calls(Type = typeof(PlayerManager), Member = "RegionHasFullFrozenInnerLayer")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateFrostbite()
	{
	}

	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[Calls(Type = typeof(Frostbite), Member = "GetXPModeMultiplier")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	private void DealFrostbiteDamageToRegion(float damageValue, ClothingRegion region)
	{
	}

	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	private void DealFrostbiteDamageToLocation(float damageValue, AfflictionBodyArea bodyArea)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[Calls(Type = typeof(Weather), Member = "GetCurrentWindchill")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Rest), Member = "GetBedWarmthBonusCelsius")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PassTime), Member = "GetBedWarmthBonusCelsius")]
	private float CalculateBodyTemperatureWithoutClothing()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CallsUnknownMethods(Count = 1)]
	private float GetXPModeMultiplier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public Frostbite()
	{
	}
}
