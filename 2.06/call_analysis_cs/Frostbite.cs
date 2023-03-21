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
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 10)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_frostbite")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_frostbite_nofx")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void FrostbiteStart(int location, bool displayIcon, bool nofx = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void FrostbiteEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetTotalHitPointReduction()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int NumInstancesFrostbite()
	{
		return 0;
	}

	[CalledBy(Type = typeof(FrostbiteIndicator), Member = "Update")]
	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostbiteAfflictionCount")]
	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostBiteLocation")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int NumInstancesFrostbiteAtLocation(int location)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Condition), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasFrostbite()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "HasRiskAffliction")]
	[CalledBy(Type = typeof(Condition), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasFrostbiteRisk()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteAfflictionCount")]
	public bool HasFrostbiteAffliction()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskAfflictionCount")]
	public bool HasFrostbiteRiskAffliction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Frostbite), Member = "HasFrostbiteRiskAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	public int GetFrostbiteRiskAfflictionCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Frostbite), Member = "HasFrostbiteAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[CallsUnknownMethods(Count = 2)]
	public int GetFrostbiteAfflictionCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(FrostbiteIndicator), Member = "Update")]
	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostbiteRiskAfflictionCount")]
	[CalledBy(Type = typeof(Frostbite), Member = "GetFrostBiteRiskLocation")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetFrostbiteRiskValue(int location)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[CallsUnknownMethods(Count = 3)]
	public AfflictionBodyArea GetFrostBiteRiskLocation(int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[CallsUnknownMethods(Count = 3)]
	public AfflictionBodyArea GetFrostBiteLocation(int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSuppressFrostbite(bool suppress)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool GetSuppressFrostbite()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool LocationIsIgnored(int location)
	{
		return false;
	}

	[CalledBy(Type = typeof(Frostbite), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Frostbite), Member = "GetXPModeMultiplier")]
	[Calls(Type = typeof(PlayerManager), Member = "RegionHasFullFrozenInnerLayer")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[Calls(Type = typeof(PlayerManager), Member = "RegionHasNonFrozenClothing")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateFrostbite()
	{
	}

	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Frostbite), Member = "GetXPModeMultiplier")]
	[Calls(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToLocation")]
	private void DealFrostbiteDamageToRegion(float damageValue, ClothingRegion region)
	{
	}

	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private void DealFrostbiteDamageToLocation(float damageValue, AfflictionBodyArea bodyArea)
	{
	}

	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(Rest), Member = "GetBedWarmthBonusCelsius")]
	[Calls(Type = typeof(PassTime), Member = "GetBedWarmthBonusCelsius")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "GetCurrentWindchill")]
	[CallsUnknownMethods(Count = 4)]
	private float CalculateBodyTemperatureWithoutClothing()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CalledBy(Type = typeof(Frostbite), Member = "DealFrostbiteDamageToRegion")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private float GetXPModeMultiplier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[CallsUnknownMethods(Count = 22)]
	public Frostbite()
	{
	}
}
