using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CPrepareCommandBuffer_003Eb__87_0(StaticDecal a, StaticDecal b)
		{
			return default(int);
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public DecalProjectorInstance decalInstance;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass93_0()
		{
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal bool _003CRemoveDynamicDecal_003Eb__0(PlacedSprayPaintDecalInfo decalInfo)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass127_0
	{
		public DecalProjectorInstance dpi;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass127_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal bool _003CReturnDecalProjectorInstanceToPool_003Eb__0(PlacedSprayPaintDecalInfo decalInfo)
		{
			return default(bool);
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InitializeMaskRendering")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InitializeScreenSpaceDecals")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InstantiateDecalProjectorInstances")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicScreenSpaceDecals")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicScreenSpaceDecals")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderStaticScreenSpaceDecals")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderMaskForDecal")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InitializeCommandBuffers")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ReturnDecalProjectorInstanceToPool")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FadeDecal")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	public void PrepareCommandBuffer(Camera camera)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DecalProjectorInstance AddImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "LeaveScorchMark")]
	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionStay")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CallsUnknownMethods(Count = 1)]
	public DecalProjectorInstance AddImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, DecalProjectorType projectorType, Vector3 postion, Vector3 forward, float yaw)
	{
		return null;
	}

	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[Calls(Type = typeof(ImpactDecal), Member = "GetImpactDecalVariationName")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ImpactDecals), Member = "GetImpactDecal")]
	public DecalProjectorInstance AddSprayPaintDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddProjectorInstanceBoundsInfo")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public void PlaceDownSprayPaintDecal(DecalProjectorInstance instance)
	{
	}

	[CallerCount(Count = 0)]
	public void RemoveDynamicDecalFadeout(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(PlayerManager), Member = "SuspendDecalPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelDecalPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CleanupDecalToRemove")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EraseDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveGlyph")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecalProjector")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	public void RemoveDynamicDecal(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddDynamicDecalProjector")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PlaceDownSprayPaintDecal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CalculateDecalTransform")]
	private void TrySpawnDecalObject(DecalProjectorInstance decalInstance)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CallsUnknownMethods(Count = 2)]
	private void AddDynamicDecalProjector(DecalProjectorInstance decalInstance)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "FadeDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void RemoveDynamicDecalProjector(DecalProjectorInstance decalInstance)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 39)]
	private void CheckDynamicDecalNumbers()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	public void RemoveDynamicDecal(string guid)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[CallsUnknownMethods(Count = 3)]
	public bool AreAnyPlacedDecalsOfType(ProjectileType projectileType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "RemoveDecal")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsLureActive")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DoesWardGlyphExist")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "GetWardTimeRemainingScale")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	public DecalProjectorInstance FindFirstDecalOfType(ProjectileType projectileType)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ReturnDecalProjectorInstanceToPool")]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveDecalFromMap(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DecalProjectorInstance), Member = "GetBounds")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PlaceDownSprayPaintDecal")]
	private void AddProjectorInstanceBoundsInfo(DecalProjectorInstance instance)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(RenderTexture), Member = "Release")]
	[Calls(Type = typeof(RenderTexture), Member = "IsCreated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CommandBuffer), Member = "Dispose")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(CommandBuffer), Member = "Dispose")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[Calls(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[Calls(Type = typeof(MapDetailUnlockParameters), Member = "GetRangeBoostFromHeightDelta")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void UnlockDecalMapMarkersNearPosition(MapDetailUnlockParameters parameters)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ShouldSaveDynamicDecal")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(DecalProjectorSaveList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(qd_Decal), Member = "RefreshStaticDecal")]
	[CalledBy(Type = typeof(qd_Decal), Member = "MaybeUpdateUvsFromDecalManager")]
	[Calls(Type = typeof(UvList), Member = "GetUvs")]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UvList), Member = "HasUvs")]
	public bool TryGetStaticDecalUvs(string textureName, out Vector4 coordinates)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector4, @null>(ref coordinates) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(PlayerManager), Member = "OnDecalDeserialized")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddProjectorInstanceBoundsInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(UvList), Member = "HasUvs")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ClearAllDecals()
	{
	}

	[CallerCount(Count = 0)]
	public int GetNumberOfRemainingPlaceableDecals()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddSprayPaintDecal")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddSprayPaintDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddDynamicDecalProjector")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveOldestNonPlacedDecal")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "GenerateNewGuidString")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetDecalProjectorInstanceFromPool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	public DecalProjectorInstance CreateCustomDecal(string decalName, Vector3 pos, float yaw, Vector3 normal, Vector3 scale, DecalProjectorType projectorType, bool indoors, ProjectileType projectileType)
	{
		return null;
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveStruggleBloodStain")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodCluster")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveHarvestBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodStain")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddDynamicDecalProjector")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodDrop")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "GenerateNewGuidString")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetDecalProjectorInstanceFromPool")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveOldestNonPlacedDecal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	public DecalProjectorInstance CreateDecal(Vector3 pos, float yaw, Vector3 normal, int uvRectangleIndex, Vector3 scale, DecalProjectorType projectorType, bool indoors)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void AddStaticDecal(StaticDecal decal)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveStaticDecal(StaticDecal decal)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	public int LookupUVRectangleIndex(string name)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanCreateFootPrintsOnMaterial(GameObject materialGameObject)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void UpdateDecalProjectorLifeTimes()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	private float ComputeDecalProjectorLifeTime(DecalProjectorType projectorType, bool indoors, ProjectileType decalShape = ProjectileType.Bullet)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FadeDecal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void RemoveOldestNonPlacedDecal()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecalProjector")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveOldestNonPlacedDecal")]
	[CallsUnknownMethods(Count = 4)]
	private void FadeDecal(int decalIdx)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "GetDecalProjectorInstanceFromPool")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Start")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void InstantiateDecalProjectorInstances(int n)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetIntersectedSprayPaintDecal")]
	[Calls(Type = typeof(DecalProjectorInstance), Member = "GetBounds")]
	[CallerCount(Count = 0)]
	public DecalProjectorInstance GetIntersectedSprayPaintDecal(DecalProjectorInstance decalToTestAgainst)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallsUnknownMethods(Count = 9)]
	public DecalProjectorInstance GetIntersectedSprayPaintDecal(Ray ray, float maxDistance)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "GetIntersectedSprayPaintDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateOverlappingDecalInPlace")]
	[CallsUnknownMethods(Count = 8)]
	private DecalProjectorInstance GetIntersectedSprayPaintDecal(Bounds boundsToTestAgainst)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private int GetDecalCount()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InstantiateDecalProjectorInstances")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	private DecalProjectorInstance GetDecalProjectorInstanceFromPool()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	private void ReturnDecalProjectorInstanceToPool(DecalProjectorInstance dpi)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	private static bool ShouldSaveDynamicDecal(DecalProjectorInstance dpi)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Start")]
	[CallsUnknownMethods(Count = 11)]
	private void InitializeScreenSpaceDecals()
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Start")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(RenderTexture), Member = "set_antiAliasing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	private void InitializeMaskRendering()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CalculateDecalTransform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CalculateDecalTransform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void OnDrawGizmos()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "OnDrawGizmos")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "OnDrawGizmos")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	private void CalculateDecalTransform(DecalProjectorInstance decal, DecalProjectorMaskData mask, out Vector3 position, out Quaternion rotation, out Vector3 scale)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref position) = null;
		System.Runtime.CompilerServices.Unsafe.As<Quaternion, @null>(ref rotation) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref scale) = null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	private int RenderDynamicScreenSpaceDecals(Camera camera, List<DecalProjectorInstance> instances, int renderedDecalCount)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SetSHCoefficients")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicScreenSpaceDecals")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicScreenSpaceDecals")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(LightmapSettings), Member = "get_lightProbes")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(UvList), Member = "GetUvs")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CalculateDecalTransform")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(Matrix4x4), Member = "SetTRS")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	private void RenderDynamicDecal(DecalProjectorInstance decal, DecalProjectorMaskData maskData, RenderDecalParameters parameters, ref int renderedDecalCount)
	{
	}

	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DecalRenderBatch), Member = ".ctor")]
	[Calls(Type = typeof(Matrix4x4), Member = "SetTRS")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloatArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloatArray")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Material), Member = "SetInt")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(Matrix4x4), Member = "SetTRS")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "SetInt")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	private int RenderStaticScreenSpaceDecals(Camera camera, List<StaticDecal> instances, int renderedDecalCount)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderMaskForDecal")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void RenderMasks()
	{
	}

	[Calls(Type = typeof(LODGroup), Member = "GetLODs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Renderer), Member = "get_shadowCastingMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsUnknownMethods(Count = 74)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderMasks")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "IncrementMaskTextureIndex")]
	[Calls(Type = typeof(LODGroup), Member = "get_lodCount")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Matrix4x4), Member = "Ortho")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Matrix4x4), Member = "LookAt")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	private void RenderMaskForDecal(DecalProjectorInstance decal)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderMaskForDecal")]
	private void IncrementMaskTextureIndex()
	{
	}

	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PlaceDownSprayPaintDecal")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetRotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlacementPosition")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void CollectMasks(DecalProjectorInstance decal)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public void OnQualityChange(QualityPostFx quality)
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "Start")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	public void InitializeCommandBuffers()
	{
	}

	[CallsUnknownMethods(Count = 95)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallerCount(Count = 0)]
	public DynamicDecalsManager()
	{
	}
}
