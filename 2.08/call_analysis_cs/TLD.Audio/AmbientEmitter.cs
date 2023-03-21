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
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "MaybePlayRandomLoop")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	private void PlayRandomLoop()
	{
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "MaybePlayRandomClip")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWindFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 2)]
	private void PlayRandomClip()
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybePlayRandomClip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	private void MaybePlayRandomLoop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	private void AdjustLoopForTimeOfDay()
	{
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "AdjustLoopForTimeOfDay")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	private bool PassesTimeOfDayFilter(TimeOfDayFilterEnum tod)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "AdjustLoopForTimeOfDay")]
	[CallsUnknownMethods(Count = 2)]
	private bool PassesWeatherFilter(WeatherFilterEnum weather)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	private bool PassesWindFilter(WindFilterEnum wind)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public AmbientEmitter()
	{
	}
}
