using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private PanelReference<Panel_HUD> m_HUD;

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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Thirst), Member = "UpdateThirstStatusOnHUD")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Thirst), Member = "MaybePlayPlayerThirstVoiceOver")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	public string GetThirstStateString()
	{
		return null;
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[CalledBy(Type = typeof(Thirst), Member = "UpdateAddThirstOverTime")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateDysentery")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallsUnknownMethods(Count = 1)]
	public void AddThirst(float thirstValue)
	{
	}

	[CallerCount(Count = 0)]
	public void AddThirstOverTime(float litersToDrink, float timeSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void ClearAddThirstOverTime()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
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

	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	private bool ShouldPlayThirstVoiceOver()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
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
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetThirstTextForHud()
	{
		return null;
	}

	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void MaybeUpdateThirstStatusLabel(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAddThirstOverTime()
	{
	}

	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateThirstStatusOnHUD(Panel_HUD hud)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void MaybeUpdateDehydratedStatusInLog()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Thirst()
	{
	}
}
