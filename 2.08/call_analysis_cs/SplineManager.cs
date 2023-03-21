using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using SuperSplines;
using Unity.Collections;
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

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Initialize")]
	[CalledBy(Type = typeof(SplineManager), Member = "GetMatrix")]
	[CallerCount(Count = 3)]
	[RuntimeInitializeOnLoadMethod]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnRegisterStaticSplineAudioClip(SplineAudioClip splineAudioClip)
	{
	}

	[Calls(Type = typeof(SplineManager), Member = "SheduleJobs")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(SplineManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public static void EarlyUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int RequestSplineClosestPositionJob(Utils.FastSpline fastSpline, Vector3 position)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public static bool RetrieveSplineClosestPosition(int jobIndex, out Vector3 closestPosition)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref closestPosition) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	public static void SheduleJobs()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SplineManager), Member = "Dispose")]
	[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static void CompleteJobs()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineAudioClip), Member = "FetchClosestPointOnSplineResult")]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	public static void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
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

	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 7)]
	public static void Dispose()
	{
	}

	[Calls(Type = typeof(SplineManager), Member = "Initialize")]
	[CallerCount(Count = 0)]
	public static NativeArray<double> GetMatrix(Spline.InterpolationMode splineInterpolationMode)
	{
		return default(NativeArray<double>);
	}
}
