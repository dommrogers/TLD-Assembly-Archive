using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_FPHandsTrack : AnimationTrack, TLD_IDynamicBindableTrack, TLD_ITrack
{
	public bool m_CameraRelativeTransforms;

	public bool m_HoldSettingsForNextTimeline;

	private bool m_SetHandLayer;

	private TLD_TimelineDirector m_TimelineDirector;

	private PlayerAnimation m_PlayerAnimation;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_FPHandsTrack), Member = "RemoveBlending")]
	[Calls(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CallsUnknownMethods(Count = 1)]
	public void Play()
	{
	}

	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(TimelineClip), Member = "get_easeInDuration")]
	[Calls(Type = typeof(TimelineClip), Member = "set_easeInDuration")]
	[Calls(Type = typeof(TimelineClip), Member = "get_easeOutDuration")]
	[Calls(Type = typeof(TimelineClip), Member = "set_easeOutDuration")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void RemoveBlending()
	{
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "SetFPAnchor")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Play")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 25)]
	public void UpdatePlay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void LateUpdatePlay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 20)]
	public void Stop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	public TLD_FPHandsTrack()
	{
	}
}
