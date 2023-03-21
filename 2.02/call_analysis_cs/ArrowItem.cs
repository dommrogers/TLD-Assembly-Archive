using System;
using Cpp2ILInjected.CallAnalysis;
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

	public const float MIN_TIME_BETWEEN_HIT_EFFECTS = 0.05f;

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

	[Calls(Type = typeof(ArrowItem), Member = "Initialize")]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CallsUnknownMethods(Count = 4)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(ArrowManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	public ArrowSaveData Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ArrowManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(ArrowItem), Member = "ParentToObject")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	public void Deserialize(ArrowSaveData asd)
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(GearItem), Member = "ApplyForce")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void ApplyForcesToGear(GearItem gi, Vector3 normal)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(ArrowItem), Member = "StopArrow")]
	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(Transform), Member = "set_forward")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Rigidbody), Member = "IsSleeping")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	private void FixedUpdate()
	{
	}

	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(ArrowItem), Member = "RefreshLineRenderer")]
	[Calls(Type = typeof(ArrowItem), Member = "RefreshLineRenderer")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(LineRenderer), Member = "set_positionCount")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(ArrowItem), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(ArrowItem), Member = "Initialize")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public void Fire()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool InFlight(bool onlyConsiderFirstImpact)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool BelongsToPlayer()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "FromToRotation")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClear")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void DetachIntoWorld()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 3)]
	public void SetPlacementHelperEnabled(bool enabled)
	{
	}

	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(ContactPoint), Member = "get_otherCollider")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(ArrowItem), Member = "ApplyForcesToGear")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "FixedUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	private void StopArrow()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(ArrowItem), Member = "ParentToObject")]
	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(ArrowItem), Member = "Break")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ArrowItem), Member = "MaybeScareWildlife")]
	[Calls(Type = typeof(ArrowItem), Member = "StopArrow")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(ArrowItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionEnter")]
	[CallsUnknownMethods(Count = 86)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 49)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(ArrowItem), Member = "GetSurfaceResponseInfo")]
	[Calls(Type = typeof(ArrowItem), Member = "RefreshLineRenderer")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(ArrowItem), Member = "PlayImpactAudio")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[Calls(Type = typeof(ImpactDecals), Member = "MapArrowImpactEffectTypeToMaterialEffectType")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void HandleCollisionWithObject(GameObject collider, Vector3 collisionPoint, Vector3 collisionNormal)
	{
	}

	[Calls(Type = typeof(ArrowItem), Member = "GetSurfaceResponseInfo")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(ImpactDecals), Member = "MapArrowImpactEffectTypeToMaterialEffectType")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "Deserialize")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	private void ParentToObject(Transform t)
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[CallerCount(Count = 2)]
	private void PlayImpactAudio(string surfaceTag)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionStay")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private SurfaceResponseInfo GetSurfaceResponseInfo(string surfaceTag, bool isSecondaryHit)
	{
		return default(SurfaceResponseInfo);
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	private void FallFree()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_mass")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void Break()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[Calls(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	private BaseAi InflictDamage(GameObject victim, float damageScalar, bool stickIn, string collider, Vector3 collisionPoint)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromArrow")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsUnknownMethods(Count = 9)]
	private void RefreshLineRenderer()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ArrowItem), Member = "Awake")]
	[CalledBy(Type = typeof(ArrowItem), Member = "Fire")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ArrowItem()
	{
	}
}
