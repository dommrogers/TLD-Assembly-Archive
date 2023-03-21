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
	[CallAnalysisFailed]
	public void Update()
	{
	}

	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool HasFearOrAnxiety()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "InHibernationPreventionIndoorEnvironment")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(Anxiety), Member = "CanPassTime")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedHours")]
	[Calls(Type = typeof(BrokenRib), Member = "AddRest")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 12)]
	private void UpdatePassingTime()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_pass_time")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoPassTime")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpSnow")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "Restart")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Begin(float hours, Bed bed)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "OnCancel")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Bed), Member = "Degrade")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedHours")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	public void End()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSuppressAudio(bool shouldSuppress)
	{
	}

	[CallerCount(Count = 0)]
	public void SetSkipSaveFlag()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsPassingTime()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetNumHoursRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "GetWarmthBonusCelsius")]
	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CallsUnknownMethods(Count = 1)]
	public float GetBedWarmthBonusCelsius()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreTimeOfDay()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void AccelerateTimeOfDay(float hours)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public PassTime()
	{
	}
}
