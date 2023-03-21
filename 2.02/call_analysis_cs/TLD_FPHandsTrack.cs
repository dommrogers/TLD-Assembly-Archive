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
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Calls(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_FPHandsTrack), Member = "RemoveBlending")]
	public void Play()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(TimelineClip), Member = "get_easeInDuration")]
	[Calls(Type = typeof(TimelineClip), Member = "set_easeInDuration")]
	[Calls(Type = typeof(TimelineClip), Member = "get_easeOutDuration")]
	[Calls(Type = typeof(TimelineClip), Member = "set_easeOutDuration")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Play")]
	[CallsUnknownMethods(Count = 8)]
	public void RemoveBlending()
	{
	}

	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Play")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "SetFPAnchor")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	public void UpdatePlay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void LateUpdatePlay()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
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
