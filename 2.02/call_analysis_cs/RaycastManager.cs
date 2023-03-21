using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Jobs.LowLevel.Unsafe;
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

	[CalledBy(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[CalledBy(Type = typeof(RaycastManager), Member = "GetInstance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RaycastManager), Member = "CompletePendingRaycasts")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "MaybeLeaveScorchMarkOnGround")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastManager), Member = "Initialize")]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast_Internal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void RequestAsyncRaycast(Vector3 origin, Vector3 direction, float range, int layer, Action<RaycastHit> onJobCompleted)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetDebugEnabled(bool debug)
	{
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void ResetDebugCounters()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateDebugCounters()
	{
	}

	[CalledBy(Type = typeof(RaycastManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BatchQueryJobStruct<>), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	private void CompletePendingRaycasts()
	{
	}

	[CalledBy(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void RequestAsyncRaycast_Internal(Vector3 origin, Vector3 direction, float range, int layer, Action<RaycastHit> onJobCompleted)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static RaycastManager GetInstance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public RaycastManager()
	{
	}
}
