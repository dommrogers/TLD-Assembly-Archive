using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
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
		[CallerCount(Count = 2)]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRendererForLODGroup")]
	[CallsUnknownMethods(Count = 6)]
	public static MeshFilter MaybeGetMeshFilterForInstancedRendering(Renderer r)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInLODGroup")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshFilterForInstancedRendering")]
	public static Mesh MaybeGetMeshForInstancedRendering(Renderer r)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void CopyNativeToManaged(NativeArray<Matrix4x4> src, int srcIndex, Matrix4x4[] dst, int dstIndex, int length)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "EarlyUpdate")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void EarlyUpdateAll()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyRenderObjectInstances")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances_norenderers")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyRenderObjectInstances")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyRenderObjectInstances")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	public static void EnableAll(bool enabled, EnableOptions options)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances_norenderers")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances_norenderers")]
	[CallsUnknownMethods(Count = 4)]
	public static bool AllEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderers")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disableinstancedtrees")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyInstanceTrees")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void EnableCategory(Category category, bool enabled, EnableOptions options)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disableinstancedtrees")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disableinstancedtrees")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyInstanceTrees")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyInstanceTrees")]
	public static bool IsCategoryEnabled(Category category)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void EnableFrustumTest(bool useCameraFrustum)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool IsFrustumTestEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[CalledBy(Type = typeof(Utils), Member = "CheckIfAkGameObjIsStatic")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool IsRenderObjectInstanceChild(Transform t)
	{
		return default(bool);
	}

	[Calls(Type = typeof(RenderObjectInstanceTriggerVolume), Member = "RegisterInstancingScript")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "Register")]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GeometryUtility), Member = "CalculateFrustumPlanes")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "FinishInitialization")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 12)]
	private void Setup()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableCategory")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void EnableRenderers(bool enabled)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRendererForLODGroup")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRenderers")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[CallsUnknownMethods(Count = 9)]
	private void EnableRenderersInChildren(Transform parent, bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshFilterForInstancedRendering")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void EnableRendererForLODGroup(LODGroup group, bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "FinishInitialization")]
	[CallsUnknownMethods(Count = 1)]
	private void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Initialize")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Setup")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "ReserveBatchName")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
	private void CreateBatchList(RenderObjectInstanceSceneData[] sceneDataComponents)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "PopulateBatchListWithChildren")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Setup")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Initialize")]
	private void PopulateBatchList(RenderObjectInstanceSceneData[] sceneDataComponents)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "PopulateBatchListWithChildren")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "AddLODGroupToBatchList")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "PopulateBatchListWithChildren")]
	private void PopulateBatchListWithChildren(Transform parent)
	{
	}

	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "PopulateBatchListWithChildren")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 11)]
	private void AddLODGroupToBatchList(LODGroup group)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private MaterialPropertyBlock GetMaterialPropertiesForLod(int batchIndex)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "OnDisable")]
	[Calls(Type = typeof(RenderObjectInstanceBatches.PerBatch), Member = "Dispose")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "OnDestroy")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "WaitForJobs")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstanceBatches.PerObject), Member = "Dispose")]
	private void Cleanup()
	{
	}

	[Calls(Type = typeof(RenderObjectInstance), Member = "UpdateLodMaterialProperties")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdateAll")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "ScheduleJobs")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "WaitForJobs")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "TestClipPlaneDistance")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "UpdateLODs")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "Setup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "TestVolumes")]
	private void EarlyUpdate()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "InitializeJob")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchCount")]
	private void ScheduleJobs()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumPlanes")]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumCorners")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(JobVisUtils), Member = "UpdateDirectionalLightCullingPlanes")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateFrustumArrays()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "LateUpdate")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JobHandle), Member = "CompleteAll")]
	private void WaitForJobs()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "WaitForJobs")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "RenderBatch")]
	[CallsUnknownMethods(Count = 5)]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 1)]
	private void UpdateLODs(float4 camPos)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[CallsUnknownMethods(Count = 6)]
	private void GetLodDistances(out float lod1Distance, out float lod2Distance, out float lod3Distance)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref lod1Distance) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref lod2Distance) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref lod3Distance) = null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 4)]
	private void TestClipPlaneDistance()
	{
	}

	[CallsUnknownMethods(Count = 36)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	private void UpdateLodMaterialProperties()
	{
	}

	[CallerCount(Count = 0)]
	private float FastSqrDist3D(Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 11)]
	private void TestVolumes(Vector4 camPos)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void PushTriggerVolume(RenderObjectInstanceTriggerVolume curVolume)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void PopTriggerVolume(RenderObjectInstanceTriggerVolume curVolume)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Awake")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 4)]
	private void Register()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UnRegister()
	{
	}

	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetDebugText")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public string GetDebugText()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RenderObjectInstance()
	{
	}
}
