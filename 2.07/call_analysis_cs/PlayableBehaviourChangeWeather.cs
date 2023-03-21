using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Playables;

[Serializable]
public class PlayableBehaviourChangeWeather : PlayableBehaviour
{
	public WeatherStage m_TargetWeatherType;

	public PlayableAssetChangeWeather.TransitionType m_TransitionType;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(Weather), Member = "KillWeatherParticles")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CallsUnknownMethods(Count = 5)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "KillWeatherParticles")]
	[CallsUnknownMethods(Count = 2)]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayableBehaviourChangeWeather()
	{
	}
}
