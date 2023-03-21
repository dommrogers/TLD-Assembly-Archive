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
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	public void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(State), Member = "SetValue")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ActivateStage")]
	[CalledBy(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SendWeatherStateToWise")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void Activate(float startAtFrac, WeatherStage previousStage)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "OnDisable")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "UpdateWeatherSet")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "Deactivate")]
	[CalledBy(Type = typeof(SceneWeatherOverride), Member = "Awake")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(WeatherSet), Member = "Update")]
	public void Deactivate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[CalledBy(Type = typeof(WeatherSet), Member = "Update")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "UpdateWeatherSet")]
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
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 2)]
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
