using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CalledBy(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[CalledBy(Type = typeof(RaycastManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 7)]
	private static void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RaycastManager), Member = "CompletePendingRaycasts")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "MaybeLeaveScorchMarkOnGround")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RaycastManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast_Internal")]
	public static void RequestAsyncRaycast(Vector3 origin, Vector3 direction, float range, int layer, Action<RaycastHit> onJobCompleted)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void SetDebugEnabled(bool debug)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	public static string GetDebugText()
	{
		return null;
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	private static void ResetDebugCounters()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	private void UpdateDebugCounters()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(RaycastManager), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	private void CompletePendingRaycasts()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	private void RequestAsyncRaycast_Internal(Vector3 origin, Vector3 direction, float range, int layer, Action<RaycastHit> onJobCompleted)
	{
	}

	[Calls(Type = typeof(RaycastManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private static RaycastManager GetInstance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public RaycastManager()
	{
	}
}
