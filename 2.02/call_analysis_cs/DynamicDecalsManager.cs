using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
using UnityEngine;
using UnityEngine.Rendering;

public class DynamicDecalsManager : MonoBehaviour
{
	private struct PlacedSprayPaintDecalInfo
	{
		public DecalProjectorInstance m_ProjectorInstance;

		public Bounds m_Bounds;
	}

	private struct RenderDecalParameters
	{
		public float m_TanFov;

		public float m_InvScreenSizeFadeRange;

		public float m_InvDistanceFadeRange;

		public Vector3 m_CameraPos;

		public Matrix4x4 m_TransformMatrix;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<StaticDecal> _003C_003E9__87_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CPrepareCommandBuffer_003Eb__87_0(StaticDecal a, StaticDecal b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public DecalProjectorInstance decalInstance;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass93_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal bool _003CRemoveDynamicDecal_003Eb__0(PlacedSprayPaintDecalInfo decalInfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass127_0
	{
		public DecalProjectorInstance dpi;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass127_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal bool _003CReturnDecalProjectorInstanceToPool_003Eb__0(PlacedSprayPaintDecalInfo decalInfo)
		{
			return false;
		}
	}

	public int m_MaxNonPlacedDynamicDecals;

	public int m_PoolSizeIncrement;

	public int m_MaxPlacedDynamicDecals;

	public float m_FadeTimeSeconds;

	public float m_PlayerDecalsLifeTimeHours;

	public float m_PlayerDecalsLifeTimeInHighWindsHours;

	public float m_PlayerDecalsLifeTimeInHeavySnowHours;

	public float m_PlayerDecalsLifeTimeInBlizzardHours;

	public float m_NPCDecalsLifeTimeHours;

	public float m_NPCDecalsLifeTimeInHighWindsHours;

	public float m_NPCDecalsLifeTimeInHeavySnowHours;

	public float m_NPCDecalsLifeTimeInBlizzardHours;

	public AnimationCurve m_SprayPaintLifetimeCurve;

	public int m_SprayPaintDecalsLifeTimeDays;

	public int m_SprayPaintDecalsLifeTimeInHighWindsDays;

	public int m_SprayPaintDecalsLifeTimeInHeavySnowDays;

	public int m_SprayPaintDecalsLifeTimeInBlizzardDays;

	public float m_LureDecalLifeTimeMinutes;

	public float m_WardDecalLifeTimeMinutes;

	public float m_DispelFogLifeTimeMinutes;

	public float m_DarkwalkerLifeTimeMinutes;

	private Vector3 m_DecalMapRevealRaycastOffset;

	public Vector3 m_BaseSprayDecalScale;

	public Vector3 m_TreeSprayDecalScale;

	private float m_DecalOverlapLeniencyPercent;

	public float m_LineOfSightDistanceThreshold;

	public List<UvList> m_StaticDecalAtlasUvList;

	private Mesh m_CubeMesh;

	private Material m_StandardMaterial;

	private Material m_GlowMaterial;

	private Material m_AnimatedRevealMaterial;

	public ImpactDecals m_ImpactDecals;

	public DecalSpawnedObject[] m_DecalSpawnedObjects;

	private DecalVariant[] m_DecalVariants;

	private DecalQualitySettings m_LowQualitySettings;

	private DecalQualitySettings m_MediumQualitySettings;

	private DecalQualitySettings m_HighQualitySettings;

	private DecalQualitySettings m_UltraQualitySettings;

	private DecalQualitySettings m_XboxQualitySettings;

	private DecalQualitySettings m_PS4QualitySettings;

	private UvList m_AtlasUvInfo;

	[NonSerialized]
	public bool m_ShowDecalDebugBounds;

	private bool m_EnableInstancedRendering;

	private Camera m_CommandBufferCamera;

	private CommandBuffer m_MainCamCommandBuffer;

	private CommandBuffer m_MaskCommandBuffer;

	private Material m_MaskRenderMaterial;

	private Material m_MaskCopyMaterial;

	private int m_CurrentMaskTextureIndex;

	private RenderTexture[] m_MaskRenderTextures;

	private Queue<DecalProjectorInstance> m_MaskRenderQueue;

	private Collider[] m_MaskOverlapColliders;

	private List<Renderer> m_MaskIgnoredRenderers;

	private List<int> m_UsedMaskTextureIndices;

	private List<DecalProjectorMaskData> m_StaticMasks;

	public const float DEFAULT_DECAL_CLIP_ANGLE_DEGREES = 72.5f;

	private static readonly float s_DefaultClipAngleCos;

	private const int MASK_TEXTURE_SIZE = 128;

	private const int MAX_MASK_COUNT = 128;

	private const int MAX_MASK_OVERLAP_COLLIDERS = 16;

	private int m_NormalsId;

	private int m_MainTexUvId;

	private int m_FadeId;

	private int m_TintId;

	private int m_TintGlowId;

	private int m_RevealAmountId;

	private int m_EraseAmountId;

	private int m_UseLightProbesId;

	private int m_MaskModeId;

	private int m_MaskTexId;

	private int m_ClipAngleId;

	private RenderTargetIdentifier[] m_RenderTargetIdentifiers;

	private List<DecalProjectorInstance> m_DynamicDecalProjectors;

	private List<DecalProjectorInstance> m_FadingDecalProjectors;

	private List<DecalProjectorInstance> m_CullList;

	private List<DecalProjectorInstance> m_Pool_DecalProjectorInstances;

	private int m_NumNonPlacedDynamicDecals;

	private int m_NumPlacedDynamicDecals;

	private List<StaticDecal> m_StaticDecals;

	private List<DecalRenderBatch> m_StaticDecalPropertyBlocks;

	private List<PlacedSprayPaintDecalInfo> m_PlacedSprayPaintDecals;

	private bool m_IsStaticDecalsListDirty;

	private DecalQualitySettings m_CurrentQualitySettings;

	private int m_RenderedDecalCount;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InstantiateDecalProjectorInstances")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InitializeScreenSpaceDecals")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InitializeMaskRendering")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FadeDecal")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ReturnDecalProjectorInstanceToPool")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InitializeCommandBuffers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderMaskForDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderStaticScreenSpaceDecals")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicScreenSpaceDecals")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 35)]
	public void PrepareCommandBuffer(Camera camera)
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DecalProjectorInstance AddImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "LeaveScorchMark")]
	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionStay")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DecalProjectorInstance AddImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, DecalProjectorType projectorType, Vector3 postion, Vector3 forward, float yaw)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ImpactDecals), Member = "GetImpactDecal")]
	[Calls(Type = typeof(ImpactDecal), Member = "GetImpactDecalVariationName")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public DecalProjectorInstance AddSprayPaintDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddProjectorInstanceBoundsInfo")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void PlaceDownSprayPaintDecal(DecalProjectorInstance instance)
	{
	}

	[CallerCount(Count = 0)]
	public void RemoveDynamicDecalFadeout(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EraseDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CleanupDecalToRemove")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelDecalPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SuspendDecalPlacement")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecalProjector")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>), Member = "RemoveAll")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveGlyph")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public void RemoveDynamicDecal(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PlaceDownSprayPaintDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddDynamicDecalProjector")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CalculateDecalTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void TrySpawnDecalObject(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void AddDynamicDecalProjector(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "FadeDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveDynamicDecalProjector(DecalProjectorInstance decalInstance)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 39)]
	private void CheckDynamicDecalNumbers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void RemoveDynamicDecal(string guid)
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool AreAnyPlacedDecalsOfType(ProjectileType projectileType)
	{
		return false;
	}

	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DoesWardGlyphExist")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsLureActive")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "GetWardTimeRemainingScale")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "RemoveDecal")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public DecalProjectorInstance FindFirstDecalOfType(ProjectileType projectileType)
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ReturnDecalProjectorInstanceToPool")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveDecalFromMap(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PlaceDownSprayPaintDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DecalProjectorInstance), Member = "GetBounds")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void AddProjectorInstanceBoundsInfo(DecalProjectorInstance instance)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(CommandBuffer), Member = "Dispose")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RenderTexture), Member = "IsCreated")]
	[Calls(Type = typeof(RenderTexture), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MapDetailUnlockParameters), Member = "GetRangeBoostFromHeightDelta")]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void UnlockDecalMapMarkersNearPosition(MapDetailUnlockParameters parameters)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecalProjectorSaveList), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ShouldSaveDynamicDecal")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(qd_Decal), Member = "MaybeUpdateUvsFromDecalManager")]
	[CalledBy(Type = typeof(qd_Decal), Member = "RefreshStaticDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UvList), Member = "HasUvs")]
	[Calls(Type = typeof(UvList), Member = "GetUvs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool TryGetStaticDecalUvs(string textureName, out Vector4 coordinates)
	{
		coordinates = default(Vector4);
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UvList), Member = "HasUvs")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddProjectorInstanceBoundsInfo")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[Calls(Type = typeof(PlayerManager), Member = "OnDecalDeserialized")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ClearAllDecals()
	{
	}

	[CallerCount(Count = 0)]
	public int GetNumberOfRemainingPlaceableDecals()
	{
		return 0;
	}

	[CalledBy(Type = typeof(ImpactDecals), Member = "AddSprayPaintDecal")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddSprayPaintDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveOldestNonPlacedDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetDecalProjectorInstanceFromPool")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "GenerateNewGuidString")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddDynamicDecalProjector")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public DecalProjectorInstance CreateCustomDecal(string decalName, Vector3 pos, float yaw, Vector3 normal, Vector3 scale, DecalProjectorType projectorType, bool indoors, ProjectileType projectileType)
	{
		return null;
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodDrop")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveStruggleBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveHarvestBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodCluster")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveOldestNonPlacedDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetDecalProjectorInstanceFromPool")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "GenerateNewGuidString")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddDynamicDecalProjector")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public DecalProjectorInstance CreateDecal(Vector3 pos, float yaw, Vector3 normal, int uvRectangleIndex, Vector3 scale, DecalProjectorType projectorType, bool indoors)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddStaticDecal(StaticDecal decal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveStaticDecal(StaticDecal decal)
	{
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	public int LookupUVRectangleIndex(string name)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool CanCreateFootPrintsOnMaterial(GameObject materialGameObject)
	{
		return false;
	}

	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateDecalProjectorLifeTimes()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	[CallerCount(Count = 3)]
	private float ComputeDecalProjectorLifeTime(DecalProjectorType projectorType, bool indoors, ProjectileType decalShape = ProjectileType.Bullet)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FadeDecal")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveOldestNonPlacedDecal()
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveOldestNonPlacedDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecalProjector")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void FadeDecal(int decalIdx)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Start")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "GetDecalProjectorInstanceFromPool")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void InstantiateDecalProjectorInstances(int n)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjectorInstance), Member = "GetBounds")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetIntersectedSprayPaintDecal")]
	[CallsUnknownMethods(Count = 1)]
	public DecalProjectorInstance GetIntersectedSprayPaintDecal(DecalProjectorInstance decalToTestAgainst)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public DecalProjectorInstance GetIntersectedSprayPaintDecal(Ray ray, float maxDistance)
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "GetIntersectedSprayPaintDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateOverlappingDecalInPlace")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private DecalProjectorInstance GetIntersectedSprayPaintDecal(Bounds boundsToTestAgainst)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private int GetDecalCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InstantiateDecalProjectorInstances")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private DecalProjectorInstance GetDecalProjectorInstanceFromPool()
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "RemoveAll")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	private void ReturnDecalProjectorInstanceToPool(DecalProjectorInstance dpi)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool ShouldSaveDynamicDecal(DecalProjectorInstance dpi)
	{
		return false;
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 11)]
	private void InitializeScreenSpaceDecals()
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(RenderTexture), Member = "set_antiAliasing")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 32)]
	private void InitializeMaskRendering()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CalculateDecalTransform")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void OnDrawGizmos()
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "OnDrawGizmos")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	private void CalculateDecalTransform(DecalProjectorInstance decal, DecalProjectorMaskData mask, out Vector3 position, out Quaternion rotation, out Vector3 scale)
	{
		position = default(Vector3);
		rotation = default(Quaternion);
		scale = default(Vector3);
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	private int RenderDynamicScreenSpaceDecals(Camera camera, List<DecalProjectorInstance> instances, int renderedDecalCount)
	{
		return 0;
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicScreenSpaceDecals")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CalculateDecalTransform")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(Matrix4x4), Member = "SetTRS")]
	[Calls(Type = typeof(UvList), Member = "GetUvs")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(LightmapSettings), Member = "get_lightProbes")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SetSHCoefficients")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 26)]
	private void RenderDynamicDecal(DecalProjectorInstance decal, DecalProjectorMaskData maskData, RenderDecalParameters parameters, ref int renderedDecalCount)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(Matrix4x4), Member = "SetTRS")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "SetInt")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DecalRenderBatch), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloatArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 59)]
	private int RenderStaticScreenSpaceDecals(Camera camera, List<StaticDecal> instances, int renderedDecalCount)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderMaskForDecal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RenderMasks()
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderMasks")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Matrix4x4), Member = "LookAt")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(Matrix4x4), Member = "Ortho")]
	[Calls(Type = typeof(LODGroup), Member = "get_lodCount")]
	[Calls(Type = typeof(LODGroup), Member = "GetLODs")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Renderer), Member = "get_shadowCastingMode")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "IncrementMaskTextureIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 74)]
	private void RenderMaskForDecal(DecalProjectorInstance decal)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderMaskForDecal")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void IncrementMaskTextureIndex()
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PlaceDownSprayPaintDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlacementPosition")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetRotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 36)]
	private void CollectMasks(DecalProjectorInstance decal)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public void OnQualityChange(QualityPostFx quality)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	public void InitializeCommandBuffers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 95)]
	public DynamicDecalsManager()
	{
	}
}
