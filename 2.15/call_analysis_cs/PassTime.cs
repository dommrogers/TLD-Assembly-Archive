using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PassTime : MonoBehaviour
{
	public float m_PassTimeRealtimeSecondsPerHour;

	public string m_PassTimeAudio;

	private HighResolutionTimer m_Timer;

	private float m_LastTimerHours;

	private ulong m_PassTimeDurationMilliseconds;

	private bool m_TimeAccelerated;

	private float m_DayLengthScaleOriginal;

	private uint m_PassTimeAudioInstance;

	private Bed m_Bed;

	private bool m_SkipSave;

	private bool m_SuppressAudio;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[CallsUnknownMethods(Count = 1)]
	private bool HasFearOrAnxiety()
	{
		return false;
	}

	[CalledBy(Type = typeof(PassTime), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "InHibernationPreventionIndoorEnvironment")]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedHours")]
	[Calls(Type = typeof(BrokenRib), Member = "AddRest")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdatePassingTime()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpSnow")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoPassTime")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_pass_time")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "Restart")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Begin(float hours, Bed bed)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(PassTime), Member = "Update")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "OnCancel")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedHours")]
	[Calls(Type = typeof(Bed), Member = "Degrade")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallsUnknownMethods(Count = 2)]
	public void End()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSuppressAudio(bool shouldSuppress)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSkipSaveFlag()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsPassingTime()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallsUnknownMethods(Count = 1)]
	public float GetNumHoursRemaining()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "GetWarmthBonusCelsius")]
	[CallsUnknownMethods(Count = 1)]
	public float GetBedWarmthBonusCelsius()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 1)]
	private void AccelerateTimeOfDay(float hours)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public PassTime()
	{
	}
}
