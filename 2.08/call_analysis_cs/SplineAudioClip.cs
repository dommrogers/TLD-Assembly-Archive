using System;
using Cpp2ILInjected.CallAnalysis;
using SuperSplines;
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetValidNodesCount")]
	[Calls(Type = typeof(SplineAudioClip), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	public void EarlyUpdate()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	private void RequestClosestPointOnSpline()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Update")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void PlaySplineAudioClip()
	{
	}

	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DisableSplineMeshUpdating()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineAudioClip), Member = "UpdateSplineAudioClipPosition_Legacy")]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Update")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetClosestPointParam")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void UpdateSplineAudioClipPosition_Legacy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineAudioClip), Member = "FetchClosestPointOnSplineResult")]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	public void ManualUpdate()
	{
	}

	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "ManualUpdate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void FetchClosestPointOnSplineResult()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SplineManager), Member = "Initialize")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Allocate")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Awake")]
	[CalledBy(Type = typeof(SplineManager), Member = "RegisterStaticSplineAudioClip")]
	[CallsUnknownMethods(Count = 1)]
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
	public SplineAudioClip()
	{
	}
}
