using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Infection : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_DurationHoursMin;

	public float m_DurationHoursMax;

	public float m_HPDrainPerHour;

	public float m_FatigueIncreasePerHour;

	public GameObject m_AntibioticsPrefab;

	public float m_NumHoursRestForCure;

	public string m_InfectionVO;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private List<string> m_CausesLocIDs;

	private List<int> m_Locations;

	private List<float> m_ElapsedHoursList;

	private List<float> m_DurationHoursList;

	private List<bool> m_AntibioticsTakenList;

	private List<float> m_ElapsedRestList;

	private bool m_StartHasBeenCalled;

	private static InfectionSaveDataProxy m_InfectionSaveDataProxy;

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
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Infection), Member = "UpdateInfection")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 13)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public bool LocationAvailable()
	{
		return false;
	}

	[CalledBy(Type = typeof(InfectionRisk), Member = "CheckForInfection")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_infection")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_infection_nofx")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 9)]
	public void InfectionStart(string causeLocID, int location, bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(Infection), Member = "UpdateInfection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 1)]
	public void InfectionEnd(int index)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_infection_cure")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void Cure()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasInfection()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasUntreatedInfection()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasInfectionNeedingRest()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "RequiresAntibiotic")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasTakenAntibiotics(int index)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRestAmountRemaining(int index)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsUnknownMethods(Count = 1)]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetAfflictionCauseLocalizationId(int localAfflictionIndex)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void TakeAntibiotics(int localIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public void AddRest(float hours)
	{
	}

	[CalledBy(Type = typeof(Infection), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Infection), Member = "InfectionEnd")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateInfection(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Infection()
	{
	}
}
