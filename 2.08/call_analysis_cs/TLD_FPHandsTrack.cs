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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Play")]
	[Calls(Type = typeof(TimelineClip), Member = "set_easeOutDuration")]
	[Calls(Type = typeof(TimelineClip), Member = "get_easeOutDuration")]
	[Calls(Type = typeof(TimelineClip), Member = "get_easeInDuration")]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimelineClip), Member = "set_easeInDuration")]
	public void RemoveBlending()
	{
	}

	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Play")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "SetFPAnchor")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	public void UpdatePlay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LateUpdatePlay()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetLayerOnObjectRecursively")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	public TLD_FPHandsTrack()
	{
	}
}
