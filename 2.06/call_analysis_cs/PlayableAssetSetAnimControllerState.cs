using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetSetAnimControllerState : PlayableAsset
{
	public string m_StateName;

	private TLD_SetControllerStateTrack m_Track;

	public string m_ControllerAssetName;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptPlayable<>), Member = "Create")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetObject")]
	[CallsUnknownMethods(Count = 3)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 53)]
	public void SetTrack(TLD_SetControllerStateTrack track)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 27)]
	public TLD_SetControllerStateTrack GetTrack()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetSetAnimControllerState()
	{
	}
}
