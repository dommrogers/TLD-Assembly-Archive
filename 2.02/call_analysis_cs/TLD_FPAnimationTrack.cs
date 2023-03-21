using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Timeline;

public class TLD_FPAnimationTrack : TLD_SpawnedAnimationTrack, TLD_IFPAnchoredTrack
{
	private Transform m_FPAnchor;

	private bool m_HasUpdatedLayer;

	private bool m_HasInitializedExitValues;

	private Quaternion m_ExitStartRootObjectOriginalRotation;

	[CallerCount(Count = 0)]
	public void SetFPAnchor(Transform anchor)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "HasFPAnchor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void PlayInternal()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected override void UpdateSpawnedObjectRootTransformAndParent()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(TLD_FPAnimationTrack), Member = "UpdateRotationExit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetNextEndTime")]
	private void MaybeUpdateTransitionOut()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private void UpdateRotationExit(float progress)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	public TLD_FPAnimationTrack()
	{
	}
}
