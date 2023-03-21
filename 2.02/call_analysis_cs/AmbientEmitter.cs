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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[Calls(Type = typeof(AmbientEmitter), Member = "AdjustLoopForTimeOfDay")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "MaybePlayRandomLoop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 25)]
	private void PlayRandomLoop()
	{
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "MaybePlayRandomClip")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWindFilter")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(TypeFullName = "System.Number", Member = "FormatUInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 47)]
	private void PlayRandomClip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybePlayRandomClip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	private void MaybePlayRandomLoop()
	{
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesTimeOfDayFilter")]
	[Calls(Type = typeof(AmbientEmitter), Member = "PassesWeatherFilter")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void AdjustLoopForTimeOfDay()
	{
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "AdjustLoopForTimeOfDay")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool PassesTimeOfDayFilter(TimeOfDayFilterEnum tod)
	{
		return false;
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "AdjustLoopForTimeOfDay")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool PassesWeatherFilter(WeatherFilterEnum weather)
	{
		return false;
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool PassesWindFilter(WindFilterEnum wind)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AmbientEmitter()
	{
	}
}
