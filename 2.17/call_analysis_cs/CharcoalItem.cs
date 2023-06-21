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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
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
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[Calls(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsFullMoon")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Weather), Member = "IsElectrostaticFog")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[CallsUnknownMethods(Count = 10)]
	public static bool HasSurveyVisibility(float extendedHoursBonus)
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "CanTransitionToState")]
	[Calls(Type = typeof(Weather), Member = "CanSurveyEnvironment")]
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
	[CallsUnknownMethods(Count = 4)]
	public void StartDetailSurvey()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void CancelDetailSurvey()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[Calls(Type = typeof(CharcoalItem), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DetailSurveyComplete()
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
