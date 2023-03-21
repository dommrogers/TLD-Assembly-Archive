using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

public class RenderObjectInstance : MonoBehaviour
{
	[Serializable]
	public class LodDistanceQualityOverride
	{
		public QualityLodBias m_QualityLodBias;

		public float m_Lod1Distances;

		public float m_Lod2Distances;

		public float m_Lod3Distances;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public LodDistanceQualityOverride()
		{
		}
	}

	public enum FrustrmType
	{
		DotProduct,
		Camera
	}

	public enum MultisceneSupport
	{
		Individual,
		Renderer,
		Collector
	}

	public enum Category
	{
		None,
		Tree,
		RockLarge,
		RockMedium,
		RockDebris,
		ArtObjects,
		Fences
	}

	public enum EnableOptions
	{
		None,
		ReEnableRenderersWhenDisabled
	}

	public List<GameObject> m_ObjectParents;

	public MultisceneSupport m_MultiSceneType;

	public Transform m_Camera;

	public float m_Lod1Distances;

	public float m_Lod2Distances;

	public float m_Lod3Distances;

	public LodDistanceQualityOverride[] m_LodDistanceQualityOverrides;

	public float m_TransitionWidth;

	public MinMax m_CullMultiplier;

	public MinMax m_HeightAdjust;

	public bool m_ForceOnlyLod0Shadow;

	public bool m_ForceNoLod0Cull;

	public int m_MaxJobCount;

	public FrustrmType m_FrustumType;

	public List<RenderObjectInstanceVolume> m_DistanceVolumes;

	public List<RenderObjectInstanceTriggerVolume> m_TriggerVolumes;

	public Category m_Category;

	public const int _Lod0Mask_ = 1;

	public const int _Lod1Mask_ = 2;

	public const int _Lod2Mask_ = 4;

	public static bool s_EnableLodVisualization;

	public static bool s_EnableWarningLogs;

	private Camera m_CameraComponent;

	private bool m_IsInitialized;

	private float4 m_CameraPosition;

	private float4 m_CameraDirection;

	private Plane[] m_CameraPlanes;

	private float m_Lod0Start;

	private float m_Lod1DistNearSqr;

	private float m_Lod1DistMiddleSqr;

	private float m_Lod1DistFarSqr;

	private float m_Lod2DistNearSqr;

	private float m_Lod2DistMiddleSqr;

	private float m_Lod2DistFarSqr;

	private float m_Lod3DistNearSqr;

	private float m_Lod3DistMiddleSqr;

	private List<RenderObjectInstanceTriggerVolume> m_TriggerVolumeList;

	private MaterialPropertyBlock m_Lod0DistanceBlock;

	private MaterialPropertyBlock m_Lod1DistanceBlock;

	private MaterialPropertyBlock m_Lod2DistanceBlock;

	private int m_ObjectCount;

	private NativeArray<JobHandle> m_JobHandles;

	private NativeArray<Plane> m_CameraPlanesNativeArray;

	private static List<RenderObjectInstance> s_RenderObjectInstanceList;

	private bool m_Allocated;

	private bool m_HasBeenDisabled;

	private static bool s_UseCameraFrustum;

	private NativeArray<Vector3> m_FrustumCorners;

	private NativeArray<Plane> m_LightPlanes;

	private int m_LightPlanesCount;

	private const string CROSSFADE_SHADER_KEYWORD = "TLD_CROSSFADE";

	private static readonly int s_LodFadeDistanceId;

	private static readonly int s_LodColourId;

	private const float FOV_VISIBILITY_EXPAND = 0.05f;

	private static bool s_DebugDrawCullingPlanes;

	private RenderObjectInstanceSceneData[] m_SceneDataComponents;

	public RenderObjectInstanceBatches m_Batches;

	public static bool s_ShowDebugInfo;

