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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "PlayDetonateInHand")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "MaybeLeaveScorchMarkOnGround")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "UpdateFuseBurnEffect")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "GetInterpolatedPointAlongWick")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	private void PlayDetonateInHand()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void EnableDisconnectedEffect(ParticleSystem effect, bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "PlayDetonateInHand")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "EnableDisconnectedEffect")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void EnableEffect(ParticleSystem effect, bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeLeaveScorchMarkOnGround()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "GetImpactEffectTypeBasedOnMaterial")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private static void LeaveScorchMark(RaycastHit hit)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "LeaveScorchMark")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static ScorchImpactEffectType GetImpactEffectTypeBasedOnMaterial(string tag)
	{
		return default(ScorchImpactEffectType);
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateFuseBurnEffect(float burnPosition, float burnStrength)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private Vector3 GetInterpolatedPointAlongWick(float ratio)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NoiseMakerEffects()
	{
	}
}
