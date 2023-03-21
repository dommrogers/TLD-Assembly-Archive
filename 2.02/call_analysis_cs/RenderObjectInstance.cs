using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
		[CallerCount(Count = 7)]
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

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRendererForLODGroup")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public static MeshFilter MaybeGetMeshFilterForInstancedRendering(Renderer r)
	{
		return null;
	}

	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
	[CalledBy(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInLODGroup")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshFilterForInstancedRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Mesh MaybeGetMeshForInstancedRendering(Renderer r)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy")]
	[Calls(Type = typeof(GCHandle), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public static void CopyNativeToManaged(NativeArray<Matrix4x4> src, int srcIndex, Matrix4x4[] dst, int dstIndex, int length)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void OnValidate()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "EarlyUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void EarlyUpdateAll()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyRenderObjectInstances")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances_norenderers")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static void EnableAll(bool enabled, EnableOptions options)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_renderobjectinstances_norenderers")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static bool AllEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyInstanceTrees")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disableinstancedtrees")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void EnableCategory(Category category, bool enabled, EnableOptions options)
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyInstanceTrees")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disableinstancedtrees")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsCategoryEnabled(Category category)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void EnableFrustumTest(bool useCameraFrustum)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsFrustumTestEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(Utils), Member = "CheckIfAkGameObjIsStatic")]
	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static bool IsRenderObjectInstanceChild(Transform t)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "Register")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RenderObjectInstanceTriggerVolume), Member = "RegisterInstancingScript")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "OnEnable")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GeometryUtility), Member = "CalculateFrustumPlanes")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "FinishInitialization")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private void Setup()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableCategory")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void EnableRenderers(bool enabled)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRenderers")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRendererForLODGroup")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void EnableRenderersInChildren(Transform parent, bool enabled)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EnableRenderersInChildren")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshFilterForInstancedRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void EnableRendererForLODGroup(LODGroup group, bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "FinishInitialization")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Setup")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = ".ctor")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "ReserveBatchName")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private void CreateBatchList(RenderObjectInstanceSceneData[] sceneDataComponents)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Setup")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "PopulateBatchListWithChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void PopulateBatchList(RenderObjectInstanceSceneData[] sceneDataComponents)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "PopulateBatchListWithChildren")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "AddLODGroupToBatchList")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "PopulateBatchListWithChildren")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void PopulateBatchListWithChildren(Transform parent)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "PopulateBatchListWithChildren")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void AddLODGroupToBatchList(LODGroup group)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private MaterialPropertyBlock GetMaterialPropertiesForLod(int batchIndex)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "OnDestroy")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "WaitForJobs")]
	[Calls(TypeFullName = "RenderObjectInstanceBatches.PerObject", Member = "Dispose")]
	[Calls(TypeFullName = "RenderObjectInstanceBatches.PerBatch", Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void Cleanup()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdateAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "Setup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "UpdateLODs")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "TestVolumes")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "TestClipPlaneDistance")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "UpdateLodMaterialProperties")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "WaitForJobs")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "ScheduleJobs")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void EarlyUpdate()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchCount")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "InitializeJob")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void ScheduleJobs()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumPlanes")]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumCorners")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(JobVisUtils), Member = "UpdateDirectionalLightCullingPlanes")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateFrustumArrays()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JobHandle), Member = "CompleteAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void WaitForJobs()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "WaitForJobs")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "RenderBatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateLODs(float4 camPos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void GetLodDistances(out float lod1Distance, out float lod2Distance, out float lod3Distance)
	{
		lod1Distance = default(float);
		lod2Distance = default(float);
		lod3Distance = default(float);
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void TestClipPlaneDistance()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 36)]
	private void UpdateLodMaterialProperties()
	{
	}

	[CallerCount(Count = 0)]
	private float FastSqrDist3D(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "EarlyUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void TestVolumes(Vector4 camPos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PushTriggerVolume(RenderObjectInstanceTriggerVolume curVolume)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PopTriggerVolume(RenderObjectInstanceTriggerVolume curVolume)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Register()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UnRegister()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetDebugText")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public RenderObjectInstance()
	{
	}
}
