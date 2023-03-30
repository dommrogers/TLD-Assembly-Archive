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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ActivateStage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SendWeatherStateToWise")]
	[Calls(Type = typeof(State), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Activate(float startAtFrac, WeatherStage previousStage)
	{
	}

	[CalledBy(Type = typeof(SceneWeatherOverride), Member = "Awake")]
	[CalledBy(Type = typeof(WeatherSet), Member = "Update")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "Deactivate")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "UpdateWeatherSet")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "OnDisable")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Deactivate()
	{
	}

	[CalledBy(Type = typeof(WeatherSet), Member = "Update")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "UpdateWeatherSet")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[CallsUnknownMethods(Count = 1)]
	public float Update(float todTimeStep)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void ForceComplete()
	{
	}

	[CalledBy(Type = typeof(WeatherSet), Member = "GetDebugString")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetDebugString")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 25)]
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
