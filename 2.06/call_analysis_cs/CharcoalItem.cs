using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class CharcoalItem : MonoBehaviour
{
	public static CharcoalItem m_CharcoalItemInUseForSurvey;

	public float m_SurveyGameMinutes;

	public float m_SurveyRealSeconds;

	public float m_SurveySkillExtendedHours;

	public string m_SurveyLoopAudio;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Map> m_Map;

	private GearItem m_GearItem;

	private bool m_IsActive;

	private bool m_TimeAccelerated;

	private float m_DayLengthScaleBeforeSurveying;

	private float m_TimeSpentSurveying;

	private uint m_SurveyAudioID;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetSurveyRealSeconds()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetSurveyGameMinutes()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetSurveyExtendedTimeSkillBonus()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[Calls(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[Calls(Type = typeof(Weather), Member = "IsFullMoon")]
	[Calls(Type = typeof(Weather), Member = "IsElectrostaticFog")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "IsFullMoon")]
	[CallerCount(Count = 3)]
	public static bool HasSurveyVisibility(float extendedHoursBonus)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[Calls(Type = typeof(Weather), Member = "CanSurveyEnvironment")]
	[Calls(Type = typeof(PlayerAnimation), Member = "CanTransitionToState")]
	[CallerCount(Count = 1)]
	public void StartDetailSurvey()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void CancelDetailSurvey()
	{
	}

	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	private void DetailSurveyComplete()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 1)]
	private void AccelerateTimeOfDay()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void ConsumeCharcoal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopSurveyAudio()
	{
	}

	[CallerCount(Count = 0)]
	public CharcoalItem()
	{
	}
}
