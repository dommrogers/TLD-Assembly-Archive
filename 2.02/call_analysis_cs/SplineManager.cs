using System;
using System.Collections.Generic;
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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSpline")]
		[Calls(Type = typeof(Utils), Member = "GetPositionOnSpline")]
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
	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(SplineManager), Member = "GetMatrix")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void Initialize()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "GetMatrix")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Allocate")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void RegisterStaticSplineAudioClip(SplineAudioClip splineAudioClip)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[Calls(Type = typeof(Utils.FastSpline), Member = "Dispose")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void UnRegisterStaticSplineAudioClip(SplineAudioClip splineAudioClip)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "Initialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[Calls(Type = typeof(SplineManager), Member = "SheduleJobs")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void EarlyUpdate()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static int RequestSplineClosestPositionJob(Utils.FastSpline fastSpline, Vector3 position)
	{
		return 0;
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "FetchClosestPointOnSplineResult")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(JobHandle), Member = "Complete")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static bool RetrieveSplineClosestPosition(int jobIndex, out Vector3 closestPosition)
	{
		closestPosition = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public static void SheduleJobs()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
	[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
	[CalledBy(Type = typeof(SplineManager), Member = "Update")]
	[CalledBy(Type = typeof(SplineManager), Member = "Dispose")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(JobHandle), Member = "CompleteAll")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void CompleteJobs()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SplineAudioClip), Member = "FetchClosestPointOnSplineResult")]
	[Calls(Type = typeof(SplineAudioClip), Member = "PlaySplineAudioClip")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool AreJobPending()
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SplineManager), Member = "AreJobPending")]
	[Calls(Type = typeof(SplineManager), Member = "CompleteJobs")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	public static void Dispose()
	{
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "Initialize")]
	[CalledBy(Type = typeof(SplineManager), Member = "RegisterStaticSplineAudioClip")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SplineManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static NativeArray<double> GetMatrix(Spline.InterpolationMode splineInterpolationMode)
	{
		return default(NativeArray<double>);
	}
}
