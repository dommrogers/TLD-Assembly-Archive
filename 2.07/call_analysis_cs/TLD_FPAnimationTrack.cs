using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Timeline;

public class TLD_FPAnimationTrack : TLD_SpawnedAnimationTrack, TLD_IFPAnchoredTrack
{
	private Transform m_FPAnchor;

	private bool m_HasUpdatedLayer;

	private bool m_HasInitializedExitValues;

	private Quaternion m_ExitStartRootObjectOriginalRotation;

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void SetFPAnchor(Transform anchor)
	{
	}

	[Calls(Type = typeof(TLD_TimelineDirector), Member = "HasFPAnchor")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	protected override void PlayInternal()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	protected override void UpdateSpawnedObjectRootTransformAndParent()
	{
	}

	[Calls(Type = typeof(TLD_FPAnimationTrack), Member = "UpdateRotationExit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetNextEndTime")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void MaybeUpdateTransitionOut()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	private void UpdateRotationExit(float progress)
	{
	}

	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TLD_FPAnimationTrack()
	{
	}
}