	private string m_DebugText;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(GameManager), Member = "EarlyUpdate")]
	public static void EarlyUpdateAll()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyRenderObjectInstances")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyRenderObjectInstances")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances_norenderers")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyRenderObjectInstances")]
	[CallsUnknownMethods(Count = 4)]
	public static void EnableAll(bool enabled, EnableOptions options)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances_norenderers")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances_norenderers")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	public static bool AllEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderers")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyInstanceTrees")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disableinstancedtrees")]
	[CallsUnknownMethods(Count = 3)]
	public static void EnableCategory(Category category, bool enabled, EnableOptions options)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disableinstancedtrees")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disableinstancedtrees")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyInstanceTrees")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyInstanceTrees")]
	public static bool IsCategoryEnabled(Category category)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void EnableFrustumTest(bool useCameraFrustum)
	{
	}

	[CallerCount(Count = 0)]
	public static bool IsFrustumTestEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Utils), Member = "CheckIfAkGameObjIsStatic")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static bool IsRenderObjectInstanceChild(Transform t)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "Register")]
	[Calls(Type = typeof(RenderObjectInstanceTriggerVolume), Member = "RegisterInstancingScript")]
	[CallsUnknownMethods(Count = 10)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "OnEnable")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "FinishInitialization")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix")]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[CallsUnknownMethods(Count = 22)]
	private void Setup()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableCategory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void EnableRenderers(bool enabled)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRendererForLODGroup")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRenderers")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[CallsUnknownMethods(Count = 6)]
	private void EnableRenderersInChildren(Transform parent, bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshFilterForInstancedRendering")]
	private void EnableRendererForLODGroup(LODGroup group, bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "FinishInitialization")]
	[CallsUnknownMethods(Count = 1)]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(RenderObjectInstanceBatches.PerObject), Member = "Allocate")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Initialize")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Setup")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RenderObjectInstanceBatches.PerBatch), Member = "Initialize")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "ReserveBatchName")]
	[Calls(Type = typeof(RenderObjectInstanceSceneData), Member = "GetRenderBatchCount")]
	[Calls(Type = typeof(RenderObjectInstanceBatches.PerBatch), Member = "Allocate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = ".ctor")]
	private void CreateBatchList(RenderObjectInstanceSceneData[] sceneDataComponents)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "GetLodsAndRenderers")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Setup")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Initialize")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PopulateBatchList(RenderObjectInstanceSceneData[] sceneDataComponents)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private MaterialPropertyBlock GetMaterialPropertiesForLod(int batchIndex)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "Setup")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "OnDisable")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "OnDestroy")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(RenderObjectInstanceBatches.PerBatch), Member = "Dispose")]
	[Calls(Type = typeof(RenderObjectInstanceBatches.PerObject), Member = "Dispose")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "WaitForJobs")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	private void Cleanup()
	{
	}

	[Calls(Type = typeof(RenderObjectInstance), Member = "UpdateLodMaterialProperties")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdateAll")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "ScheduleJobs")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "WaitForJobs")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "UpdateLODsWithVolumes")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "Setup")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "UpdateLODsFromSettings")]
	private void EarlyUpdate()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[Calls(Type = typeof(RenderObjectInstanceBatches.PerObject), Member = "InitializeJob")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstanceBatches.PerBatch), Member = "InitializeJob")]
	private void ScheduleJobs()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(JobVisUtils), Member = "UpdateDirectionalLightCullingPlanes")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumCorners")]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumPlanes")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateFrustumArrays()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "LateUpdate")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallerCount(Count = 3)]
	private void WaitForJobs()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "WaitForJobs")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "RenderBatch")]
	[CallsUnknownMethods(Count = 1)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateLODsFromSettings(float4 camPos)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallerCount(Count = 0)]
	private void GetLodDistances(out float lod1Distance, out float lod2Distance, out float lod3Distance)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref lod1Distance) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref lod2Distance) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref lod3Distance) = null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void TestClipPlaneDistance()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 25)]
	private void UpdateLodMaterialProperties()
	{
	}

	[CallerCount(Count = 0)]
	private float FastSqrDist3D(Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void UpdateLODsWithVolumes(Vector4 camPos)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void PushTriggerVolume(RenderObjectInstanceTriggerVolume curVolume)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void PopTriggerVolume(RenderObjectInstanceTriggerVolume curVolume)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Awake")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Register()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UnRegister()
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetDebugText")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string GetDebugText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRendererForLODGroup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static MeshFilter MaybeGetMeshFilterForInstancedRendering(Renderer r)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshFilterForInstancedRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
	[CalledBy(Type = typeof(RenderObjectInstanceSceneData), Member = "RegenerateInstanceLists")]
	[CallsUnknownMethods(Count = 2)]
	public static Mesh MaybeGetMeshForInstancedRendering(Renderer r)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CopyNativeToManaged(NativeArray<Matrix4x4> src, int srcIndex, Matrix4x4[] dst, int dstIndex, int length)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstanceSceneData), Member = "RegenerateInstanceLists")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public static Dictionary<int, List<Renderer>> GetLodsAndRenderers(List<GameObject> gameObjects, bool ignoreDisabledObjects, bool allowNoLodGroup, bool removeLodGroup)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	public RenderObjectInstance()
	{
	}
}
