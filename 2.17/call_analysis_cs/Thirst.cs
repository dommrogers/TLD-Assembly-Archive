using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
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
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[Calls(Type = typeof(Thirst), Member = "MaybePlayPlayerThirstVoiceOver")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(Thirst), Member = "UpdateThirstStatusOnHUD")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public string GetThirstStateString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[CalledBy(Type = typeof(Thirst), Member = "UpdateAddThirstOverTime")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateDysentery")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CalledBy(Type = typeof(FoodStatEffect), Member = "Apply")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
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

	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	private bool ShouldPlayThirstVoiceOver()
	{
		return false;
	}

	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 5)]
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
	private string GetThirstTextForHud()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeUpdateThirstStatusLabel(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAddThirstOverTime()
	{
	}

	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateThirstStatusOnHUD(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeUpdateDehydratedStatusInLog()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Thirst()
	{
	}
}
