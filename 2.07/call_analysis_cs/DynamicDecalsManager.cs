using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
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

		public static Comparison<StaticDecal> _003C_003E9__89_0;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CPrepareCommandBuffer_003Eb__89_0(StaticDecal a, StaticDecal b)
		{
			return default(int);
		}
	}

	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public DecalProjectorInstance decalInstance;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass95_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal bool _003CRemoveDynamicDecal_003Eb__0(PlacedSprayPaintDecalInfo decalInfo)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public DecalProjectorInstance dpi;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass129_0()
		{
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal bool _003CReturnDecalProjectorInstanceToPool_003Eb__0(PlacedSprayPaintDecalInfo decalInfo)
		{
			return default(bool);
		}
	}

	private PanelReference<Panel_Map> m_Map;

	private PanelReference<Panel_SprayPaint> m_SprayPaint;

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
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InitializeScreenSpaceDecals")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InitializeMaskRendering")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Start()
	{
	}

	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderMaskForDecal")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicScreenSpaceDecals")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicScreenSpaceDecals")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderStaticScreenSpaceDecals")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InitializeCommandBuffers")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FadeDecal")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	public void PrepareCommandBuffer(Camera camera)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionStay")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "LeaveScorchMark")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	public DecalProjectorInstance AddImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	public DecalProjectorInstance AddImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, DecalProjectorType projectorType, Vector3 postion, Vector3 forward, float yaw)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ImpactDecals), Member = "GetImpactDecal")]
	[Calls(Type = typeof(ImpactDecal), Member = "GetImpactDecalVariationName")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CallsUnknownMethods(Count = 3)]
	public DecalProjectorInstance AddSprayPaintDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddProjectorInstanceBoundsInfo")]
	public void PlaceDownSprayPaintDecal(DecalProjectorInstance instance)
	{
	}

	[CallerCount(Count = 0)]
	public void RemoveDynamicDecalFadeout(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EraseDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CleanupDecalToRemove")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelDecalPlacement")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveGlyph")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SuspendDecalPlacement")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecalProjector")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMarkerRemove")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	public void RemoveDynamicDecal(DecalProjectorInstance decalInstance)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddDynamicDecalProjector")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PlaceDownSprayPaintDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CalculateDecalTransform")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	private void TrySpawnDecalObject(DecalProjectorInstance decalInstance)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[CallsUnknownMethods(Count = 2)]
	private void AddDynamicDecalProjector(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "FadeDecal")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void RemoveDynamicDecalProjector(DecalProjectorInstance decalInstance)
	{
	}

	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void CheckDynamicDecalNumbers()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void RemoveDynamicDecal(string guid)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[CallerCount(Count = 1)]
	public bool AreAnyPlacedDecalsOfType(ProjectileType projectileType)
	{
		return default(bool);
	}

	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DoesWardGlyphExist")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsLureActive")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "GetWardTimeRemainingScale")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "RemoveDecal")]
	[CallsUnknownMethods(Count = 4)]
	public DecalProjectorInstance FindFirstDecalOfType(ProjectileType projectileType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "ReturnDecalProjectorInstanceToPool")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	private void RemoveDecalFromMap(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PlaceDownSprayPaintDecal")]
	private void AddProjectorInstanceBoundsInfo(DecalProjectorInstance instance)
	{
	}

	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(RenderTexture), Member = "Release")]
	[Calls(Type = typeof(RenderTexture), Member = "IsCreated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(CommandBuffer), Member = "Dispose")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "Dispose")]
	public void OnDestroy()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(MapDetailUnlockParameters), Member = "GetRangeBoostFromHeightDelta")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[CallerCount(Count = 2)]
	public void UnlockDecalMapMarkersNearPosition(MapDetailUnlockParameters parameters)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 5)]
	public static string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(qd_Decal), Member = "RefreshStaticDecal")]
	[CalledBy(Type = typeof(qd_Decal), Member = "MaybeUpdateUvsFromDecalManager")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UvList), Member = "HasUvs")]
	[Calls(Type = typeof(UvList), Member = "GetUvs")]
	public bool TryGetStaticDecalUvs(string textureName, out Vector4 coordinates)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector4, @null>(ref coordinates) = null;
		return default(bool);
	}

	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddProjectorInstanceBoundsInfo")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(PlayerManager), Member = "OnDecalDeserialized")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(UvList), Member = "HasUvs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearAllDecals()
	{
	}

	[CallerCount(Count = 0)]
	public int GetNumberOfRemainingPlaceableDecals()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddSprayPaintDecal")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddSprayPaintDecal")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetDecalProjectorInstanceFromPool")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveOldestNonPlacedDecal")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	public DecalProjectorInstance CreateCustomDecal(string decalName, Vector3 pos, float yaw, Vector3 normal, Vector3 scale, DecalProjectorType projectorType, bool indoors, ProjectileType projectileType)
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodCluster")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveHarvestBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveStruggleBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodDrop")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetDecalProjectorInstanceFromPool")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveOldestNonPlacedDecal")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	public DecalProjectorInstance CreateDecal(Vector3 pos, float yaw, Vector3 normal, int uvRectangleIndex, Vector3 scale, DecalProjectorType projectorType, bool indoors)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void AddStaticDecal(StaticDecal decal)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveStaticDecal(StaticDecal decal)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[CalledBy(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[CalledBy(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	public int LookupUVRectangleIndex(string name)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool CanCreateFootPrintsOnMaterial(GameObject materialGameObject)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "ComputeDecalProjectorLifeTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateDecalProjectorLifeTimes()
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Weather), Member = "IsHeavySnow")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Weather), Member = "IsHeavySnow")]
	private float ComputeDecalProjectorLifeTime(DecalProjectorType projectorType, bool indoors, ProjectileType decalShape = ProjectileType.Bullet)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FadeDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	private void RemoveOldestNonPlacedDecal()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecalProjector")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveOldestNonPlacedDecal")]
	[CallsUnknownMethods(Count = 3)]
	private void FadeDecal(int decalIdx)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "GetDecalProjectorInstanceFromPool")]
	private void InstantiateDecalProjectorInstances(int n)
	{
	}

	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetIntersectedSprayPaintDecal")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public DecalProjectorInstance GetIntersectedSprayPaintDecal(DecalProjectorInstance decalToTestAgainst)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public DecalProjectorInstance GetIntersectedSprayPaintDecal(Ray ray, float maxDistance)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "GetIntersectedSprayPaintDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateOverlappingDecalInPlace")]
	[CallsUnknownMethods(Count = 3)]
	private DecalProjectorInstance GetIntersectedSprayPaintDecal(Bounds boundsToTestAgainst)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private int GetDecalCount()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "InstantiateDecalProjectorInstances")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	private DecalProjectorInstance GetDecalProjectorInstanceFromPool()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void ReturnDecalProjectorInstanceToPool(DecalProjectorInstance dpi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool ShouldSaveDynamicDecal(DecalProjectorInstance dpi)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Start")]
	[CallsUnknownMethods(Count = 11)]
	private void InitializeScreenSpaceDecals()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Start")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(RenderTexture), Member = "set_antiAliasing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	private void InitializeMaskRendering()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CalculateDecalTransform")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CalculateDecalTransform")]
	private void OnDrawGizmos()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "OnDrawGizmos")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "OnDrawGizmos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	private void CalculateDecalTransform(DecalProjectorInstance decal, DecalProjectorMaskData mask, out Vector3 position, out Quaternion rotation, out Vector3 scale)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref position) = null;
		System.Runtime.CompilerServices.Unsafe.As<Quaternion, @null>(ref rotation) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref scale) = null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	private int RenderDynamicScreenSpaceDecals(Camera camera, List<DecalProjectorInstance> instances, int renderedDecalCount)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicScreenSpaceDecals")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicScreenSpaceDecals")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(Utils), Member = "SetSHCoefficients")]
	[Calls(Type = typeof(LightmapSettings), Member = "get_lightProbes")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CalculateDecalTransform")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(UvList), Member = "GetUvs")]
	private void RenderDynamicDecal(DecalProjectorInstance decal, DecalProjectorMaskData maskData, RenderDecalParameters parameters, ref int renderedDecalCount)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(DecalRenderBatch), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloatArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloatArray")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(Material), Member = "SetInt")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "SetInt")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	private int RenderStaticScreenSpaceDecals(Camera camera, List<StaticDecal> instances, int renderedDecalCount)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RenderMaskForDecal")]
	[CallsUnknownMethods(Count = 2)]
	private void RenderMasks()
	{
	}

	[Calls(Type = typeof(DynamicDecalsManager), Member = "IncrementMaskTextureIndex")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(Renderer), Member = "get_shadowCastingMode")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallsUnknownMethods(Count = 57)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderMasks")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(LODGroup), Member = "GetLODs")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(LODGroup), Member = "get_lodCount")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(Matrix4x4), Member = "Ortho")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void RenderMaskForDecal(DecalProjectorInstance decal)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderMaskForDecal")]
	[CallsUnknownMethods(Count = 1)]
	private void IncrementMaskTextureIndex()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PlaceDownSprayPaintDecal")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlacementPosition")]
	private void CollectMasks(DecalProjectorInstance decal)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public void OnQualityChange(QualityPostFx quality)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "Start")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	public void InitializeCommandBuffers()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	public DynamicDecalsManager()
	{
	}
}
