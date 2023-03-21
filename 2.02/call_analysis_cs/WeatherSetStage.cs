using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class WeatherSetStage
{
	public WeatherStage m_WeatherType;

	public Vector2 m_DurationMinMax;

	public Vector2 m_TransitionTimeMinMax;

	public string m_StingerAudio;

	public float m_StingerAudioDelaySeconds;

	public float m_CurrentDuration;

	public float m_CurrentTransitionTime;

	public float m_ElapsedTime;

	public bool m_PlayedStinger;

	private WeatherStage m_PreviousType;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Activate(float startAtFrac, WeatherStage previousStage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "MaybePlayStinger")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float Update(float todTimeStep)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void ForceComplete()
	{
	}

	[CalledBy(Type = typeof(WeatherSet), Member = "GetDebugString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	public string GetDebugString(int setIndex, bool isCurrent)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public WeatherSetStage()
	{
	}
}
