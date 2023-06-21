using System;
using AK.Wwise;
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

	private const float ARROW_LENGTH = 0.76f;

	private const float CENTER_OF_MASS_FRAC = 0.23f;

	private const float MAX_EMBED_FRAC = 0.5f;

	private const float MIN_PIERCE_VEL_BY_SURFACE_SCALE = 0.95f;

	private const float MAX_FALL_OUT_TIME = 1f;

	private const float MIN_STICK_IN_DEPTH = 0.015f;

	private const float MIN_STICK_IN_RANDOM_COMPONENT = 0.01f;

	private const float SOFTEST_DEFLECT_ANGLE = 75f;

	private const float HARDEST_DEFLECT_ANGLE = 0f;

	private const float MIN_TIME_BETWEEN_HIT_EFFECTS = 0.1f;

	private const float MIN_VELOCITY_FOR_HIT_EFFECT_SQR = 2f;

	private const float MAX_SINGLE_IMPACT_DAMAGE = 50f;

	private const float STICK_IN_DAMAGE_SCALAR = 0.75f;

	private const float DEFLECTION_DAMAGE_SCALAR = 1.5f;

	private const float ARROW_BOUNDING_RADIUS = 0.5f;

	private const float ANTI_COLLISION_FUDGE_FACTOR = 0.1f;

	private const float INTERIOR_CORRECTION_TEST_DIST = 8f;

	public WeaponSource m_ArrowType;

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

	public float m_BowDegradeModifier;

	public GameObject m_BrokenArrow;

	private AK.Wwise.Event m_FlightAudioEvent;

	private AK.Wwise.Event m_ImpactAudioEvent;

	private AK.Wwise.Event m_BreakAudioEvent;

	public float m_ImpactAudioCooldown;

	public float m_GearImpactForce;

	public float m_GearImpactUpwardForce;

	public float m_GearImpactTorqueForce;

	private int m_CraftingSkillPoints;

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

	public int CraftingSkillPoints
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrowItem), Member = "Initialize")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[CalledBy(Type = typeof(ArrowManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 22)]
	public ArrowSaveData Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ArrowManager), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ArrowItem), Member = "ParentToObject")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public void Deserialize(ArrowSaveData asd)
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionEnter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GearItem), Member = "ApplyForce")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyForcesToGear(GearItem gi, Vector3 normal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody), Member = "IsSleeping")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(ArrowItem), Member = "StopArrow")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "set_forward")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrowItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ArrowItem), Member = "RefreshLineRenderer")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 17)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrowItem), Member = "Initialize")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 18)]
	public void Fire()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool InFlight(bool onlyConsiderFirstImpact)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool BelongsToPlayer()
	{
		return false;
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClear")]
	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 15)]
	public void DetachIntoWorld()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void SetPlacementHelperEnabled(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(ArrowItem), Member = "ApplyForcesToGear")]
	[Calls(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 10)]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 15)]
	private void StopArrow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CallsUnknownMethods(Count = 1)]
	private LocalizedDamage GetDamageParameters(GameObject victim, out float partDamageScalar, out float bleedOutMinutes)
	{
		partDamageScalar = default(float);
		bleedOutMinutes = default(float);
		return null;
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionStay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[Calls(Type = typeof(EffectPool<>), Member = "SpawnUntilParticlesDone")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeSpawnImpactEffects(GameObject victim, Vector3 collisionPoint, Vector3 collisionNormal, SurfaceResponseInfo sri)
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionEnter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(ArrowItem), Member = "RefreshLineRenderer")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(ArrowItem), Member = "GetSurfaceResponseInfo")]
	[Calls(Type = typeof(ArrowItem), Member = "MaybeSpawnImpactEffects")]
	[Calls(Type = typeof(ArrowItem), Member = "PlayImpactAudio")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ArrowItem), Member = "ParentToObject")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(ArrowItem), Member = "FallFree")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(ArrowItem), Member = "Break")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ArrowItem), Member = "MaybeScareWildlife")]
	[Calls(Type = typeof(ArrowItem), Member = "StopArrow")]
	[CallsDeduplicatedMethods(Count = 42)]
	[CallsUnknownMethods(Count = 39)]
	private void HandleCollisionWithObject(GameObject collider, Vector3 collisionPoint, Vector3 collisionNormal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ArrowItem), Member = "GetSurfaceResponseInfo")]
	[Calls(Type = typeof(ArrowItem), Member = "MaybeSpawnImpactEffects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private void OnCollisionStay(Collision collision)
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	private void ParentToObject(Transform t)
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void PlayImpactAudio(string surfaceTag)
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionStay")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	private SurfaceResponseInfo GetSurfaceResponseInfo(string surfaceTag, bool isSecondaryHit)
	{
		return default(SurfaceResponseInfo);
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void FallFree()
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Rigidbody), Member = "set_mass")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 14)]
	private void Break()
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[Calls(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(ArrowItem), Member = "Break")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private BaseAi InflictDamage(GameObject victim, float damageScalar, bool stickIn, string collider, Vector3 collisionPoint)
	{
		return null;
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromArrow")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeScareWildlife()
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void RefreshLineRenderer()
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "Awake")]
	[CalledBy(Type = typeof(ArrowItem), Member = "Fire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	public ArrowItem()
	{
	}
}
