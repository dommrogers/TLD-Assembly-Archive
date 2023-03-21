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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptPlayable<>), Member = "Create")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
