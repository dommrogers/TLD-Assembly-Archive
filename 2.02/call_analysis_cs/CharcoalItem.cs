using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CharcoalItem : MonoBehaviour
{
	public static CharcoalItem m_CharcoalItemInUseForSurvey;

	public float m_SurveyGameMinutes;

	public float m_SurveyRealSeconds;

	public float m_SurveySkillExtendedHours;

	public string m_SurveyLoopAudio;

	private GearItem m_GearItem;

	private bool m_IsActive;

	private bool m_TimeAccelerated;

	private float m_DayLengthScaleBeforeSurveying;

	private float m_TimeSpentSurveying;

	private uint m_SurveyAudioID;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[Calls(Type = typeof(CharcoalItem), Member = "StopSurveyAudio")]
	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[Calls(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CharcoalItem), Member = "ConsumeCharcoal")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[Calls(Type = typeof(Weather), Member = "IsFullMoon")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Weather), Member = "IsDenseFog")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsFullMoon")]
	public static bool HasSurveyVisibility(float extendedHoursBonus)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 10)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	public void StartDetailSurvey()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[Calls(Type = typeof(CharcoalItem), Member = "StopSurveyAudio")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	public void CancelDetailSurvey()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CharcoalItem), Member = "ConsumeCharcoal")]
	[Calls(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(CharcoalItem), Member = "StopSurveyAudio")]
	[CallsUnknownMethods(Count = 1)]
	private void DetailSurveyComplete()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	private void RestoreTimeOfDay()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void AccelerateTimeOfDay()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	private void ConsumeCharcoal()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	private void StopSurveyAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CharcoalItem()
	{
	}
}
