using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using SuperSplines;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;

public static class SplineManager
{
	public struct SplineMatrices
	{
		public NativeArray<double> m_NativeHermiteMatrix;

		public NativeArray<double> m_NativeBezierMatrix;

		public NativeArray<double> m_NativeBSplineMatrix;

		public NativeArray<double> m_NativeLinearMatrix;
	}

	public struct SplineAudioClipJobInfo
	{
		public Utils.FastSpline m_FastSpline;

		public Vector3 m_Position;
	}

	private struct FastSplineJob : IJob
	{
		public Vector3 m_Position;

		public Utils.FastSpline m_FastSpline;

		public int m_JobIndex;

		public NativeArray<Vector3> m_Results;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
		[Calls(Type = typeof(Utils), Member = "GetPositionOnSpline")]
		[CallsUnknownMethods(Count = 1)]
		public void Execute()
		{
		}
	}

	private static SplineMatrices s_Matrices;

	public static bool s_UseJobSystem;

	public const int MAX_AUDIO_CLIP_JOBS = 256;

	public static List<SplineAudioClip> s_SplineAudioClips;

	public static List<SplineAudioClipJobInfo> s_SplineAudioClipJobInfos;

	public static NativeArray<Vector3>[] s_SplineAudioClipResults;

	private static List<FastSplineJob> s_JobList;

	private static List<JobHandle> s_JobHandlesList;

	private static bool s_Initialized;

	[RuntimeInitializeOnLoadMethod]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Initialize")]
	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(SplineManager), Member = "GetMatrix")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public static void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineAudioClip), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterStaticSplineAudioClip(SplineAudioClip splineAudioClip)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnRegisterStaticSplineAudioClip(SplineAudioClip splineAudioClip)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "Initialize")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[Calls(Type = typeof(SplineManager), Member = "SheduleJobs")]
	[CallsUnknownMethods(Count = 4)]
	public static void EarlyUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int RequestSplineClosestPositionJob(Utils.FastSpline fastSpline, Vector3 position)
	{
		return 0;
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "FetchClosestPointOnSplineResult")]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool RetrieveSplineClosestPosition(int jobIndex, out Vector3 closestPosition)
	{
		closestPosition = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static void SheduleJobs()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
	[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CalledBy(Type = typeof(SplineManager), Member = "Dispose")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	public static void CompleteJobs()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SplineManager), Member = "RetrieveSplineClosestPosition")]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public static void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
	[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
	[CalledBy(Type = typeof(SplineManager), Member = "SheduleJobs")]
	[CalledBy(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[CalledBy(Type = typeof(SplineManager), Member = "Dispose")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static bool AreJobPending()
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 62)]
	public static void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineManager), Member = "Initialize")]
	public static NativeArray<double> GetMatrix(Spline.InterpolationMode splineInterpolationMode)
	{
		return default(NativeArray<double>);
	}
}
