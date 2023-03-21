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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(IntestinalParasites), Member = "CheckForInfection")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[CallsUnknownMethods(Count = 9)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_risk_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_risk")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Random), Member = "Range")]
	public void AddRiskPercent(float[] riskToAdd, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(IntestinalParasites), Member = "CheckForInfection")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void IntestinalParasitesStart(bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "UpdateIntestinalParasites")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "TakeAntibiotics")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "Update")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_cure")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	public void IntestinalParasitesEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasIntestinalParasites()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasIntestinalParasitesRisk()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 2)]
	public int GetCurrentRisk()
	{
		return default(int);
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
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	public int GetNumDosesRemaining()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public bool HasTakenDoseToday()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(IntestinalParasites), Member = "UpdateIntestinalParasites")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "GetNumDosesRemaining")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "TakeAntibiotics")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	public int GetNumDosesRequired()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public float GetTotalHitPointReduction()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetTotalFatigueReduction()
	{
		return default(float);
	}

	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 4)]
	private void CheckForInfection()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[CallerCount(Count = 0)]
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
