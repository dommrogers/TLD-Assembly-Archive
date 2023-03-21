using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class WeatherParticleManager
{
	private struct ParticleSystemVars
	{
		public bool m_EmitEnabled;

		public float m_EnforceLifetimeLimit;

		public float m_TurbulenceScalar;

		public Vector3 m_WindVecCopy;

		public Vector3 m_Gravity;

		public float m_TransverseScalar;

		public Vector3 m_HeightTestOffset;

		public float m_NoiseScaleByWind;

		public Vector3 m_Fragment1;

		public Vector3 m_Wind56;

		public Vector3 m_Wind44;

		public float m_GustScalar;

		public Vector3 m_NoiseOffset1;

		public Vector3 m_NoiseOffset2;

		public Vector3 m_WindBase;
	}

	private struct CommonVars
	{
		public Matrix4x4 m_CameraMat;

		public Matrix4x4 m_CameraInvMat;

		public Vector3 m_CamPos;

		public Bounds m_CameraBounds;

		public Bounds m_CameraBoundsNear;

		public Bounds m_PKBounds;

		public float m_WindStrength;

		public Vector3 m_SineScalar;

		public Vector3 m_WindVec;

		public Vector3 m_WindTransverseVec;

		public float m_TurbulenceTimer;

		public float m_GustScalar;

		public float m_Time;
	}

	private class WTTask
	{
		public int m_BaseIndex;

		public int m_Limit;

		public Bounds m_PKBounds;

		public bool m_PKTest;

		public bool m_BoxTest;

		public bool m_WrapBounds;

		public HeightMap m_ParticleCollisionHeightMap;

		public WeatherParticleManagerConfiguration m_Config;

		public CommonVars m_Common;

		public ParticleSystemVars m_ParticleSystemVars;

		public NativeArray<ParticleSystem.Particle> m_WorkParticles;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticle")]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticleNoTurbulence")]
		private void Wrap(int first, int limit, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[CallsUnknownMethods(Count = 1)]
		private void NoWrap(int first, int limit, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private void KillPoint(int first, int limit, Bounds pkBounds, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		[CallsUnknownMethods(Count = 1)]
		private void KillBox(int first, int limit, Bounds pkBounds, Bounds snowBox, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticle")]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticleNoTurbulence")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private void WrapAndKillPoint(int first, int limit, Bounds pkBounds, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticle")]
		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticleNoTurbulence")]
		private void WrapAndKillBox(int first, int limit, Bounds pkBounds, Bounds snowBox, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CalledBy(Type = typeof(WTTask), Member = "Wrap")]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillPoint")]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillBox")]
		[CalledBy(Type = typeof(WTTask), Member = "Execute")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateParticleInternal")]
		[CallsUnknownMethods(Count = 1)]
		private void UpdateParticle(ref ParticleSystem.Particle particle)
		{
		}

		[CalledBy(Type = typeof(WTTask), Member = "Wrap")]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillPoint")]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillBox")]
		[CalledBy(Type = typeof(WTTask), Member = "Execute")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateParticleNoTurbulenceInternal")]
		[CallsUnknownMethods(Count = 1)]
		private void UpdateParticleNoTurbulence(ref ParticleSystem.Particle particle)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleManager), Member = "WeatherParticleTask")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticle")]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticleNoTurbulence")]
		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		public void Execute()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public WTTask()
		{
		}
	}

	public struct ParticleCollisionHeightMapInfo
	{
		public Bounds m_Bounds;

		public Vector3 m_ActiveMinBounds;

		public float m_SpacingScalar;

		public int m_Stride;

		public Vector3 m_MinBounds;
	}

	private struct WeatherParticleJob : IJobParticleSystemParallelFor
	{
		public Bounds m_PKBounds;

		public bool m_PKTest;

		public bool m_BoxTest;

		public bool m_WrapBounds;

		public NativeArray<float> m_ParticleCollisionHeightMapHeights;

		public ParticleCollisionHeightMapInfo m_ParticleCollisionHeightMapInfo;

		public WeatherParticleManagerConfiguration m_Config;

		public CommonVars m_Common;

		public ParticleSystemVars m_ParticleSystemVars;

		public bool m_HasHeightMap;

		[CalledBy(TypeFullName = "UnityEngine.ParticleSystemJobs.ParticleSystemParallelForJobStruct`1", Member = "Execute")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "NoWrap_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "Wrap_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillPoint_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillBox_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		public void Execute(ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
		private void Wrap_Job(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "NoWrap_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "KillPoint_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "KillBox_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
		[CallerCount(Count = 7)]
		private void KillParticle(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void NoWrap_Job(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private void KillPoint_Job(Bounds pkBounds, ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void KillBox_Job(Bounds pkBounds, Bounds snowBox, ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private void WrapAndKillPoint_Job(Bounds pkBounds, ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		private void WrapAndKillBox_Job(Bounds pkBounds, Bounds snowBox, ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Wrap_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateParticleJobInternal")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void UpdateParticleNativeArray(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Wrap_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateParticleJobNoTurbulenceInternal")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void UpdateParticleNoTurbulenceNativeArray(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part2")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		public void Dispose()
		{
		}
	}

	private const int MAX_PARTICLES = 5000;

	private const int MAX_FALLING_SNOW_PARTICLES = 5000;

	private const int MAX_BLOWING_SNOW_PARTICLES = 1000;

	private const int PK_BOX_DIMENSIONS = 2;

	private const float MAX_WIND_SPEED = 55f;

	private const int ITEMS_PER_BATCH = 32;

	private const int MAX_WORKER_THREADS = 4;

	private const int MAX_PARTICLES_PER_TASK = 500;

	private const int INITIAL_TASK_CACHE_SIZE = 30;

	private const int MIN_REMAINDER_PARTICLES_FOR_TASK = 50;

	private WeatherParticleManagerConfiguration m_Config;

	private List<PKInstance> m_AllParticleKillers;

	private ParticleKiller[] m_PKBoxColliders;

	private List<Bounds> m_FallingSnowKillers;

	private List<Bounds> m_BlowingSnowKillers;

	private bool m_MultiThreadedUpdate_part1_completed;

	private CommonVars m_Common;

	private HeightMap m_ParticleCollisionHeightMap;

	private Vector4 m_GrassPhase;

	private Vector2 m_GrassPhaseNoise1;

	private Vector2 m_GrassPhaseNoise2;

	private static Vector2 m_NoiseDir1;

	private static Vector2 m_NoiseDir2;

	private Vector4 m_BranchPhase;

	private int m_NumWorkerThreads;

	private Thread[] m_WorkerThreads;

	private AutoResetEvent[] m_WTAutoResetEvents;

	private List<WTTask> m_WTTaskList;

	private AutoResetEvent m_MainThreadAutoResetEvent;

	private int m_TaskCount;

	private int m_TaskIndex;

	private ParticleSystemVars m_ParticleSystemVarsBlowing;

	private ParticleSystemVars m_ParticleSystemVarsFalling;

	private NativeArray<ParticleSystem.Particle> m_WorkParticlesBlowingNativeArray;

	private NativeArray<ParticleSystem.Particle> m_WorkParticlesFallingNativeArray;

	private List<JobHandle> m_JobHandlesList;

	private List<WeatherParticleJob> m_JobList;

	public static bool s_UseJobSystem;

	private float constB;

	private float constC;

	private static readonly Vector3 step;

	private static readonly float stepDot1;

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Init")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "StartWorkerThreads")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 39)]
	public WeatherParticleManager(WeatherParticleManagerConfiguration config)
	{
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "OnDisable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Resources), Member = "UnloadAsset")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	public void Destroy()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "InitializeAfterSceneLoad")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(PKInstance), Member = ".ctor")]
	[Calls(Type = typeof(PKInstance), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 27)]
	public void InitializeForScene()
	{
	}

	[CallerCount(Count = 0)]
	public static int GetMaxFallingParticleCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public static int GetMaxBlowingParticleCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 58)]
	private void StartWorkerThreads()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	private void StopWorkerThreads()
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateShaderGlobalsForFoliage(Vector3 camUp)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "DoLateUpdate_part1")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateShaderGlobalsForFoliage")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PKInstance), Member = "ShouldUpdate")]
	[Calls(Type = typeof(PKInstance), Member = "get_BoundingBox")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part1")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 19)]
	public void LateUpdate_part1()
	{
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part2")]
	[CallsUnknownMethods(Count = 3)]
	public void LateUpdate_part2()
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[Calls(TypeFullName = "System.Threading.NativeEventCalls", Member = "SetEvent")]
	[Calls(Type = typeof(IOException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void WeatherParticles_MultiThreadedUpdate_part1(Weather wc)
	{
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "DoLateUpdate_part2")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part2")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WeatherParticleJob), Member = "Dispose")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 21)]
	private void WeatherParticles_MultiThreadedUpdate_part2(Weather wc)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void ConfigureParticleSystemVars(ParticleSystem ps, ref ParticleSystemVars psv, float turbulenceScalar)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void ParticleUpdate_Job(List<Bounds> pkBounds, ParticleSystem ps, float flurryScalar, float turbulenceScalar, int psi, float lifetimeLimit)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part1")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ConfigureParticleSystemVars")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "AddTasksWithBounds")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "AddTaskWithNoBounds")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ScheduleJobWithBounds")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ScheduleJobWithNoBounds")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void ParticleUpdate_MultiThreaded(List<Bounds> pkBounds, ParticleSystem ps, float flurryScalar, float turbulenceScalar, NativeArray<ParticleSystem.Particle> workParticles, float lifetimeLimit, bool isFallingSnow, ref ParticleSystemVars psv)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void AddTaskWithNoBounds(ParticleSystem ps, NativeArray<ParticleSystem.Particle> workParticles, bool isFallingSnow)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_particleCount")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void AddTasksWithBounds(List<Bounds> pkBounds, ParticleSystem ps, bool isFallingSnow)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void ScheduleJobWithNoBounds(ParticleSystem ps, bool isFallingSnow)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	private void ScheduleJobWithBounds(List<Bounds> pkBounds, ParticleSystem ps, bool isFallingSnow)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WTTask), Member = "Execute")]
	[Calls(TypeFullName = "System.Threading.NativeEventCalls", Member = "SetEvent")]
	[Calls(Type = typeof(IOException), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private void WeatherParticleTask(object obj)
	{
	}

	[CalledBy(Type = typeof(WTTask), Member = "UpdateParticle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static void UpdateParticleInternal(ref ParticleSystem.Particle particle, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static void UpdateParticleJobInternal(ref ParticleSystemJobData jobData, int i, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void UpdateParticleJobNoTurbulenceInternal(ref ParticleSystemJobData jobData, int i, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[CalledBy(Type = typeof(WTTask), Member = "UpdateParticleNoTurbulence")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void UpdateParticleNoTurbulenceInternal(ref ParticleSystem.Particle particle, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private float FastSine(float x)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static float Hash(float p)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateParticleInternal")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateParticleJobInternal")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	private static float Noise3(Vector3 x)
	{
		return 0f;
	}
}
