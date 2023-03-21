using System;
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

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(FlareGunRoundManager), Member = "Serialize")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "BelongsToPlayer")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public FlareGunRoundSaveData Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(FlareGunRoundManager), Member = "Deserialize")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "ParentToObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "FlightComplete")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void Deserialize(FlareGunRoundSaveData asd)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "BurnOut")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "set_forward")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "FallFree")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "FallFree")]
	[CallsUnknownMethods(Count = 11)]
	private void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "SpawnAndFire")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void Fire()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	private void BurnOut()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsBurning()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool InFlight(bool onlyConsiderFirstImpact)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 4)]
	public bool BelongsToPlayer()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	private void FlightComplete()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "FallFree")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlareGunRound")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "OnCollisionEnter")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "ParentToObject")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 44)]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "FlightComplete")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_mass")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "GetSurfaceResponseInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "PlayImpactAudio")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	private void HandleCollisionWithObject(GameObject colliderGO, Vector3 collisionPoint, Vector3 collisionNormal, Vector3 relativeVelocity)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "GetSurfaceResponseInfo")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallsUnknownMethods(Count = 6)]
	private void ParentToObject(Transform t)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void PlayImpactAudio(string surfaceTag)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "OnCollisionStay")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private SurfaceResponseInfo GetSurfaceResponseInfo(string surfaceTag)
	{
		return default(SurfaceResponseInfo);
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "LateUpdate")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	private void FallFree()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromFlareGunRound")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[Calls(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	private BaseAi InflictDamage(GameObject victim, float damageScalar, bool stickIn, string collider)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromFlareGunRound")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	private void MaybeScareWildlife(PackAnimal ignoreMoraleOnAnimal)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "Fire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static GameObject SpawnAndFire(GameObject prefab, Vector3 startPos, Quaternion startRot)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public FlareGunRoundItem()
	{
	}
}
