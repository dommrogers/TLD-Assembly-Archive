using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using UnityEngine;

public class FlareGunRoundItem : MonoBehaviour
{
	public enum FlightStatus
	{
		None,
		InFlight,
		FlightCompleted
	}

	internal struct SurfaceResponseInfo
	{
		internal float surfaceHardness;

		internal float deflectScalar;

		internal Vector2 impactVelocityScalars;

		internal GameObject impactPrefab;
	}

	public const float ROUND_LENGTH = 0.05f;

	public const float CENTER_OF_MASS_FRAC = 0.23f;

	public const float MAX_EMBED_FRAC = 0.7f;

	public const float MIN_PIERCE_VEL_BY_SURFACE_SCALE = 0.65f;

	public const float MAX_FALL_OUT_TIME = 1f;

	public const float MIN_STICK_IN_DEPTH = 0.001f;

	public const float MIN_STICK_IN_RANDOM_COMPONENT = 0.01f;

	public const float SOFTEST_DEFLECT_ANGLE = 75f;

	public const float HARDEST_DEFLECT_ANGLE = 0f;

	public const string ROUND_COLLISION_LAYER = "Gear";

	public const float MIN_TIME_BETWEEN_HIT_EFFECTS = 0.1f;

	public const float MIN_VELOCITY_FOR_HIT_EFFECT_SQR = 2f;

	public const float MAX_SINGLE_IMPACT_DAMAGE = 50f;

	public const float STICK_IN_DAMAGE_SCALAR = 0.25f;

	public const float DEFLECTION_DAMAGE_SCALAR = 1.5f;

	public const float SMOKE_CLEAR_TIME = 5f;

	public float m_ReleaseVelocity;

	public float m_ReleaseDrag;

	public float m_VictimDamage;

	public float m_XZDampeningScalar;

	public Vector2 m_XZDampeningRange;

	public float m_BurnTime;

	public float m_MaxBurnTimeOnWildlife;

	public Vector3 m_AdditionalGravity;

	public GameObject m_ImpactDirtPrefab;

	public GameObject m_ImpactConcretePrefab;

	public GameObject m_ImpactFabricPrefab;

	public GameObject m_ImpactFleshPrefab;

	public GameObject m_ImpactGlassPrefab;

	public GameObject m_ImpactIcePrefab;

	public GameObject m_ImpactMetalPrefab;

	public GameObject m_ImpactSnowPrefab;

	public GameObject m_ImpactWoodPrefab;

	public string m_OnFireAudio;

	public string m_BurningAudio;

	public string m_OnImpactAudio;

	public string m_BurnOutAudio;

	public GameObject m_FXGameObject;

	public ParticleSystem m_SmokeParticleSystem;

	public ParticleSystem m_SmokeCoreParticleSystem;

	public GameObject m_FlareEffectInFlight;

	public GameObject m_FlareEffectAfterLanding;

	public GameObject m_Light;

	public float m_ParticleRestEmission;

	public float m_ParticleVelocityEmissionMultiplier;

	public Color m_SmokeColorWhenExtinguished;

	public Color m_SmokeCoreColorWhenExtinguished;

	public Rigidbody m_Rigidbody;

	private int m_ContactCount;

	private float m_EmbeddedDepth;

	private BaseAi m_EmbeddedInAi;

	private float m_EmbeddedInAiDeadTime;

	private float m_FallOutTimer;

	private float m_ReleaseTime;

	private float m_LastEffectTime;

	private uint m_BurningAudioId;

	private float m_BurnTimer;

	private float m_SmokeClearTime;

	private bool m_StartHasBeenCalled;

	private MeshRenderer m_MeshRenderer;

	private FlightStatus m_FlightStatus;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(FlareGunRoundManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "BelongsToPlayer")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 24)]
	public FlareGunRoundSaveData Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(FlareGunRoundManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "FlightComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "ParentToObject")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 16)]
	public void Deserialize(FlareGunRoundSaveData asd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "BurnOut")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 14)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "set_forward")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 11)]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "FallFree")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 11)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "SpawnAndFire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 13)]
	public void Fire()
	{
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private void BurnOut()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsBurning()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool InFlight(bool onlyConsiderFirstImpact)
	{
		return false;
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public bool BelongsToPlayer()
	{
		return false;
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void FlightComplete()
	{
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "OnCollisionEnter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "FlightComplete")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_mass")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "GetSurfaceResponseInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "PlayImpactAudio")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "ParentToObject")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "FallFree")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlareGunRound")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[CallsDeduplicatedMethods(Count = 43)]
	[CallsUnknownMethods(Count = 34)]
	private void HandleCollisionWithObject(GameObject colliderGO, Vector3 collisionPoint, Vector3 collisionNormal, Vector3 relativeVelocity)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallsUnknownMethods(Count = 2)]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "GetSurfaceResponseInfo")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 16)]
	private void OnCollisionStay(Collision collision)
	{
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void ParentToObject(Transform t)
	{
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void PlayImpactAudio(string surfaceTag)
	{
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "OnCollisionStay")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	private SurfaceResponseInfo GetSurfaceResponseInfo(string surfaceTag)
	{
		return default(SurfaceResponseInfo);
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void FallFree()
	{
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[Calls(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromFlareGunRound")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private BaseAi InflictDamage(GameObject victim, float damageScalar, bool stickIn, string collider)
	{
		return null;
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromFlareGunRound")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeScareWildlife(PackAnimal ignoreMoraleOnAnimal)
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "Fire")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static GameObject SpawnAndFire(GameObject prefab, Vector3 startPos, Quaternion startRot)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public FlareGunRoundItem()
	{
	}
}
