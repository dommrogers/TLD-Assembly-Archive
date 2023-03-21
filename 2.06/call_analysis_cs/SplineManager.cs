using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

		[Calls(Type = typeof(Utils), Member = "GetPositionOnSpline")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
		[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
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

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SplineManager), Member = "GetMatrix")]
	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[RuntimeInitializeOnLoadMethod]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Initialize")]
	public static void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SplineAudioClip), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterStaticSplineAudioClip(SplineAudioClip splineAudioClip)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	public static void UnRegisterStaticSplineAudioClip(SplineAudioClip splineAudioClip)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[Calls(Type = typeof(SplineManager), Member = "SheduleJobs")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallsUnknownMethods(Count = 4)]
	public static void EarlyUpdate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int RequestSplineClosestPositionJob(Utils.FastSpline fastSpline, Vector3 position)
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "FetchClosestPointOnSplineResult")]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	public static bool RetrieveSplineClosestPosition(int jobIndex, out Vector3 closestPosition)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref closestPosition) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	public static void SheduleJobs()
	{
	}

	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
	[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
	[CalledBy(Type = typeof(SplineManager), Member = "Dispose")]
	[CallsUnknownMethods(Count = 17)]
	public static void CompleteJobs()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "RetrieveSplineClosestPosition")]
	public static void Update()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
	[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
	[CalledBy(Type = typeof(SplineManager), Member = "SheduleJobs")]
	[CalledBy(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[CalledBy(Type = typeof(SplineManager), Member = "Dispose")]
	[CallsUnknownMethods(Count = 1)]
	public static bool AreJobPending()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 62)]
	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
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
