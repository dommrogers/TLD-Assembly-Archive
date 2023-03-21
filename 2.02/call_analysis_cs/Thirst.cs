using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Thirst : MonoBehaviour
{
	public float m_ThirstQuenchedPerLiter;

	public float m_CurrentThirst;

	public float m_MaxThirst;

	public float m_ThirstIncreasePerDay;

	public float m_ThirstIncreasePerDayWhenResting;

	public float m_SlightlyThirstyThreshold;

	public float m_ThirstyThreshold;

	public float m_VeryThirstyThreshold;

	public float m_DehydratedThreshold;

	public string m_SlightlyThirstyVoiceOver;

	public string m_ThirstyVoiceOver;

	public string m_VeryThirstyVoiceOver;

	public string m_DehydratedVoiceOver;

	public float m_MinSecondsBetweenVoiceOverVariations;

	public float m_TimeToDisplayThirstWhenChanged;

	private ThirstLevel m_ThirstLevelForPreviousVoiceOver;

	private float m_NumSecondsSinceLastVoiceOver;

	private float m_TimeDisableThirstOnHUD;

	private int m_ThirstLevelLastStatusChange;

	private bool m_DehydratedInLog;

	private float m_LitersToDrinkOverTime;

	private float m_LitersLeftToDrink;

	private float m_LitersToDrinkOverTimeDuration;

	private bool m_StartHasBeenCalled;

	private bool m_SuppressVoiceOver;

	private static ThirstSaveDataProxy m_ThirstSaveDataProxy;

	[CalledBy(Type = typeof(Thirst), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Thirst), Member = "UpdateAddThirstOverTime")]
	[Calls(Type = typeof(Thirst), Member = "MaybePlayPlayerThirstVoiceOver")]
	[Calls(Type = typeof(Thirst), Member = "MaybeUpdateDehydratedStatusInLog")]
	[Calls(Type = typeof(Thirst), Member = "UpdateThirstStatusOnHUD")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thirst), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public string GetThirstStateString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[CalledBy(Type = typeof(Thirst), Member = "UpdateAddThirstOverTime")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateDysentery")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddThirst(float thirstValue)
	{
	}

	[CallerCount(Count = 0)]
	public void AddThirstOverTime(float litersToDrink, float timeSeconds)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ClearAddThirstOverTime()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsAddingThirstOverTime()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsDehydrated()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsVeryThirsty()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldPlayThirstVoiceOver()
	{
		return false;
	}

	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void MaybePlayPlayerThirstVoiceOver()
	{
	}

	[CallerCount(Count = 0)]
	private ThirstLevel GetThirstLevel()
	{
		return default(ThirstLevel);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void DisplayThirstOnHUDForTime(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetThirstTextForHud()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeUpdateThirstStatusLabel()
	{
	}

	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAddThirstOverTime()
	{
	}

	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 37)]
	private void UpdateThirstStatusOnHUD()
	{
	}

	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUpdateDehydratedStatusInLog()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Thirst()
	{
	}
}
