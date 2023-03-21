using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;

public class SnowPatchManager : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SnowPatch> _003C_003E9__123_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CLateUpdate_003Eb__123_0(SnowPatch a, SnowPatch b)
		{
			return 0;
		}
	}

	public const int MAX_ACTIVE_PATCHES_LOW = 200;

	public const int MAX_ACTIVE_PATCHES_MEDIUM = 250;

	public const int MAX_ACTIVE_PATCHES_HIGH = 300;

	public const int MAX_ACTIVE_PATCHES_ULTRA = 400;

	public const int MAX_PATCHES_ADDED_PER_FRAME = 1;

	public const float SNOW_PATCH_BOUNDS_SIZE = 2f;

	public const float SNOW_PATCH_HM_POS_SCALE = 0.5f;

	public const float SNOW_PATCH_BOUNDS_SIZE_HALF = 1f;

	public const float SNOW_PATCH_BOUNDS_SCALE = 0.5f;

	public const int PATCH_HIGH_RES_SUBDIVS = 80;

	public const int PATCH_MEDIUM_RES_SUBDIVS = 50;

	public const int PATCH_LOW_RES_SUBDIVS = 30;

	public const float HIGH_RES_PATCH_STEP = 1f / 79f;

	public const float MED_RES_PATCH_STEP = 1f / 49f;

	public const float LOW_RES_PATCH_STEP = 1f / 29f;

	public static bool m_Active;

	public bool m_DebugSkipHeightMapRendering;

	public bool m_DebugSkipBumppedDecalRendering;

	public float m_DebugForcedImprintDepth;

	public bool m_DebugShowBounds;

	public bool m_DebugShowPatches;

	public float m_MaxImprintDepth;

	public float m_BumpedDecalFillInRateScalar;

	public float m_NormalPowLow;

	public float m_NormalPowHigh;

	public float m_TopBlendScalarLow;

	public float m_TopBlendScalarHigh;

	public float m_FadeBandForHeightMap;

	public float m_FadeStartBumpDist;

	public float m_FadeEndBumpDist;

	public float m_DecalIntensity;

	public float m_MaxImprintDistanceFromPatch;

	public float m_SnowDepthPerHour;

	public float m_WindDepthPerHour;

	public float m_PatchDeviationForInvalidCheck;

	public float m_HeightMapInvalidThreshold;

	public float m_HMTangentInvalidThreshold;

	public float m_BumpDecalInvalidThreshold;

	public float m_BumpDecalNormalThreshold;

	public float m_DrawDistanceLow;

	public int m_ImprintsPerPatchLow;

	public float m_PassiveDepthPerHourLow;

	public float m_DrawDistanceMedium;

	public int m_ImprintsPerPatchMedium;

	public float m_PassiveDepthPerHourMedium;

	public float m_DrawDistanceHigh;

	public int m_ImprintsPerPatchHigh;

	public float m_PassiveDepthPerHourHigh;

	public float m_DrawDistanceUltra;

	public int m_ImprintsPerPatchUltra;

	public float m_PassiveDepthPerHourUltra;

	public Material m_PatchHeightMaterial;

	public Material m_HeightMapImprintMaterial;

	public Material m_SnowPatchHoleCutterMaterial;

	public Material m_SnowPatchFinalMaterial;

	public Material m_NormalMapDecalMaterial;

	public UvList m_HeightMapUvInfo;

	public UvList m_NormalMapUvInfo;

	public Mesh m_CubeMesh;

	public Mesh[] m_HeightMapGridMesh_High;

	public Mesh[] m_HeightMapGridMesh_Medium;

	public Mesh[] m_HeightMapGridMesh_Low;

	public Mesh[] m_PatchHeightMapGridMeshes;

	public RenderTexture[] m_HeightMapRenderTextures;

	private float m_RenderCaptureDistance;

	private Stack<SnowPatch> m_AvailablePatches;

	private List<SnowPatch> m_ActivePatches;

	private OctreeBounds<SnowPatch> m_Octree;

	private Dictionary<int, SnowPatch> m_PatchDict;

	private List<SnowPatch>[] m_CaptureLists;

	private int m_CaptureTick;

	private List<SnowPatch> m_GetCollidingResults;

	private Bounds[] m_ImprintBounds;

	public static Mesh m_ImprintMesh;

	private int[] m_HeightMapRenderTextureTypes;

	private CommandBuffer m_HeightMapCommandBuffer;

	private CommandBuffer m_MainCamCommandBuffer1;

	private CommandBuffer m_MainCamCommandBuffer2;

	private CommandBuffer m_MainCamCommandBuffer3;

	private int[] m_CoeffIds;

	private int m_ImprintInfoId;

	private int m_HeightMapUvInfoId;

	private int m_ConfigId;

	private int m_CamZId;

	private int m_LimitsId;

	private int m_PatchFadeId;

	private int m_HeightMapId;

	private int m_NormalsId;

	private int m_MainTexUvId;

	private int m_BumpMapUvId;

	private int m_LocalNormalId;

	private int m_DeviationWeightId;

	private int m_DecalParamsId;

	private SnowfallManager m_SnowfallManager;

	private float m_PassiveDepthPerHour;

	private bool m_StartHasBeenCalled;

	private int m_LastSeenFrame;

	private int m_NumPatchesAddedThisFrame;

	private bool m_HasShownPatchStarvationWarning;

	public static SnowPatchManager m_Instance;

	private const CameraEvent HEIGHT_MAP_COMMAND_BUFFER_EVENT = CameraEvent.BeforeLighting;

	private const CameraEvent HOLE_CUTTER_CAMERA_EVENT = CameraEvent.BeforeLighting;

	private const CameraEvent SNOW_PATCH_CAMERA_EVENT = CameraEvent.BeforeLighting;

	private const CameraEvent BUMPED_DECAL_CAMERA_EVENT = CameraEvent.BeforeLighting;

	private RenderTargetIdentifier[] m_RenderTargetIdentifiers;

	private static Matrix4x4 m_WorkMat;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "DeserializeGlobal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(OctreeBounds<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InitializeCommandBuffers")]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[Calls(Type = typeof(Utils), Member = "BuildGridMeshXZ")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallsUnknownMethods(Count = 121)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "AllocateResources")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stack<>), Member = "Push")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	private void AllocatePatches(int num)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "OnQualityChange")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowPatchManager), Member = "AllocatePatches")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 66)]
	private void AllocateResources(QualityFootprints quality)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowfallManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public string SerializeGlobal()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowPatchManager), Member = "Start")]
	[Calls(Type = typeof(SnowfallManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void DeserializeGlobal(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AdjustSnowDepthRecord(float baseDepth)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowPatchManager), Member = "AllocateResources")]
	public void OnQualityChange(QualityFootprints quality)
	{
	}

	[CalledBy(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Stack<>), Member = "Push")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void RemovePatchRef(int id)
	{
	}

	[CalledBy(Type = typeof(FootstepGroup), Member = "Show")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowImprint), Member = "get_Position")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SnowPatchManager), Member = "GetOverlappedBoundsForImprint")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(SnowPatchManager), Member = "CanAddPatch")]
	[Calls(Type = typeof(SnowPatchManager), Member = "AddPatch")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(SnowPatch), Member = "AddImprint")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 36)]
	public bool AddImprint(SnowImprint imprint, float imprintSize, ref HashSet<int> referencedPatches)
	{
		return false;
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "AddImprint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 20)]
	private int GetOverlappedBoundsForImprint(Bounds imprintBounds)
	{
		return 0;
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "AddImprint")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "AddPatch")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool CanAddPatch()
	{
		return false;
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "AddImprint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowPatchManager), Member = "CanAddPatch")]
	[Calls(Type = typeof(Stack<>), Member = "Pop")]
	[Calls(Type = typeof(SnowPatch), Member = "Initialize")]
	[Calls(Type = typeof(OctreeBounds<>), Member = "Add")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public bool AddPatch(Vector3 centre, out SnowPatch sp)
	{
		sp = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Stack<>), Member = "Push")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void RemovePatch(SnowPatch sp)
	{
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetLocalSnowDepth()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Weather), Member = "GetFallingSnowIntensity")]
	[Calls(Type = typeof(SnowfallManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part2")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(OctreeBounds<>), Member = "FrustumCapture")]
	[Calls(Type = typeof(List<>), Member = "get_Item")]
	[Calls(Type = typeof(SnowPatch), Member = "OnRenderCapture")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(Type = typeof(SnowPatchManager), Member = "GetLocalSnowDepth")]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector4), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(Vector3), Member = "get_back")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS")]
	[Calls(Type = typeof(Matrix4x4), Member = "Ortho")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(Vector3), Member = "op_Subtraction")]
	[Calls(Type = typeof(Vector3), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector4), Member = "op_Implicit")]
	[Calls(Type = typeof(Matrix4x4), Member = "SetTRS")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture")]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 86)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public SnowPatchManager()
	{
	}
}
