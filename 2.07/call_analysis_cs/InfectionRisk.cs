using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class InfectionRisk : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_InfectionRollMinHours;

	public float m_InfectionRollMaxHours;

	public float m_InfectionBaseChance;

	public float m_InfectionMaxChance;

	public float m_InfectionChanceAntisepticReduction;

	public float m_InfectionChanceIncreasePerHour;

	public GameObject m_BandagePrefab;

	public GameObject m_AntisepticPrefab;

	public float m_CommentDelaySeconds;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private float m_ElapsedHours;

	private float m_DurationHours;

	private bool m_AntisepticTaken;

	private float m_CommentTime;

	private List<string> m_CausesLocIDs;

	private List<int> m_Locations;

	private List<int> m_ConstantAfflictionIndices;

	private List<float> m_ElapsedHoursList;

	private List<float> m_DurationHoursList;

	private List<bool> m_AntisepticTakenList;

	private List<float> m_CurrentInfectionChanceList;

	private bool m_StartHasBeenCalled;

	private static InfectionRiskSaveDataProxy m_InfectionRiskSaveDataProxy;

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

	[Calls(Type = typeof(InfectionRisk), Member = "UpdateInfectionRisk")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 14)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool LocationAvailable()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallsUnknownMethods(Count = 2)]
	public void ConstantInfectionRiskStart(string cause, AfflictionBodyArea area, bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_infection_risk")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_infection_risk_constant")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_infection_risk_nofx")]
	[CalledBy(Type = typeof(RiskOfInfectionEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BearFadeFinish")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(InfectionRisk), Member = "ConstantInfectionRiskStart")]
	public void InfectionRiskStart(string cause, AfflictionBodyArea area, bool displayIcon, bool nofx = false)
	{
	}

	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InfectionRisk), Member = "CheckForInfection")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "TakeAntiseptic")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public void InfectionRiskEnd(int index)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_infection_risk_cure")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	public void Cure()
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Condition), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 1)]
	public bool HasInfectionRisk()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public int GetCurrentRisk(int index)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public int GetAfflictionsCount()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	public string GetAfflictionCauseLocalizationId(int localAfflictionIndex)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskEnd")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "ApplyAntisepticToLocation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CallsUnknownMethods(Count = 2)]
	public void TakeAntiseptic(int index)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public int GetIndexFromLocation(AfflictionBodyArea area)
	{
		return default(int);
	}

	[Calls(Type = typeof(InfectionRisk), Member = "TakeAntiseptic")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ApplyAntisepticToLocation(AfflictionBodyArea area)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RequiresAntiseptic")]
	public bool RequiresAntiseptic(int index)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Infection), Member = "InfectionStart")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskEnd")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "UpdateInfectionRisk")]
	[CallsUnknownMethods(Count = 3)]
	private void CheckForInfection(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsConstant(int index)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InfectionRisk), Member = "CheckForInfection")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "Update")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[CallerCount(Count = 1)]
	private void UpdateInfectionRisk(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public InfectionRisk()
	{
	}
}
