using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;

public class SnowPlaneParticles : MonoBehaviour
{
	private class WTTask
	{
		public int m_BaseIndex;

		public int m_Limit;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public WTTask()
		{
		}
	}

	private struct SnowPlaneParticleJob : IJobParallelFor
	{
		public NativeArray<float> m_ParticleVelocityFracs;

		public NativeArray<float> m_ParticleFlurryFracs;

		public Vector3 m_MotionVec;

		public Vector3 m_FlurryVec;

		public Vector3 m_GravityVec;

		public NativeArray<ParticleSystem.Particle> m_WorkParticles;

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		public void Execute(int i)
		{
		}
	}

	public int m_MaxParticles;

	public ParticleSystem m_ParticleSystem;

	public SnowPlaneManager m_Manager;

	public float m_MinRandomizedVelocityFrac;

	public float m_MinGravityWindIntensity;

	public float m_MaxGravityWindIntensity;

	public float m_MinGravityVelocity;

	public float m_MaxGravityVelocity;

	public float m_WindVelocityScalar;

	public float m_FlurryThreshold;

	public float m_FlurryGravFrac;

	public float m_FlurryVelocityScalar;

	private NativeArray<ParticleSystem.Particle> m_ParticlesNativeArray;

	private ParticleSystem.Particle[] m_Particles;

	private float[] m_ParticleVelocityFracs;

	private float[] m_ParticleFlurryFracs;

	private NativeArray<float> m_ParticleVelocityFracsNativeArray;

	private NativeArray<float> m_ParticleFlurryFracsNativeArray;

	private Vector3 m_MotionVec;

	private Vector3 m_FlurryVec;

	private Vector3 m_GravityVec;

	private const int MAX_WORKER_THREADS = 4;

	private const int MAX_PARTICLES_PER_TASK = 150;

	private const int MIN_REMAINDER_PARTICLES_FOR_TASK = 50;

	private static int m_NumWorkerThreads;

	private static Thread[] m_WorkerThreads;

	private static AutoResetEvent[] m_WTAutoResetEvents;

	private static List<WTTask> m_WTTaskList;

	private static AutoResetEvent m_MainThreadAutoResetEvent;

	private static int m_TaskCount;

	private static int m_TaskIndex;

	private const int ITEMS_PER_BATCH = 32;

	public bool IsActive
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "Initialize")]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "Reset")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "StartWorkerThreads")]
	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "Start")]
	[CallsUnknownMethods(Count = 12)]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "Initialize")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 50)]
	private void StartWorkerThreads()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	private void StopWorkerThreads()
	{
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "InitializeForScene")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Reset")]
	[CallerCount(Count = 4)]
	public void Reset()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateParticlesJob(int numParticles)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateParticlesMultithread(int numParticles)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private static void WaitTasksCompletion()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void SnowPlaneParticleTask(object obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateParticle(ref ParticleSystem.Particle particle, float particleVelocityFrac, float particleFlurryFrac, Vector3 motionVec, Vector3 flurryVec, Vector3 gravityVec)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SnowPlaneParticles()
	{
	}
}
