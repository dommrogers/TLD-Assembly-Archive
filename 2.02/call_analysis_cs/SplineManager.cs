using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
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

		[Calls(Type = typeof(Utils), Member = "GetPositionOnSpline")]
		[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSpline")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(SplineManager), Member = "GetMatrix")]
	[CallsUnknownMethods(Count = 8)]
	public static void Initialize()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "Awake")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Allocate")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "GetMatrix")]
	public static void RegisterStaticSplineAudioClip(SplineAudioClip splineAudioClip)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	[CallsUnknownMethods(Count = 2)]
	public static void UnRegisterStaticSplineAudioClip(SplineAudioClip splineAudioClip)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(SplineManager), Member = "SheduleJobs")]
	[Calls(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SplineManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void EarlyUpdate()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static int RequestSplineClosestPositionJob(Utils.FastSpline fastSpline, Vector3 position)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(JobHandle), Member = "Complete")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "FetchClosestPointOnSplineResult")]
	[CallsUnknownMethods(Count = 5)]
	public static bool RetrieveSplineClosestPosition(int jobIndex, out Vector3 closestPosition)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref closestPosition) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void SheduleJobs()
	{
	}

	[CalledBy(Type = typeof(SplineManager), Member = "Dispose")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(JobHandle), Member = "CompleteAll")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
	[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	public static void CompleteJobs()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	[Calls(Type = typeof(SplineAudioClip), Member = "FetchClosestPointOnSplineResult")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SplineManager), Member = "Dispose")]
	[CalledBy(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[CalledBy(Type = typeof(SplineManager), Member = "SheduleJobs")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
	public static bool AreJobPending()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 16)]
	public static void Dispose()
	{
	}

	[CalledBy(Type = typeof(SplineManager), Member = "RegisterStaticSplineAudioClip")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Initialize")]
	[Calls(Type = typeof(SplineManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static NativeArray<double> GetMatrix(Spline.InterpolationMode splineInterpolationMode)
	{
		return default(NativeArray<double>);
	}
}
