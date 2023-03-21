using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using UnityEngine;

public class ArrowItem : MonoBehaviour
{
	internal struct SurfaceResponseInfo
	{
		internal float surfaceHardness;

		internal float deflectScalar;

		internal Vector2 impactVelocityScalars;

		internal ArrowImpactEffectType impactEffect;
	}

	public const float ARROW_LENGTH = 0.76f;

	public const float CENTER_OF_MASS_FRAC = 0.23f;

	public const float MAX_EMBED_FRAC = 0.5f;

	public const float MIN_PIERCE_VEL_BY_SURFACE_SCALE = 0.95f;

	public const float MAX_FALL_OUT_TIME = 1f;

	public const float MIN_STICK_IN_DEPTH = 0.015f;

	public const float MIN_STICK_IN_RANDOM_COMPONENT = 0.01f;

	public const float SOFTEST_DEFLECT_ANGLE = 75f;

	public const float HARDEST_DEFLECT_ANGLE = 0f;

	public const string ARROW_COLLISION_LAYER = "Gear";

	public const float MIN_TIME_BETWEEN_HIT_EFFECTS = 0.1f;

	public const float MIN_VELOCITY_FOR_HIT_EFFECT_SQR = 2f;

	public const float MAX_SINGLE_IMPACT_DAMAGE = 50f;

	public const float STICK_IN_DAMAGE_SCALAR = 0.75f;

	public const float DEFLECTION_DAMAGE_SCALAR = 1.5f;

	public const float ARROW_BOUNDING_RADIUS = 0.5f;

	public const float ANTI_COLLISION_FUDGE_FACTOR = 0.1f;

	public const float INTERIOR_CORRECTION_TEST_DIST = 8f;

	public GameObject m_ArrowMesh;

	public LineRenderer m_LineRenderer;

	public GameObject m_PlacementHelper;

	public bool m_CapsuleCollisionDebug;

	public const int MAX_LINE_POINTS = 50;

	public const float LINE_INTENSITY = 0.7f;

	public const float LINE_FADE_OUT_TIME = 0.5f;

	public const float MIN_TRAIL_STEP_SQR = 4f;

	private Vector3[] m_LinePoints;

	private int m_LineBase;

	private int m_LineNumPts;

	private Vector3 m_FirstContact;

	private float m_FirstContactTime;

	public float m_ReleaseVelocity;

	public float m_ReleaseDrag;

	public float m_VictimDamage;

	public float m_XZDampeningScalar;

	public Vector2 m_XZDampeningRange;

	public float m_ImpactVelocityScalar;

	public GameObject m_BrokenArrow;

	public string m_FlightAudio;

	public string m_ImpactAudio;

	public string m_BreakAudio;

	public float m_ImpactAudioCooldown;

	public float m_GearImpactForce;

	public float m_GearImpactUpwardForce;

	public float m_GearImpactTorqueForce;

	[NonSerialized]
	public GearItem m_GearItem;

	private Rigidbody m_Rigidbody;

	private int m_ContactCount;

	private float m_EmbeddedDepth;

	private BaseAi m_EmbeddedInAi;

	private float m_EmbeddedInAiDeadTime;

	private float m_FallOutTimer;

	private float m_ReleaseTime;

	private float m_LastEffectTime;

	private uint m_FlightAudioId;

	private bool m_Initialized;

	private Vector3 m_LastPosition;

	private Vector3 m_LastVelocity;

	private ArrowSaveData m_DeferredSaveData;

	private int m_DeferredSaveRetryCounter;

	private Vector3 m_LastCollisionPoint;

	private float m_BlockImpactAudioUntil;

	private bool m_FellThroughWorld;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrowItem), Member = "Initialize")]
	private void Awake()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsUnknownMethods(Count = 3)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(ArrowManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 22)]
	public ArrowSaveData Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[Calls(Type = typeof(ArrowItem), Member = "ParentToObject")]
	[CalledBy(Type = typeof(ArrowManager), Member = "Deserialize")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void Deserialize(ArrowSaveData asd)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "ApplyForce")]
	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void ApplyForcesToGear(GearItem gi, Vector3 normal)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "set_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(ArrowItem), Member = "StopArrow")]
	[Calls(Type = typeof(Rigidbody), Member = "IsSleeping")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	private void FixedUpdate()
	{
	}

	[Calls(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(ArrowItem), Member = "RefreshLineRenderer")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(ArrowItem), Member = "RefreshLineRenderer")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(ArrowItem), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	private void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(ArrowItem), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void Fire()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool InFlight(bool onlyConsiderFirstImpact)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool BelongsToPlayer()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClear")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 3)]
	public void DetachIntoWorld()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	public void SetPlacementHelperEnabled(bool enabled)
	{
	}

	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrowItem), Member = "ApplyForcesToGear")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "FixedUpdate")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private void StopArrow()
	{
	}

	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(ArrowItem), Member = "Break")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ArrowItem), Member = "MaybeScareWildlife")]
	[Calls(Type = typeof(ArrowItem), Member = "StopArrow")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(ArrowItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionEnter")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(ArrowItem), Member = "GetSurfaceResponseInfo")]
	[Calls(Type = typeof(ArrowItem), Member = "ParentToObject")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 46)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(ArrowItem), Member = "RefreshLineRenderer")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ImpactDecals), Member = "MapArrowImpactEffectTypeToMaterialEffectType")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[Calls(Type = typeof(ArrowItem), Member = "PlayImpactAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void HandleCollisionWithObject(GameObject collider, Vector3 collisionPoint, Vector3 collisionNormal)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(ImpactDecals), Member = "MapArrowImpactEffectTypeToMaterialEffectType")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ArrowItem), Member = "GetSurfaceResponseInfo")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(ArrowItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallsUnknownMethods(Count = 9)]
	private void ParentToObject(Transform t)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void PlayImpactAudio(string surfaceTag)
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionStay")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private SurfaceResponseInfo GetSurfaceResponseInfo(string surfaceTag, bool isSecondaryHit)
	{
		return default(SurfaceResponseInfo);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ArrowItem), Member = "FixedUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private void FallFree()
	{
	}

	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rigidbody), Member = "set_mass")]
	private void Break()
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	private BaseAi InflictDamage(GameObject victim, float damageScalar, bool stickIn, string collider, Vector3 collisionPoint)
	{
		return null;
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromArrow")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	private void MaybeScareWildlife()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallsUnknownMethods(Count = 8)]
	private void RefreshLineRenderer()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ArrowItem), Member = "Awake")]
	[CalledBy(Type = typeof(ArrowItem), Member = "Fire")]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	public ArrowItem()
	{
	}
}
