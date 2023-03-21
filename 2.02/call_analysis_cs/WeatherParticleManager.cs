using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;
using UnityEngine.SceneManagement;

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

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		private void NoWrap(int first, int limit, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		private void KillPoint(int first, int limit, Bounds pkBounds, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[CallsUnknownMethods(Count = 1)]
		private void KillBox(int first, int limit, Bounds pkBounds, Bounds snowBox, NativeArray<ParticleSystem.Particle> pList)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticle")]
		[Calls(Type = typeof(WTTask), Member = "UpdateParticleNoTurbulence")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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

		[CalledBy(Type = typeof(WTTask), Member = "Wrap")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillBox")]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillPoint")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateParticleInternal")]
		private void UpdateParticle(ref ParticleSystem.Particle particle)
		{
		}

		[CalledBy(Type = typeof(WTTask), Member = "Wrap")]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillBox")]
		[CalledBy(Type = typeof(WTTask), Member = "WrapAndKillPoint")]
		[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateParticleNoTurbulenceInternal")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(HeightMap), Member = "GetHeight")]
		private void UpdateParticleNoTurbulence(ref ParticleSystem.Particle particle)
		{
		}

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(WeatherParticleManager), Member = "WeatherParticleTask")]
		[CallAnalysisFailed]
		public void Execute()
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
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

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "NoWrap_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "Wrap_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillPoint_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillBox_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		[CalledBy(Type = typeof(UnityEngine.ParticleSystemJobs.ParticleSystemParallelForJobStruct<>), Member = "Execute")]
		public void Execute(ParticleSystemJobData jobData, int i)
		{
		}

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		private void Wrap_Job(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "KillBox_Job")]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "NoWrap_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "KillPoint_Job")]
		private void KillParticle(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallsUnknownMethods(Count = 1)]
		private void NoWrap_Job(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		private void KillPoint_Job(Bounds pkBounds, ref ParticleSystemJobData jobData, int i)
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Bounds), Member = "Intersects")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallsUnknownMethods(Count = 1)]
		private void KillBox_Job(Bounds pkBounds, Bounds snowBox, ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Execute")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNoTurbulenceNativeArray")]
		[Calls(Type = typeof(WeatherParticleJob), Member = "KillParticle")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WeatherParticleJob), Member = "UpdateParticleNativeArray")]
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

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[CallAnalysisFailed]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Wrap_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		private void UpdateParticleNativeArray(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillBox_Job")]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "WrapAndKillPoint_Job")]
		[CallAnalysisFailed]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(WeatherParticleJob), Member = "Wrap_Job")]
		private void UpdateParticleNoTurbulenceNativeArray(ref ParticleSystemJobData jobData, int i)
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part2")]
		[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 60)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Init")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "StartWorkerThreads")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public WeatherParticleManager(WeatherParticleManagerConfiguration config)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 11)]
	public void Destroy()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsUnknownMethods(Count = 56)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "InitializeAfterSceneLoad")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[Calls(Type = typeof(PKInstance), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PKInstance), Member = ".ctor")]
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

	[CalledBy(Type = typeof(WeatherParticleManager), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "set_Name")]
	[CallsUnknownMethods(Count = 70)]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	private void StartWorkerThreads()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private void StopWorkerThreads()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Wind), Member = "GetWindLift")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Wind), Member = "GetWindLift")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	private void UpdateShaderGlobalsForFoliage(Vector3 camUp)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "UpdateShaderGlobalsForFoliage")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[Calls(Type = typeof(PKInstance), Member = "get_BoundingBox")]
	[Calls(Type = typeof(PKInstance), Member = "get_BoundingBox")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part1")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "DoLateUpdate_part1")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(PKInstance), Member = "ShouldUpdate")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Bounds), Member = "set_size")]
	[Calls(Type = typeof(Bounds), Member = "set_size")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	public void LateUpdate_part1()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "LateUpdate")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "DoLateUpdate_part2")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part2")]
	[CallerCount(Count = 2)]
	public void LateUpdate_part2()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	private void WeatherParticles_MultiThreadedUpdate_part1(Weather wc)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part2")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ParticleSystem), Member = "SetParticles")]
	[Calls(Type = typeof(WeatherParticleJob), Member = "Dispose")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "SetParticles")]
	private void WeatherParticles_MultiThreadedUpdate_part2(Weather wc)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	private void ConfigureParticleSystemVars(ParticleSystem ps, ref ParticleSystemVars psv, float turbulenceScalar)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void ParticleUpdate_Job(List<Bounds> pkBounds, ParticleSystem ps, float flurryScalar, float turbulenceScalar, int psi, float lifetimeLimit)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part1")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "WeatherParticles_MultiThreadedUpdate_part1")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ScheduleJobWithNoBounds")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ScheduleJobWithBounds")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "AddTaskWithNoBounds")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "ConfigureParticleSystemVars")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WeatherParticleManager), Member = "AddTasksWithBounds")]
	private void ParticleUpdate_MultiThreaded(List<Bounds> pkBounds, ParticleSystem ps, float flurryScalar, float turbulenceScalar, NativeArray<ParticleSystem.Particle> workParticles, float lifetimeLimit, bool isFallingSnow, ref ParticleSystemVars psv)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void AddTaskWithNoBounds(ParticleSystem ps, NativeArray<ParticleSystem.Particle> workParticles, bool isFallingSnow)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	private void AddTasksWithBounds(List<Bounds> pkBounds, ParticleSystem ps, bool isFallingSnow)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallsUnknownMethods(Count = 10)]
	private void ScheduleJobWithNoBounds(ParticleSystem ps, bool isFallingSnow)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HeightMap), Member = "CreateEmptyHeights")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "ParticleUpdate_MultiThreaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void ScheduleJobWithBounds(List<Bounds> pkBounds, ParticleSystem ps, bool isFallingSnow)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WTTask), Member = "Execute")]
	private void WeatherParticleTask(object obj)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(WTTask), Member = "UpdateParticle")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	private static void UpdateParticleInternal(ref ParticleSystem.Particle particle, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	private static void UpdateParticleJobInternal(ref ParticleSystemJobData jobData, int i, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	private static void UpdateParticleJobNoTurbulenceInternal(ref ParticleSystemJobData jobData, int i, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WTTask), Member = "UpdateParticleNoTurbulence")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	private static void UpdateParticleNoTurbulenceInternal(ref ParticleSystem.Particle particle, ParticleSystemVars psv, WeatherParticleManagerConfiguration config, CommonVars common, Vector3 p)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	private float FastSine(float x)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "Noise3")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static float Hash(float p)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateParticleJobInternal")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateParticleJobInternal")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateParticleInternal")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateParticleInternal")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Hash")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Hash")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Hash")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Hash")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Hash")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Hash")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Hash")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "Hash")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private static float Noise3(Vector3 x)
	{
		return default(float);
	}
}
