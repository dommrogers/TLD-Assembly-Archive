using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AmbientEmitter : MonoBehaviour
{
	public string[] m_Clips;

	public int[] m_ClipWeights;

	public TimeOfDayFilterEnum[] m_ClipFilter;

	public WeatherFilterEnum[] m_ClipWeatherFilter;

	public WindFilterEnum[] m_ClipWindFilter;

	public float m_ClipMinDelay;

	public float m_ClipMaxDelay;

	public string[] m_Loops;

	public TimeOfDayFilterEnum[] m_LoopFilter;

	public WeatherFilterEnum[] m_LoopWeatherFilter;

	public bool m_DebugLoggingEnabled;

	public float m_InnerRadius;

	public float m_OuterRadius;

	private bool m_ClipAudioPending;

	private int m_LoopAudioCurrentIndex;

	private float m_TimeToPlayNextClip;

	private uint m_PlayingLoopID;

	private bool m_FirstUpdate;

	private static int MAX_CANDIDATES;

	private static int[] m_CandidatesBuffer;

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[Calls(Type = typeof(AmbientEmitter), Member = "AdjustLoopForTimeOfDay")]
	[Calls(Type = typeof(AmbientEmitter), Member = "AdjustLoopForTimeOfDay")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "MaybePlayRandomLoop")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	private void PlayRandomLoop()
	{
	}

	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWindFilter")]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "MaybePlayRandomClip")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private void PlayRandomClip()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void MaybePlayRandomClip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	private void MaybePlayRandomLoop()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void AdjustLoopForTimeOfDay()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "AdjustLoopForTimeOfDay")]
	private bool PassesTimeOfDayFilter(TimeOfDayFilterEnum tod)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "AdjustLoopForTimeOfDay")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	private bool PassesWeatherFilter(WeatherFilterEnum weather)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool PassesWindFilter(WindFilterEnum wind)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public AmbientEmitter()
	{
	}
}
