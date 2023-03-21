using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public class SnowPlaneParticles : MonoBehaviour
{
	private class WTTask
	{
		public int m_BaseIndex;

		public int m_Limit;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SnowPlaneParticles), Member = "UpdateParticle")]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "StartWorkerThreads")]
	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "Start")]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[CallsUnknownMethods(Count = 59)]
	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "Initialize")]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Thread), Member = "set_Name")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	private void StartWorkerThreads()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void StopWorkerThreads()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "InitializeForScene")]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Reset")]
	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "Start")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(SnowPlaneManager), Member = "Start")]
	public void Reset()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(ParticleSystem), Member = "SetParticles")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[Calls(Type = typeof(JobHandle), Member = "Complete")]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "UpdateParticlesMultithread")]
	[Calls(Type = typeof(ParticleSystem), Member = "GetParticles")]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Weather), Member = "GetFallingSnowIntensity")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	private void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JobHandle), Member = "Complete")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void UpdateParticlesJob(int numParticles)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "LateUpdate")]
	private void UpdateParticlesMultithread(int numParticles)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private static void WaitTasksCompletion()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[Calls(Type = typeof(SnowPlaneParticles), Member = "UpdateParticle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void SnowPlaneParticleTask(object obj)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "SnowPlaneParticleTask")]
	[CalledBy(Type = typeof(SnowPlaneParticleJob), Member = "Execute")]
	private static void UpdateParticle(ref ParticleSystem.Particle particle, float particleVelocityFrac, float particleFlurryFrac, Vector3 motionVec, Vector3 flurryVec, Vector3 gravityVec)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SnowPlaneParticles()
	{
	}
}
