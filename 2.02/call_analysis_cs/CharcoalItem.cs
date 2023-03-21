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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetSurveyRealSeconds()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetSurveyGameMinutes()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetSurveyExtendedTimeSkillBonus()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(CharcoalItem), Member = "ConsumeCharcoal")]
	[Calls(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(CharcoalItem), Member = "StopSurveyAudio")]
	[Calls(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsDenseFog")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Weather), Member = "IsFullMoon")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	public static bool HasSurveyVisibility(float extendedHoursBonus)
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "CanTransitionToState")]
	[Calls(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void StartDetailSurvey()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(CharcoalItem), Member = "StopSurveyAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void CancelDetailSurvey()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CharcoalItem), Member = "ConsumeCharcoal")]
	[Calls(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(CharcoalItem), Member = "StopSurveyAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void DetailSurveyComplete()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void AccelerateTimeOfDay()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void ConsumeCharcoal()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StopSurveyAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CharcoalItem()
	{
	}
}
