using System;
using System.Globalization;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Audio;

public class AmbientEmitter : MonoBehaviour
{
	[Serializable]
	public struct AmbientClip
	{
		public AK.Wwise.Event m_Event;

		public TimeOfDayFilterEnum m_Filter;

		public WeatherFilterEnum m_WeatherFilter;

		public WindFilterEnum m_WindFilter;
	}

	[Serializable]
	public struct AmbientLoop
	{
		public AK.Wwise.Event m_Event;

		public TimeOfDayFilterEnum m_Filter;

		public WeatherFilterEnum m_WeatherFilter;
	}

	public AmbientClip[] m_AmbientClips;

	public AmbientLoop[] m_AmbientLoops;

	public float m_ClipMinDelay;

	public float m_ClipMaxDelay;

	public string[] m_Clips;

	public TimeOfDayFilterEnum[] m_ClipFilter;

	public WeatherFilterEnum[] m_ClipWeatherFilter;

	public WindFilterEnum[] m_ClipWindFilter;

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

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "MaybePlayRandomLoop")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	private void PlayRandomLoop()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "MaybePlayRandomClip")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWindFilter")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void PlayRandomClip()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybePlayRandomClip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	private void MaybePlayRandomLoop()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	private void AdjustLoopForTimeOfDay()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "AdjustLoopForTimeOfDay")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	private bool PassesTimeOfDayFilter(TimeOfDayFilterEnum tod)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "AdjustLoopForTimeOfDay")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	private bool PassesWeatherFilter(WeatherFilterEnum weather)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CallsUnknownMethods(Count = 2)]
	private bool PassesWindFilter(WindFilterEnum wind)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public AmbientEmitter()
	{
	}
}
