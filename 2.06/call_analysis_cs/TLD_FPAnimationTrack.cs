using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Timeline;

public class TLD_FPAnimationTrack : TLD_SpawnedAnimationTrack, TLD_IFPAnchoredTrack
{
	private Transform m_FPAnchor;

	private bool m_HasUpdatedLayer;

	private bool m_HasInitializedExitValues;

	private Quaternion m_ExitStartRootObjectOriginalRotation;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetFPAnchor(Transform anchor)
	{
	}

	[Calls(Type = typeof(TLD_TimelineDirector), Member = "HasFPAnchor")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	protected override void PlayInternal()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected override void UpdateSpawnedObjectRootTransformAndParent()
	{
	}

	[Calls(Type = typeof(TLD_FPAnimationTrack), Member = "UpdateRotationExit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetNextEndTime")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUpdateTransitionOut()
	{
	}

	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void UpdateRotationExit(float progress)
	{
	}

	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TLD_FPAnimationTrack()
	{
	}
}
