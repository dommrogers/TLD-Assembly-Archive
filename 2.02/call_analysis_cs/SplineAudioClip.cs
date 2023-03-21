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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SplineManager), Member = "RegisterStaticSplineAudioClip")]
	[Calls(Type = typeof(Utils), Member = "GetValidNodesCount")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineAudioClip), Member = "DisableSplineMeshUpdating")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	public void EarlyUpdate()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(SplineManager), Member = "RequestSplineClosestPositionJob")]
	private void RequestClosestPointOnSpline()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Update")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	private void PlaySplineAudioClip()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Start")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void DisableSplineMeshUpdating()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SplineAudioClip), Member = "UpdateSplineAudioClipPosition_Legacy")]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	public void Update()
	{
	}

	[Calls(Type = typeof(Spline), Member = "GetClosestPointParam")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Update")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public void UpdateSplineAudioClipPosition_Legacy()
	{
	}

	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineAudioClip), Member = "FetchClosestPointOnSplineResult")]
	public void ManualUpdate()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "ManualUpdate")]
	[Calls(Type = typeof(SplineManager), Member = "RetrieveSplineClosestPosition")]
	[CallsDeduplicatedMethods(Count = 4)]
	private void FetchClosestPointOnSplineResult()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SplineManager), Member = "GetMatrix")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Allocate")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Initialize()
	{
	}

	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	[CallerCount(Count = 0)]
	public void Terminate()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SplineAudioClip()
	{
	}
}
