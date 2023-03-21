using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class FoodPoisoning : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_DurationHoursMin;

	public float m_DurationHoursMax;

	public float m_HPDrainPerHour;

	public float m_FatigueIncreasePerHour;

	public float m_StopDegradingConditionAtPercent;

	public GameObject m_AntibioticsPrefab;

	public float m_NumHoursRestForCure;

	public string m_FoodPoisoningVO;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private bool m_Active;

	private float m_ElapsedHours;

	private float m_DurationHours;

	private bool m_AntibioticsTaken;

	private float m_ElapsedRest;

	private string m_CauseLocID;

	private bool m_StartHasBeenCalled;

	private static FoodPoisoningSaveDataProxy m_FoodPoisoningSaveDataProxy;

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
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
	[Calls(Type = typeof(FoodPoisoning), Member = "UpdateFoodPoisoning")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_food_poison_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_food_poison")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	public void FoodPoisoningStart(string causeId, bool displayIcon, bool nofx = false)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_food_poison_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(FoodPoisoning), Member = "UpdateFoodPoisoning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	public void FoodPoisoningEnd()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasFoodPoisoning()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public bool HasTakenAntibiotics()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public float GetRestAmountRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	public string GetCauseString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void TakeAntibiotics()
	{
	}

	[CallerCount(Count = 0)]
	public void AddRest(float hours)
	{
	}

	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningEnd")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CalledBy(Type = typeof(FoodPoisoning), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateFoodPoisoning()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FoodPoisoning()
	{
	}
}
