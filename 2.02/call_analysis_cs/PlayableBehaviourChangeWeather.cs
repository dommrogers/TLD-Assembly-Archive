using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Playables;

[Serializable]
public class PlayableBehaviourChangeWeather : PlayableBehaviour
{
	public WeatherStage m_TargetWeatherType;

	public PlayableAssetChangeWeather.TransitionType m_TransitionType;

	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(Weather), Member = "KillWeatherParticles")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "KillWeatherParticles")]
	[CallsUnknownMethods(Count = 2)]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlayableBehaviourChangeWeather()
	{
	}
}
