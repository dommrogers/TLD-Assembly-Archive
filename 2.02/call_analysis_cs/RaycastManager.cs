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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CalledBy(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[CalledBy(Type = typeof(RaycastManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 9)]
	private static void Initialize()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 6)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RaycastManager), Member = "CompletePendingRaycasts")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "MaybeLeaveScorchMarkOnGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast_Internal")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RaycastManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void RequestAsyncRaycast(Vector3 origin, Vector3 direction, float range, int layer, Action<RaycastHit> onJobCompleted)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetDebugEnabled(bool debug)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	public static string GetDebugText()
	{
		return null;
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void ResetDebugCounters()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	private void UpdateDebugCounters()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(RaycastManager), Member = "Update")]
	[CallsUnknownMethods(Count = 16)]
	private void CompletePendingRaycasts()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	private void RequestAsyncRaycast_Internal(Vector3 origin, Vector3 direction, float range, int layer, Action<RaycastHit> onJobCompleted)
	{
	}

	[Calls(Type = typeof(RaycastManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static RaycastManager GetInstance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 10)]
	public RaycastManager()
	{
	}
}
