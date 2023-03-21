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
		[CallerCount(Count = 13)]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InfectionRisk), Member = "UpdateInfectionRisk")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	public void Update()
	{
	}

	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 38)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
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
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BearFadeFinish")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_infection_risk_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_infection_risk_constant")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CalledBy(Type = typeof(RiskOfInfectionEvent), Member = "OnExecute")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(InfectionRisk), Member = "ConstantInfectionRiskStart")]
	public void InfectionRiskStart(string cause, AfflictionBodyArea area, bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(InfectionRisk), Member = "TakeAntiseptic")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(InfectionRisk), Member = "CheckForInfection")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 2)]
	public void InfectionRiskEnd(int index)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_infection_risk_cure")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	public void Cure()
	{
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Condition), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 1)]
	public bool HasInfectionRisk()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	public int GetCurrentRisk(int index)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
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

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "ApplyAntisepticToLocation")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskEnd")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void TakeAntiseptic(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public int GetIndexFromLocation(AfflictionBodyArea area)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InfectionRisk), Member = "TakeAntiseptic")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyAntisepticToLocation(AfflictionBodyArea area)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RequiresAntiseptic")]
	[CallerCount(Count = 3)]
	public bool RequiresAntiseptic(int index)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InfectionRisk), Member = "UpdateInfectionRisk")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskEnd")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Infection), Member = "InfectionStart")]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "Update")]
	[Calls(Type = typeof(InfectionRisk), Member = "CheckForInfection")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	private void UpdateInfectionRisk(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 48)]
	public InfectionRisk()
	{
	}
}
