using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class IntestinalParasites : MonoBehaviour
{
	public float m_InfectionRollMinHours;

	public float m_InfectionRollMaxHours;

	public float m_ChanceReductionPerDay;

	public float m_MaxHitPointReductionPerDay;

	public float m_MaxFatigueReductionPerDay;

	public string m_ParasitesVO;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(IntestinalParasites), Member = "CheckForInfection")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_risk_nofx")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_risk")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallsUnknownMethods(Count = 1)]
	public void AddRiskPercent(float[] riskToAdd, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "CheckForInfection")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_nofx")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	public void IntestinalParasitesStart(bool nofx = false)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "UpdateIntestinalParasites")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "Update")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "TakeAntibiotics")]
	public void IntestinalParasitesEnd()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasIntestinalParasites()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasIntestinalParasitesRisk()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	public int GetCurrentRisk()
	{
		return default(int);
	}

	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[CallerCount(Count = 0)]
	public void TakeAntibiotics()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetNumDosesTaken()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_parasites")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "UpdateIntestinalParasites")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "GetNumDosesRemaining")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "TakeAntibiotics")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "Update")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "Update")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	private void CheckForInfection()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateIntestinalParasites()
	{
	}

	[Calls(Type = typeof(Random), Member = "Range")]
	[CallerCount(Count = 0)]
	private void RestartRiskTimer()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public IntestinalParasites()
	{
	}
}
