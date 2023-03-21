using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
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

		[Calls(Type = typeof(WTTask), Member = "UpdateParticleNoTurbulence")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticle")]
		private void Wrap(int first, int limit, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[CallsUnknownMethods(Count = 1)]
		private void NoWrap(int first, int limit, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void KillPoint(int first, int limit, Bounds pkBounds, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		private void KillBox(int first, int limit, Bounds pkBounds, Bounds snowBox, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticleNoTurbulence")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticle")]
		private void WrapAndKillPoint(int first, int limit, Bounds pkBounds, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticle")]
		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticleNoTurbulence")]
		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		private void WrapAndKillBox(int first, int limit, Bounds pkBounds, Bounds snowBox, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillBox")]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillPoint")]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateParticleInternal")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(WTTask), Member = "Wrap")]
		private void UpdateParticle(ref ParticleSystem.Particle particle)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillBox")]
		[CalledBy(Type = typeof(WTTask), Member = "Wrap")]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillPoint")]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateParticleNoTurbulenceInternal")]
		private void UpdateParticleNoTurbulence(ref ParticleSystem.Particle particle)
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
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

		[CalledBy(Type = typeof(UnityEngine.ParticleSystemJobs.ParticleSystemParallelForJobStruct<>), Member = "Execute")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillBox_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "Wrap_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "NoWrap_Job")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillPoint_Job")]
		public void Execute(ParticleSystemJobData jobData, int i)
		{
		}

		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		private void Wrap_Job(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "KillPoint_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "NoWrap_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "KillBox_Job")]
		[CallerCount(Count = 7)]
		private void KillParticle(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallsUnknownMethods(Count = 1)]
		private void NoWrap_Job(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
		private void KillPoint_Job(Bounds pkBounds, ref ParticleSystemJobData jobData, int i)
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallsUnknownMethods(Count = 1)]
		private void KillBox_Job(Bounds pkBounds, Bounds snowBox, ref ParticleSystemJobData jobData, int i)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
		private void WrapAndKillPoint_Job(Bounds pkBounds, ref ParticleSystemJobData jobData, int i)
		{
		}

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		private void WrapAndKillBox_Job(Bounds pkBounds, Bounds snowBox, ref ParticleSystemJobData jobData, int i)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Wrap_Job")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateParticleJobInternal")]
		private void UpdateParticleNativeArray(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Wrap_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateParticleJobNoTurbulenceInternal")]
		private void UpdateParticleNoTurbulenceNativeArray(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part2")]
		[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "StartWorkerThreads")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Init")]
	[CallsUnknownMethods(Count = 11)]
	public WeatherParticleManager(WeatherParticleManagerConfiguration config)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "OnDisable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Resources), Member = "UnloadAsset")]
	public void Destroy()
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PKInstance), Member = ".ctor")]
	[Calls(Type = typeof(PKInstance), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "InitializeAfterSceneLoad")]
	[CallsUnknownMethods(Count = 12)]
	public void InitializeForScene()
	{
	}

	[CallerCount(Count = 0)]
	public static int GetMaxFallingParticleCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public static int GetMaxBlowingParticleCount()
	{
		return default(int);
	}

	[Calls(Type = typeof(Thread), Member = "Start")]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void StartWorkerThreads()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private void StopWorkerThreads()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	private void UpdateShaderGlobalsForFoliage(Vector3 camUp)
	{
	}

	[Calls(Type = typeof(PKInstance), Member = "get_BoundingBox")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "DoLateUpdate_part1")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part1")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(PKInstance), Member = "get_BoundingBox")]
	[Calls(Type = typeof(PKInstance), Member = "ShouldUpdate")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateShaderGlobalsForFoliage")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	public void LateUpdate_part1()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part2")]
	public void LateUpdate_part2()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	private void WeatherParticles_MultiThreadedUpdate_part1(Weather wc)
	{
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "DoLateUpdate_part2")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part2")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(WeatherParticleJob), Member = "Dispose")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	private void WeatherParticles_MultiThreadedUpdate_part2(Weather wc)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallsUnknownMethods(Count = 8)]
	private void ConfigureParticleSystemVars(ParticleSystem ps, ref ParticleSystemVars psv, float turbulenceScalar)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void ParticleUpdate_Job(List<Bounds> pkBounds, ParticleSystem ps, float flurryScalar, float turbulenceScalar, int psi, float lifetimeLimit)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ConfigureParticleSystemVars")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "AddTasksWithBounds")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "AddTaskWithNoBounds")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ScheduleJobWithBounds")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ScheduleJobWithNoBounds")]
	[CallsUnknownMethods(Count = 4)]
	private void ParticleUpdate_MultiThreaded(List<Bounds> pkBounds, ParticleSystem ps, float flurryScalar, float turbulenceScalar, NativeArray<ParticleSystem.Particle> workParticles, float lifetimeLimit, bool isFallingSnow, ref ParticleSystemVars psv)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void AddTaskWithNoBounds(ParticleSystem ps, NativeArray<ParticleSystem.Particle> workParticles, bool isFallingSnow)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_particleCount")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_particleCount")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallsUnknownMethods(Count = 5)]
	private void AddTasksWithBounds(List<Bounds> pkBounds, ParticleSystem ps, bool isFallingSnow)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void ScheduleJobWithNoBounds(ParticleSystem ps, bool isFallingSnow)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallsUnknownMethods(Count = 6)]
	private void ScheduleJobWithBounds(List<Bounds> pkBounds, ParticleSystem ps, bool isFallingSnow)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void WeatherParticleTask(object obj)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(WTTask), Member = "UpdateParticle")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	private static void UpdateParticleInternal(ref ParticleSystem.Particle particle, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CalledBy(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
	[CallsUnknownMethods(Count = 11)]
	private static void UpdateParticleJobInternal(ref ParticleSystemJobData jobData, int i, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void UpdateParticleJobNoTurbulenceInternal(ref ParticleSystemJobData jobData, int i, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WTTask), Member = "UpdateParticleNoTurbulence")]
	[CallsUnknownMethods(Count = 4)]
	private static void UpdateParticleNoTurbulenceInternal(ref ParticleSystem.Particle particle, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private float FastSine(float x)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private static float Hash(float p)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateParticleJobInternal")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateParticleJobInternal")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateParticleInternal")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateParticleInternal")]
	private static float Noise3(Vector3 x)
	{
		return default(float);
	}
}
