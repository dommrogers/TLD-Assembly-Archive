using System;
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(Thirst), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Thirst), Member = "UpdateAddThirstOverTime")]
	[Calls(Type = typeof(Thirst), Member = "MaybePlayPlayerThirstVoiceOver")]
	[Calls(Type = typeof(Thirst), Member = "MaybeUpdateDehydratedStatusInLog")]
	[Calls(Type = typeof(Thirst), Member = "UpdateThirstStatusOnHUD")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Thirst), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public string GetThirstStateString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Thirst), Member = "UpdateAddThirstOverTime")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateDysentery")]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsDehydrated()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsVeryThirsty()
	{
		return default(bool);
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
		return default(bool);
	}

	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Thirst), Member = "Update")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetThirstTextForHud()
	{
		return null;
	}

	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void MaybeUpdateThirstStatusLabel()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	private void UpdateAddThirstOverTime()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 37)]
	private void UpdateThirstStatusOnHUD()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void MaybeUpdateDehydratedStatusInLog()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public Thirst()
	{
	}
}
