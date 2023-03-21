using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine;

public class RaycastManager : MonoBehaviour
{
	private struct QueuedRaycastCommand
	{
		public RaycastCommand m_Command;

		public Action<RaycastHit> m_OnJobCompleted;
	}

	public static bool s_Debug;

	private const int COMMANDS_PER_FRAME = 32;

	private const int WARNING_COMMAND_COUNT = 64;

	private Queue<QueuedRaycastCommand> m_Pending;

	private Action<RaycastHit>[] m_ResultCallbacks;

	private NativeArray<RaycastCommand> m_RaycastCommands;

	private NativeArray<RaycastHit> m_RaycastHits;

	private bool m_HasWarnedThisFrame;

	private static RaycastManager s_Instance;

	private static int s_PendingJobsNumWorstAllTime;

	private static int s_PendingJobsNumWorstSecond;

	private static float s_PendingJobsTimer;

	private static float s_AveragePendingJobsPerSecond;

	private static int s_AveragePendingJobsPerSecondCounter;

	private static int s_AveragePendingJobsPerSecondSamples;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void OnDestroy()
	{
	}

	[Calls(Type = typeof(RaycastManager), Member = "CompletePendingRaycasts")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast_Internal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RaycastManager), Member = "GetInstance")]
	public static void RequestAsyncRaycast(Vector3 origin, Vector3 direction, float range, int layer, Action<RaycastHit> onJobCompleted)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void SetDebugEnabled(bool debug)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	public static string GetDebugText()
	{
		return null;
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	private static void ResetDebugCounters()
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateDebugCounters()
	{
	}

	[CalledBy(Type = typeof(RaycastManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void CompletePendingRaycasts()
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "MaybeLeaveScorchMarkOnGround")]
	[CalledBy(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	private void RequestAsyncRaycast_Internal(Vector3 origin, Vector3 direction, float range, int layer, Action<RaycastHit> onJobCompleted)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "MaybeLeaveScorchMarkOnGround")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	private static RaycastManager GetInstance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public RaycastManager()
	{
	}
}
