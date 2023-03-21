using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SplineAudioClip : MonoBehaviour
{
	public string m_SoundID;

	public Spline m_Spline;

	private int m_StartAudioFrameCountdown;

	private Utils.FastSpline m_FastSpline;

	private bool m_ClosestPointOnSplineRequested;

	private int m_JobIndex;

	private bool m_CanUseJobSystem;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetValidNodesCount")]
	[Calls(Type = typeof(SplineManager), Member = "RegisterStaticSplineAudioClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineAudioClip), Member = "DisableSplineMeshUpdating")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EarlyUpdate()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[Calls(Type = typeof(SplineManager), Member = "RequestSplineClosestPositionJob")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void RequestClosestPointOnSpline()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "Update")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void PlaySplineAudioClip()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void DisableSplineMeshUpdating()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineAudioClip), Member = "UpdateSplineAudioClipPosition_Legacy")]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Spline), Member = "GetClosestPointParam")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	public void UpdateSplineAudioClipPosition_Legacy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineAudioClip), Member = "FetchClosestPointOnSplineResult")]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	public void ManualUpdate()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SplineManager), Member = "RetrieveSplineClosestPosition")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void FetchClosestPointOnSplineResult()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineManager), Member = "GetMatrix")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Allocate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	public void Terminate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SplineAudioClip()
	{
	}
}
