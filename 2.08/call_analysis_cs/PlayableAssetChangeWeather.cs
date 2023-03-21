using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetChangeWeather : PlayableAsset
{
	public enum TransitionType
	{
		Instant,
		Fade
	}

	public WeatherStage m_TargetWeatherType;

	public TransitionType m_TransitionType;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetChangeWeather()
	{
	}
}
