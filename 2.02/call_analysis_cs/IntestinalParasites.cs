using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IntestinalParasites : MonoBehaviour
{
	public float m_InfectionRollMinHours;

	public float m_InfectionRollMaxHours;

	public int m_NumDosesRequiredPilgrim;

	public int m_NumDosesRequiredVoyageur;

	public int m_NumDosesRequiredStalker;

	public int m_NumDosesRequiredStory;

	public int m_NumDosesRequiredInterloper;

	public float m_ChanceReductionPerDay;

	public float m_MaxHitPointReductionPerDay;

	public float m_MaxFatigueReductionPerDay;

	public string m_ParasitesVO;

	private bool m_HasParasites;

	private bool m_HasParasiteRisk;

	private float m_ParasitesElapsedHours;

	private float m_RiskElapsedHours;

	private float m_RiskDurationHours;

	private int m_NumDosesTaken;

	private bool m_HasTakenDoseToday;

	private float m_CurrentInfectionChance;

	private int m_DayToAllowNextDose;

	private int m_NumPiecesEatenThisRiskCycle;

	private bool m_StartHasBeenCalled;

	private static IntestinalParasitesSaveDataProxy m_IntestinalParasitesSaveDataProxy;

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "CheckForInfection")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_risk")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_risk_nofx")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void AddRiskPercent(float[] riskToAdd, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(IntestinalParasites), Member = "CheckForInfection")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_nofx")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void IntestinalParasitesStart(bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(IntestinalParasites), Member = "Update")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "TakeAntibiotics")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "UpdateIntestinalParasites")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_cure")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void IntestinalParasitesEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasIntestinalParasites()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool HasIntestinalParasitesRisk()
	{
		return false;
	}

	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetCurrentRisk()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	public void TakeAntibiotics()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetNumDosesTaken()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	public int GetNumDosesRemaining()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public bool HasTakenDoseToday()
	{
		return false;
	}

	[CalledBy(Type = typeof(IntestinalParasites), Member = "Update")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "TakeAntibiotics")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "GetNumDosesRemaining")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "UpdateIntestinalParasites")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_nofx")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumDosesRequired()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public float GetTotalHitPointReduction()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetTotalFatigueReduction()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(IntestinalParasites), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void CheckForInfection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateIntestinalParasites()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	private void RestartRiskTimer()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public IntestinalParasites()
	{
	}
}
