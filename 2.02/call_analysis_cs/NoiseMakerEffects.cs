using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NoiseMakerEffects : MonoBehaviour
{
	private Renderer m_FuseRenderer;

	private Transform[] m_WickTransformChain;

	private Transform m_WickFXRoot;

	private ParticleSystem m_WickFX;

	private ParticleSystem m_DetonateFX;

	private GearItem m_GearItem;

	private static readonly int s_BurnStrengthPropertyID;

	private static readonly int s_BurnPositionPropertyID;

	private MaterialPropertyBlock m_FuseBurnPropertyBlock;

	private NoiseMakerState m_LastState;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void SetEffectsHidden(bool isHidden)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public GameObject GetDetonateEffectObject()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "GetInterpolatedPointAlongWick")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "UpdateFuseBurnEffect")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "MaybeLeaveScorchMarkOnGround")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "PlayDetonateInHand")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void PlayDetonateInHand()
	{
	}

	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	private void EnableDisconnectedEffect(ParticleSystem effect, bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "EnableDisconnectedEffect")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "PlayDetonateInHand")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	private void EnableEffect(ParticleSystem effect, bool isEnabled)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeLeaveScorchMarkOnGround()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "GetImpactEffectTypeBasedOnMaterial")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private static void LeaveScorchMark(RaycastHit hit)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "LeaveScorchMark")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private static ScorchImpactEffectType GetImpactEffectTypeBasedOnMaterial(string tag)
	{
		return default(ScorchImpactEffectType);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateFuseBurnEffect(float burnPosition, float burnStrength)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 1)]
	private Vector3 GetInterpolatedPointAlongWick(float ratio)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NoiseMakerEffects()
	{
	}
}
