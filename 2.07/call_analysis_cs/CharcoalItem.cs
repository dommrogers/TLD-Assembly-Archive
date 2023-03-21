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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[Calls(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Weather), Member = "IsElectrostaticFog")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "IsFullMoon")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsFullMoon")]
	public static bool HasSurveyVisibility(float extendedHoursBonus)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[Calls(Type = typeof(PlayerAnimation), Member = "CanTransitionToState")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(Weather), Member = "CanSurveyEnvironment")]
	public void StartDetailSurvey()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	public void CancelDetailSurvey()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	private void DetailSurveyComplete()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallerCount(Count = 2)]
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

	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsUnknownMethods(Count = 3)]
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
