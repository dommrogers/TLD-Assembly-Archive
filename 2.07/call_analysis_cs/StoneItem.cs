using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StoneItem : MonoBehaviour
{
	public string m_CollideAudio;

	public float m_AudioVelocityThreshold;

	public float m_ThrowForce;

	public float m_ThrowTorque;

	public Vector3 m_AdditionalGravity;

	public float m_ThrowSpeedThreshold;

	public float m_CollisionDamping;

	public float m_ColliderScaleWhenThrown;

	public bool m_CanThrow;

	private GearItem m_GearItem;

	private Rigidbody m_RigidBody;

	private BoxCollider m_Collider;

	private bool m_Thrown;

	private Vector3 m_DefaultColliderSize;

	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void FixedUpdate()
	{
	}

	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(ImpactDecals), Member = "MapSurfaceTagToMaterialEffectType")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	private void PlayImpactEffects(string surfaceTag, Vector3 collisionPoint, Vector3 normal)
	{
	}

	[Calls(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeStunnedByStone")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsAttachedToGearPlacePoint")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PrepareForThrow()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	public void PickedUp()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "Throw")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Throw()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[CallsUnknownMethods(Count = 1)]
	public void ZoomStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	[Calls(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[CallsUnknownMethods(Count = 1)]
	public void ZoomEnd()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	public void SetThrown(bool thrown)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsThrown()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnAiming()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnAimingCancelled()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestStone")]
	private void OnThrowComplete()
	{
	}

	[CallerCount(Count = 0)]
	public StoneItem()
	{
	}
}
