using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class WeatherSetStage
{
	public WeatherStage m_WeatherType;

	public Vector2 m_DurationMinMax;

	public Vector2 m_TransitionTimeMinMax;

	public AK.Wwise.Event m_StartAudio;

	public AK.Wwise.Event m_StopAudio;

	public State m_AudioState;

	public float m_CurrentDuration;

	public float m_CurrentTransitionTime;

	public float m_ElapsedTime;

	private WeatherStage m_PreviousType;

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ActivateStage")]
	[Calls(Type = typeof(State), Member = "SetValue")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SendWeatherStateToWise")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Activate(float startAtFrac, WeatherStage previousStage)
	{
	}

	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(SceneWeatherOverride), Member = "Awake")]
	[CalledBy(Type = typeof(WeatherSet), Member = "Update")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "Deactivate")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "UpdateWeatherSet")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "OnDisable")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 2)]
	public void Deactivate()
	{
	}

	[CalledBy(Type = typeof(WeatherSetData), Member = "UpdateWeatherSet")]
	[CalledBy(Type = typeof(WeatherSet), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	public float Update(float todTimeStep)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void ForceComplete()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetDebugString")]
	[CalledBy(Type = typeof(WeatherSet), Member = "GetDebugString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Format")]
	public string GetDebugString(int setIndex, bool isCurrent)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public WeatherSetStage()
	{
	}
}
