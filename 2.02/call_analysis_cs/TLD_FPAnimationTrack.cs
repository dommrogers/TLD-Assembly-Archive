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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "HasFPAnchor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected override void PlayInternal()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected override void UpdateSpawnedObjectRootTransformAndParent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetNextEndTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(TLD_FPAnimationTrack), Member = "UpdateRotationExit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeUpdateTransitionOut()
	{
	}

	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateRotationExit(float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public TLD_FPAnimationTrack()
	{
	}
}
