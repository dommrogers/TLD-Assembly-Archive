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
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StoneItem), Member = "SetThrown")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void FixedUpdate()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[Calls(Type = typeof(ImpactDecals), Member = "MapSurfaceTagToMaterialEffectType")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	private void PlayImpactEffects(string surfaceTag, Vector3 collisionPoint, Vector3 normal)
	{
	}

	[Calls(Type = typeof(StoneItem), Member = "SetThrown")]
	[Calls(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeStunnedByStone")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(GearItem), Member = "EnablePhysics")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void PrepareForThrow()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	public void PickedUp()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(PlayerManager), Member = "Throw")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Throw()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	public void ZoomStart()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	[Calls(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	public void ZoomEnd()
	{
	}

	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(StoneItem), Member = "Update")]
	[CallerCount(Count = 4)]
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
	[CallerCount(Count = 2)]
	private void OnAiming()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnAimingCancelled()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(Inventory), Member = "GetBestStone")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnThrowComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public StoneItem()
	{
	}
}
