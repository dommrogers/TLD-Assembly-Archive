using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Playables;

[Serializable]
public class PlayableBehaviourChangeWeather : PlayableBehaviour
{
	public WeatherStage m_TargetWeatherType;

	public PlayableAssetChangeWeather.TransitionType m_TransitionType;

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(Weather), Member = "KillWeatherParticles")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Calls(Type = typeof(Weather), Member = "KillWeatherParticles")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PlayableBehaviourChangeWeather()
	{
	}
}
