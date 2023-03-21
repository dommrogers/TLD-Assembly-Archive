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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[CallsUnknownMethods(Count = 1)]
	private bool HasFearOrAnxiety()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(PassTime), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedHours")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BrokenRib), Member = "AddRest")]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[Calls(Type = typeof(PlayerManager), Member = "InHibernationPreventionIndoorEnvironment")]
	private void UpdatePassingTime()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_pass_time")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoPassTime")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpSnow")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "Restart")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void Begin(float hours, Bed bed)
	{
	}

	[CalledBy(Type = typeof(PassTime), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "OnCancel")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Bed), Member = "Degrade")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedHours")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsPassingTime()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallsUnknownMethods(Count = 1)]
	public float GetNumHoursRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "GetWarmthBonusCelsius")]
	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CallsUnknownMethods(Count = 1)]
	public float GetBedWarmthBonusCelsius()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
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
