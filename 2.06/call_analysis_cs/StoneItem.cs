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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void FixedUpdate()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[Calls(Type = typeof(ImpactDecals), Member = "MapSurfaceTagToMaterialEffectType")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	private void PlayImpactEffects(string surfaceTag, Vector3 collisionPoint, Vector3 normal)
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeStunnedByStone")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(GearItem), Member = "EnablePhysics")]
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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "Throw")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Throw()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CallsUnknownMethods(Count = 6)]
	public void ZoomStart()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void ZoomEnd()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CallsUnknownMethods(Count = 3)]
	public void SetThrown(bool thrown)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsThrown()
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void OnAiming()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnAimingCancelled()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestStone")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsUnknownMethods(Count = 2)]
	private void OnThrowComplete()
	{
	}

	[CallerCount(Count = 0)]
	public StoneItem()
	{
	}
}
