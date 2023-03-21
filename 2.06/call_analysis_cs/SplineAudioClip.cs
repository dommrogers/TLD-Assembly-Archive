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

	[Calls(Type = typeof(SplineAudioClip), Member = "Initialize")]
	[Calls(Type = typeof(Utils), Member = "GetValidNodesCount")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	public void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	public void Start()
	{
	}

	[Calls(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void EarlyUpdate()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 4)]
	private void RequestClosestPointOnSpline()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "ManualUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Update")]
	private void PlaySplineAudioClip()
	{
	}

	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void DisableSplineMeshUpdating()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineAudioClip), Member = "UpdateSplineAudioClipPosition_Legacy")]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Spline), Member = "GetClosestPointParam")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	public void UpdateSplineAudioClipPosition_Legacy()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	[Calls(Type = typeof(SplineManager), Member = "RetrieveSplineClosestPosition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void ManualUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SplineManager), Member = "RetrieveSplineClosestPosition")]
	[CallsUnknownMethods(Count = 4)]
	private void FetchClosestPointOnSplineResult()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SplineManager), Member = "Initialize")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Allocate")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Awake")]
	[CalledBy(Type = typeof(SplineManager), Member = "RegisterStaticSplineAudioClip")]
	[CallsUnknownMethods(Count = 2)]
	public void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	public void Terminate()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public SplineAudioClip()
	{
	}
}
